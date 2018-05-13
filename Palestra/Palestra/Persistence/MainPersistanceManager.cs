using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Palestra.model;

namespace Palestra.Persistence
{
    public class MainPersistanceManager : IAllenamentoPersistenceManager, IEsercizioPersistanceManager, IPianoAllenamentoPersistenceManager, IUtentePersistenceManager, IIDGeneerator
    {
        private List<Esercizio> _esercizi;
        private SqlConnection _conn; 

        public MainPersistanceManager()
        {
            //connessione al database che rimarrà connesso per tutta la durata dell'applicazione
            Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=NOMESERVER;Initial Catalog=NOMEDB;Integrated Security=True";
            Conn.Open();

            _esercizi = new List<Esercizio>();
            _esercizi.Add(new Esercizio("panca piana", FasciaMuscolare.Pettorali, "", Risorsa.SalaPesi ));
            //mettere tutti gli esercizi nella lista
        }

        public SqlConnection Conn { get => _conn; set => _conn = value; }

        /*
         * 
         * 
         * funzioni loading salvataggio e deleting
         * 
         */

        public Utente Autentica(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllenamenti()
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("delete from ALLENAMENTI", Conn);
                return myCommand.ExecuteNonQuery() > 0;
            }
            catch(SqlException e)
            {
                throw;
            }
        }

        public bool DeletePianoAllenamento(Utente utente)
        {
            //grazie ad on delete cascade mi si eliminano anche tutti le tuple referenziate
            try
            {
                SqlCommand myCommand = new SqlCommand("delete from PIANIALLENAMENTI where ID=" + utente.ID, Conn);
                return myCommand.ExecuteNonQuery() > 0;
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public bool DeleteUtente(Utente utente)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("delete from UTENTI where ID=" + utente.ID, Conn);
                return myCommand.ExecuteNonQuery() > 0;
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public IEnumerable<Allenamento> LoadAllAllenamenti()
        {
            List<Allenamento> allenamenti = new List<Allenamento>();
            try
            { 
                SqlCommand myCommand = new SqlCommand("select * from ALLENAMENTI",   Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    allenamenti.Add(new Allenamento((int)myReader["durataInMinuti"], (DateTime)myReader["data"]));
                }
            }
            catch (SqlException e)
            {
                throw;
            }
            return allenamenti;
        }

        public IEnumerable<Esercizio> LoadAllEsercizi()
        {
            return _esercizi;
        }

        public PianoAllenamento LoadPianoAllenamento(Utente utente)
        {
            PianoAllenamento pianoAllenamento;
            try
            {
                SqlCommand commandPianiAllenamenti = new SqlCommand("select * from PIANIALLENAMENTO where ID=" + utente.ID, Conn);
                SqlDataReader readerPianiAllenamenti = commandPianiAllenamenti.ExecuteReader();
                readerPianiAllenamenti.Read();
                string tipoString = (string)readerPianiAllenamenti["tipoAllenamento"];
                TipoAllenamento? tipo;
                tipo = getTipoAllenamento(tipoString);
                pianoAllenamento = new PianoAllenamento(tipo.Value);

                SqlCommand commandGiorniAllenamenti = new SqlCommand("select * from GIORNIALLENAMENTI where Con_ID=" + utente.ID, Conn);
                SqlDataReader readerGiorniAllenamenti = commandPianiAllenamenti.ExecuteReader();
                GiornoAllenamento giornoAllenamento;
                while (readerGiorniAllenamenti.Read())
                {
                    giornoAllenamento = new GiornoAllenamento((int)readerGiorniAllenamenti["tempoRecuperoTraEsercizi"]);
                    SqlCommand commandEsecuzioneEsercizio = new SqlCommand("select * from ESECUZIONIESERCIZI where Ha_ID=" + readerGiorniAllenamenti["ID"], Conn);
                    SqlDataReader readerEsecuzioneEsercizio = commandPianiAllenamenti.ExecuteReader();
                    while (readerEsecuzioneEsercizio.Read())
                    {

                        //discrimino se l'esercizio è a serie o a tempo
                        SqlCommand commandEsecuzioneEsercizioATempo = new SqlCommand("select * from ESECUZIONIESERCIZIATEMPO where ID=" + readerEsecuzioneEsercizio["ID"], Conn);
                        SqlDataReader readerEsecuzioneEsercizioAtempo = commandPianiAllenamenti.ExecuteReader();
                        if (readerEsecuzioneEsercizioAtempo.HasRows)
                        {
                            readerEsecuzioneEsercizioAtempo.Read();
                            giornoAllenamento.addEsecuzioneEsercizio(new EsecuzioneEsercizioATempo(GetEsercizioByName((string)readerEsecuzioneEsercizio["nomeEsercizio"]), (int)readerEsecuzioneEsercizioAtempo["tempo"]));
                        }
                        else
                        {
                            SqlCommand commandEsecuzioneEsercizioASerie = new SqlCommand("select * from ESECUZIONIESERCIZIASERIE where ID=" + readerEsecuzioneEsercizio["ID"], Conn);
                            SqlDataReader readerEsecuzioneEsercizioASerie = commandPianiAllenamenti.ExecuteReader();
                            readerEsecuzioneEsercizio.Read();
                            giornoAllenamento.addEsecuzioneEsercizio(new EsecuzioneEsercizioASerie(GetEsercizioByName((string)readerEsecuzioneEsercizio["NomeEsercizio"]), (int)readerEsecuzioneEsercizioASerie["tempoDiRecuperoTraSerie"],
                            (int)readerEsecuzioneEsercizioASerie["numeroRipetizioni"], (int)readerEsecuzioneEsercizioASerie["numeroSerie"]));
                        }

                    }
                    pianoAllenamento.inserisciGiornoAllenamento(giornoAllenamento);

                }
            }
            catch (SqlException e)
            {
                throw;
            }
            return pianoAllenamento;
        }


        public Utente LoadUtente()
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("select * from UTENTI", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                Sesso? sesso = getSesso((string)myReader["sesso"]);

                //verifico se è un utente automatico
                SqlCommand myCommand2 = new SqlCommand("select * from UTENTIAUTOMATICI where ID=" + myReader["ID"], Conn);
                SqlDataReader myReader2 = myCommand2.ExecuteReader();
                if (myReader2.HasRows)
                {
                    myReader2.Read();
                    TipoAllenamento? tipo = getTipoAllenamento((string) myReader2["tipoAllenamento"]);
                    Risorsa? risorsa = getRisorsa((string) myReader2["risorsa"]);
                    return new UtenteAutomatico((string)myReader["nome"], (string)myReader["cognome"], (DateTime)myReader["data"], (int)myReader["peso"], (int)myReader["altezza"], sesso.Value, tipo.Value, risorsa.Value, (int)myReader2["numeroAllenamentiSettimanali"]);
                }

                return new Utente((string)myReader["nome"], (string)myReader["cognome"], (DateTime)myReader["data"], (int)myReader["peso"], (int)myReader["altezza"], sesso.Value);
                  
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public bool SaveAllenamento(Utente utente, Allenamento allenamento)
        {
            try
            {
                //uso di SqlParameter per garantire sicurezza e evitare Sql Injection
                SqlParameter data = new SqlParameter("@Param1", SqlDbType.Date, 11);
                data.Value = allenamento.Data;

                SqlParameter durata = new SqlParameter("@Param2", SqlDbType.Int);
                durata.Value = allenamento.DurataInMinuti;

                SqlParameter utenteID = new SqlParameter("@Param3", SqlDbType.VarChar);
                utenteID.Value = utente.ID;

                int allenamentoID = generaAllenamentoID();

                //fondamentale per salvare l'ID internamente
                allenamento.ID = allenamentoID;
                if (allenamento.PesoInKg != default(int) )
                {
                    SqlParameter peso = new SqlParameter("@Param4", SqlDbType.Int, 11);
                    peso.Value = allenamento.PesoInKg;
                    SqlCommand myCommand = new SqlCommand("INSERT INTO ALLENAMENTI Values (" + allenamentoID + ", @Param4, @Param1, @Param2, @Param3)", Conn);
                    myCommand.Parameters.Add(data);
                    myCommand.Parameters.Add(utenteID);
                    myCommand.Parameters.Add(durata);
                    myCommand.Parameters.Add(peso);

                    myCommand.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand myCommand = new SqlCommand("INSERT INTO (ID, data, durata, Ese_ID) Values (" + allenamentoID + ", @Param1, @Param2, @Param3)", Conn);
                    myCommand.Parameters.Add(data);
                    myCommand.Parameters.Add(utenteID);
                    myCommand.Parameters.Add(durata);

                    myCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public bool SavePianoAllenamento(Utente utente, PianoAllenamento pianoAllenamento)
        {
            try
            {
                //uso di SqlParameter per garantire sicurezza e evitare Sql Injection
                SqlParameter utenteID = new SqlParameter("@Param1", SqlDbType.Int, 11);
                utenteID.Value = utente.ID;

                SqlParameter numeroGiorniAllenamento = new SqlParameter("@Param2", SqlDbType.Int, 11);
                numeroGiorniAllenamento.Value = pianoAllenamento.NumeroGiorniAllenamento;

                SqlParameter tipoAllenamento = new SqlParameter("@Param3", SqlDbType.VarChar);
                tipoAllenamento.Value = pianoAllenamento.TipoAllenamento.ToString();


                SqlCommand myCommand = new SqlCommand("INSERT INTO Values (@Param1, @Param2, @Param3)", Conn);
                myCommand.Parameters.Add(utenteID);
                myCommand.Parameters.Add(numeroGiorniAllenamento);
                myCommand.Parameters.Add(tipoAllenamento);

                myCommand.ExecuteNonQuery();


                foreach (GiornoAllenamento giornoAllenamento in pianoAllenamento.GiorniAllenamento)
                {
                    int giornoAllenamentoID = generaGiornoAllenamentoID();

                    //fondamentale per salvare l'ID internamente
                    giornoAllenamento.ID = giornoAllenamentoID;

                    SqlParameter tempoRecuperoTraEsercizi = new SqlParameter("@Param4", SqlDbType.Int, 11);
                    tempoRecuperoTraEsercizi.Value = giornoAllenamento.TempoDiRecuperoInSec;


                    SqlCommand myCommand2 = new SqlCommand("INSERT INTO GIORNIALLENAMENTI Values (" + giornoAllenamentoID + ", @Param4, @Param1)", Conn);
                    myCommand2.Parameters.Add(tempoRecuperoTraEsercizi);
                    myCommand2.Parameters.Add(utenteID);

                    myCommand2.ExecuteNonQuery(); 

                    foreach(EsecuzioneEsercizio esecuzioneEsercizio in giornoAllenamento.ListaEsecuzioniEsercizi)
                    {
                        int esecuzioneEsercizioID = generaInsiemeSerieID();
                        esecuzioneEsercizio.ID = esecuzioneEsercizioID;

                        SqlParameter nomeEsercizio = new SqlParameter("@Param5", SqlDbType.VarChar, 11);
                        nomeEsercizio.Value = esecuzioneEsercizio.Esercizio.Nome;
                        SqlCommand myCommand3;
                        SqlCommand myCommand4;

                        if (esecuzioneEsercizio is EsecuzioneEsercizioASerie)
                        {
                            EsecuzioneEsercizioASerie myEsecuzioneEsercizioASerie = (EsecuzioneEsercizioASerie) esecuzioneEsercizio;
                            SqlParameter esecuzioneEsercizioASerie = new SqlParameter("@Param6", SqlDbType.Int, 11);
                            esecuzioneEsercizioASerie.Value = 1;
                            myCommand3 = new SqlCommand("INSERT INTO ESECUZIONIESERCIZI(ID, nomeEsercizio, Ha_ID, ESECUZIONIESERCIZIASERIE Values (" + esecuzioneEsercizioID + ", @Param5, " + giornoAllenamentoID + ",  @Param6)", Conn);
                            myCommand3.Parameters.Add(esecuzioneEsercizioASerie);

                            SqlParameter numeroSerie = new SqlParameter("@Param7", SqlDbType.Int, 11);
                            numeroSerie.Value = myEsecuzioneEsercizioASerie.NumeroSerie;

                            SqlParameter numeroRipetizioni = new SqlParameter("@Param8", SqlDbType.Int);
                            numeroRipetizioni.Value = myEsecuzioneEsercizioASerie.NumeroRipetizioni;

                            SqlParameter tempoDiRecuperoTraSerie = new SqlParameter("@Param9", SqlDbType.Int);
                            tempoDiRecuperoTraSerie.Value = myEsecuzioneEsercizioASerie.TempoDiRecuperoInSec;

                            if(myEsecuzioneEsercizioASerie.Carico != default(int))
                            {
                                SqlParameter carico = new SqlParameter("@Param10", SqlDbType.Int);
                                carico.Value = myEsecuzioneEsercizioASerie.Carico;
                                myCommand4 = new SqlCommand("INSERT INTO ESECUZIONIESERCIZIASERIE(ID, numeroSerie, numeroRipetizioni, tempoDiRecuperoTraSerie, carico) values (" + esecuzioneEsercizioID + ", @Param7, @Param8, @Param9, @Param10");
                                myCommand4.Parameters.Add(carico);
                            }
                            else
                            {
                                myCommand4 = new SqlCommand("INSERT INTO ESECUZIONIESERCIZIASERIE(ID, numeroSerie, numeroRipetizioni, tempoDiRecuperoTraSerie) values (" + esecuzioneEsercizioID + ", @Param7, @Param8, @Param9");
                            }
                            myCommand4.Parameters.Add(numeroSerie);
                            myCommand4.Parameters.Add(numeroRipetizioni);
                            myCommand4.Parameters.Add(tempoDiRecuperoTraSerie);


                        }
                        else
                        {
                            EsecuzioneEsercizioATempo myEsecuzioneEsercizioATempo = (EsecuzioneEsercizioATempo) esecuzioneEsercizio;
                            SqlParameter esecuzioneEsercizioATempo = new SqlParameter("@Param6", SqlDbType.Int, 11);
                            esecuzioneEsercizioATempo.Value = 1;
                            myCommand3 = new SqlCommand("INSERT INTO ESECUZIONIESERCIZI(ID, nomeEsercizio, Ha_ID, ESECUZIONIESERCIZIATEMPO Values (" + esecuzioneEsercizioID + ", @Param5, " + giornoAllenamentoID + ",  @Param6)", Conn);
                            myCommand3.Parameters.Add(esecuzioneEsercizioATempo);

                            SqlParameter tempo = new SqlParameter("@Param11", SqlDbType.Int, 11);
                            tempo.Value = myEsecuzioneEsercizioATempo.Tempo;

                            myCommand4 = new SqlCommand("INSERT INTO ESECUZIONIESERCIZIATEMPO values ( " + esecuzioneEsercizioID + ", @Param11)", Conn);
                            myCommand4.Parameters.Add(tempo);

                        }

                        myCommand3.Parameters.Add(nomeEsercizio);
                    
                        myCommand3.ExecuteNonQuery();
                        myCommand4.ExecuteNonQuery();

                    }
                }
                return true;
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public bool SaveUtente(Utente utente)
        {
            try
            {
                //uso di SqlParameter per garantire sicurezza e evitare Sql Injection
                SqlParameter myParam = new SqlParameter("@Param1", SqlDbType.VarChar, 11);
                myParam.Value = utente.Nome;

                SqlParameter myParam2 = new SqlParameter("@Param2", SqlDbType.VarChar, 11);
                myParam2.Value = utente.Cognome;

                SqlParameter myParam3 = new SqlParameter("@Param3", SqlDbType.Date);
                myParam3.Value = utente.DataDiNascita;

                SqlParameter myParam4 = new SqlParameter("@Param4", SqlDbType.Bit);
                myParam4.Value = utente.Sesso;

                SqlParameter myParam5 = new SqlParameter("@Param5", SqlDbType.Int, 2);
                myParam5.Value = utente.AltezzaInCm;

                SqlParameter myParam6 = new SqlParameter("@Param6", SqlDbType.Int, 2);
                myParam6.Value = utente.PesoInKg;

                int ID = generaUtenteID();

                //fondamentale per salvare l'ID internamente
                utente.ID = ID;

                SqlCommand myCommand = new SqlCommand("INSERT INTO Utenti (ID, Nome, Cognome, DataDiNascita, Sesso, AltezzaInCm, PesoInKg)" +
                    " Values (" + ID + ", @Param1, @Param2, @Param3, @Param4, @Param5, @Param6)", Conn);
                myCommand.Parameters.Add(myParam);
                myCommand.Parameters.Add(myParam2);
                myCommand.Parameters.Add(myParam3);
                myCommand.Parameters.Add(myParam4);
                myCommand.Parameters.Add(myParam5);
                myCommand.Parameters.Add(myParam6);

                myCommand.ExecuteNonQuery();

                return true;
            }
            catch(SqlException e)
            {
                throw;
            }
        }


        /*
         * 
         * ALTRE FUNZIONI DB
         * 
         */

        //da invocare sempre alla chiusura dell'applicazione
        public void CloseConnection()
        {
            _conn.Close();
        }

        public int generaUtenteID()
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("select utente from IDs", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["utente"] + 1;

                SqlCommand update = new SqlCommand("update IDs set utente = " + ID, Conn);
                update.ExecuteNonQuery();
                return ID;
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public int generaAllenamentoID()
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("select allenamento from IDs", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["allenamento"] + 1;

                SqlCommand update = new SqlCommand("update IDs set allenamento = " + ID, Conn);
                update.ExecuteNonQuery();
                return ID;
            }
            catch(SqlException e)
            {
                throw;
            }

        }

        public int generaGiornoAllenamentoID()
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("select giornoAllenamento from IDs", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["giornoAllenamento"] + 1;

                SqlCommand update = new SqlCommand("update IDs set giornoAllenamento = " + ID, Conn);
                update.ExecuteNonQuery();
                return ID;
            }
            catch (SqlException e)
            {
                throw;
            }
        }

       public int generaInsiemeSerieID()
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("select esecuzioneEsercizio from IDs", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["esecuzioneEsercizio"] + 1;

                SqlCommand update = new SqlCommand("update IDs set esecuzioneEsercizio = " + ID, Conn);
                update.ExecuteNonQuery();
                return ID;
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void setIDs()
        {
            try
            {

                SqlCommand insert = new SqlCommand("insert IDs into IDs values (0,0,0,0)", Conn);
                insert.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void resetIDs()
        {
            try
            {

                SqlCommand update = new SqlCommand("update IDs set allenamento = 0, esecuzioneEsercizio = 0, giornoAllenamento = 0, utente = 0", Conn);
                update.ExecuteNonQuery();
                
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public bool ThereIsASavedAccount()
        {
            try
            {

                SqlCommand select = new SqlCommand("select * from IDs", Conn);
                SqlDataReader myReader = select.ExecuteReader();
                myReader.Read();
                if (myReader.HasRows)
                    return true;
                else
                {
                    setIDs();
                    return false;
                }

            }
            catch (SqlException e)
            {
                throw;
            }
        }

/*
 * 
 * 
 * FUNZIONI ACCESSORIE
 * 
 */

        private static TipoAllenamento? getTipoAllenamento(string tipoString)
        {
            TipoAllenamento? tipo = null;
            switch (tipoString)
            {
                case "ipertofia":
                    tipo = TipoAllenamento.Ipertrofia;
                    break;
                case "definizione":
                    tipo = TipoAllenamento.Definizione;
                    break;
                case "tonificazione":
                    tipo = TipoAllenamento.Tonificazione;
                    break;
            }

            return tipo;
        }


        private static Sesso? getSesso(string sessoString)
        {
            Sesso? sesso = null;
            switch (sessoString)
            {
                case "maschio":
                    sesso = Sesso.Maschio;
                    break;
                case "femmina":
                    sesso = Sesso.Femmina;
                    break;
            }
            return sesso;
        }

        private static Risorsa? getRisorsa(string risorsaString)
        {
            Risorsa? risorsa = null;
            switch (risorsaString)
            {
                case "corpoLibero":
                    risorsa = Risorsa.CorpoLibero;
                    break;
                case "salaPesi":
                    risorsa = Risorsa.SalaPesi;
                    break;
            }
            return risorsa;
        }





        private Esercizio GetEsercizioByName(string nome)
        {
            foreach (Esercizio esercizio in _esercizi)
            {
                if (esercizio.Nome.Equals(nome))
                    return esercizio;
            }
            return null;
        }
    }
}
