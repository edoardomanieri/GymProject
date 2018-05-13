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
            Conn.ConnectionString = "Data Source=EDOARDO;Initial Catalog=PalestraDB;Integrated Security=True";
            Conn.Open();

            _esercizi = new List<Esercizio>();
            _esercizi.Add(new Esercizio("panca piana", FasciaMuscolare.Pettorali, "", Risorsa.SalaPesi));
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
                SqlCommand delete = new SqlCommand("delete from ALLENAMENTI;", Conn);
                return delete.ExecuteNonQuery() > 0;
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public bool DeletePianoAllenamento(Utente utente)
        {
            //grazie ad on delete cascade mi si eliminano anche tutti le tuple referenziate
            try
            {
                SqlCommand delete = new SqlCommand("delete from PIANIALLENAMENTI where ID=" + utente.ID + ";", Conn);
                return delete.ExecuteNonQuery() > 0;
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
                SqlCommand delete = new SqlCommand("delete from UTENTI where ID=" + utente.ID + ";", Conn);
                return delete.ExecuteNonQuery() > 0;
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
                SqlCommand selectAllenamenti = new SqlCommand("select * from ALLENAMENTI;", Conn);
                SqlDataReader readerAllenamenti = selectAllenamenti.ExecuteReader();
                while (readerAllenamenti.Read())
                {
                    if (readerAllenamenti["peso"] != null)
                    {
                        int peso = (int)readerAllenamenti["peso"];
                        allenamenti.Add(new Allenamento((int)readerAllenamenti["durataInMinuti"], (DateTime)readerAllenamenti["data"], peso));

                    }
                    else
                    {
                        allenamenti.Add(new Allenamento((int)readerAllenamenti["durataInMinuti"], (DateTime)readerAllenamenti["data"]));
                    }
                }
                readerAllenamenti.Close();
                return allenamenti;
            }
            catch (SqlException e)
            {
                throw;
            }
           
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
                pianoAllenamento = new PianoAllenamento();

                SqlCommand commandGiorniAllenamenti = new SqlCommand("select * from GIORNIALLENAMENTI where Con_ID=" + utente.ID + ";", Conn);
                SqlDataReader readerGiorniAllenamenti = commandGiorniAllenamenti.ExecuteReader();
                GiornoAllenamento giornoAllenamento;
                while (readerGiorniAllenamenti.Read())
                {
                    giornoAllenamento = new GiornoAllenamento((int)readerGiorniAllenamenti["tempoRecuperoTraEsercizi"]);
                    giornoAllenamento.ID = (int)readerGiorniAllenamenti["ID"];

                    using (SqlConnection conn2 = new SqlConnection(Conn.ConnectionString))
                    using (SqlCommand commandEsecuzioneEsercizio = new SqlCommand("select * from ESECUZIONIESERCIZI where Ha_ID=" + readerGiorniAllenamenti["ID"] + ";", conn2))
                    {
                        conn2.Open();

                        SqlDataReader readerEsecuzioneEsercizio = commandEsecuzioneEsercizio.ExecuteReader();
                        while (readerEsecuzioneEsercizio.Read())
                        {

                            //discrimino se l'esercizio è a serie o a tempo
                            using (SqlConnection conn3 = new SqlConnection(Conn.ConnectionString))
                            {
                                conn3.Open();
                                SqlCommand commandEsecuzioneEsercizioATempo = new SqlCommand("select * from ESECUZIONIESERCIZIATEMPO where ID=" + readerEsecuzioneEsercizio["ID"] + ";", conn3);
                                SqlDataReader readerEsecuzioneEsercizioAtempo = commandEsecuzioneEsercizioATempo.ExecuteReader();
                                if (readerEsecuzioneEsercizioAtempo.HasRows)
                                {
                                    readerEsecuzioneEsercizioAtempo.Read();
                                    EsecuzioneEsercizioATempo esecATempo = new EsecuzioneEsercizioATempo(GetEsercizioByName((string)readerEsecuzioneEsercizio["nomeEsercizio"]), (int)readerEsecuzioneEsercizioAtempo["tempo"]);
                                    esecATempo.ID = (int)readerEsecuzioneEsercizioAtempo["ID"];
                                    giornoAllenamento.addEsecuzioneEsercizio(esecATempo);
                                    readerEsecuzioneEsercizioAtempo.Close();
                                }
                                else
                                {
                                    SqlCommand commandEsecuzioneEsercizioASerie = new SqlCommand("select * from ESECUZIONIESERCIZIASERIE where ID=" + readerEsecuzioneEsercizio["ID"] + ";", conn3);
                                    SqlDataReader readerEsecuzioneEsercizioASerie = commandEsecuzioneEsercizioASerie.ExecuteReader();
                                    readerEsecuzioneEsercizioASerie.Read();
                                    EsecuzioneEsercizioASerie esecASerie = new EsecuzioneEsercizioASerie(GetEsercizioByName((string)readerEsecuzioneEsercizio["NomeEsercizio"]), (int)readerEsecuzioneEsercizioASerie["tempoDiRecuperoTraSerie"],
                                    (int)readerEsecuzioneEsercizioASerie["numeroRipetizioni"], (int)readerEsecuzioneEsercizioASerie["numeroSerie"]);
                                    esecASerie.ID = (int)readerEsecuzioneEsercizioASerie["ID"];
                                    giornoAllenamento.addEsecuzioneEsercizio(esecASerie);
                                    readerEsecuzioneEsercizioASerie.Close();
                                }
                                conn3.Close();
                            }

                        }
                        readerEsecuzioneEsercizio.Close();
                        conn2.Close();
                    }
                    pianoAllenamento.inserisciGiornoAllenamento(giornoAllenamento);

                }
                readerGiorniAllenamenti.Close();
                return pianoAllenamento;
            }
            catch (SqlException e)
            {
                throw;
            }
            
        }


        public Utente LoadUtente()
        {
            try
            {
                Utente utente;
                SqlCommand myCommand = new SqlCommand("select * from UTENTI;", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                Sesso? sesso = getSesso((string)myReader["sesso"]);
                string nome = (string)myReader["nome"];
                string cognome = (string)myReader["cognome"];
                DateTime data = (DateTime)myReader["dataNascita"];
                int peso = (int)myReader["peso"];
                int altezza = (int)myReader["altezza"];
                int ID = (int)myReader["ID"];
                myReader.Close();

                //verifico se è un utente automatico
                SqlCommand myCommand2 = new SqlCommand("select * from UTENTIAUTOMATICI where ID=" + ID + ";", Conn);
                SqlDataReader myReader2 = myCommand2.ExecuteReader();
                if (myReader2.HasRows)
                {
                    myReader2.Read();
                    Risorsa? risorsa = getRisorsa((string)myReader2["risorsa"]);
                    TipoAllenamento? tipo = getTipoAllenamento((string)myReader2["tipoAllenamento"]);
                    utente = new UtenteAutomatico(nome,cognome , data, peso, altezza, sesso.Value, risorsa.Value, (int)myReader2["numeroGiorniAllenamento"], tipo.Value);
                    
                }
                else
                {
                    utente = new Utente(nome, cognome, data, peso, altezza, sesso.Value);
                }
                
                myReader2.Close();
                utente.ID = ID;
                return utente;
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
                int allenamentoID = generaAllenamentoID();

                //uso di SqlParameter per garantire sicurezza e evitare Sql Injection
                SqlParameter data = new SqlParameter("@Param1", SqlDbType.Date);
                data.Value = allenamento.Data;

                SqlParameter durata = new SqlParameter("@Param2", SqlDbType.Int);
                durata.Value = allenamento.DurataInMinuti;

                SqlParameter utenteID = new SqlParameter("@Param3", SqlDbType.Int);
                utenteID.Value = utente.ID;

                

                //fondamentale per salvare l'ID internamente
                allenamento.ID = allenamentoID;
                if (allenamento.PesoInKg != default(int))
                {
                    SqlParameter peso = new SqlParameter("@Param4", SqlDbType.Int);
                    peso.Value = allenamento.PesoInKg;
                    SqlCommand myCommand = new SqlCommand("INSERT INTO ALLENAMENTI Values (" + allenamentoID + ", @Param4, @Param1, @Param2, @Param3);", Conn);
                    myCommand.Parameters.Add(data);
                    myCommand.Parameters.Add(utenteID);
                    myCommand.Parameters.Add(durata);
                    myCommand.Parameters.Add(peso);

                    myCommand.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand myCommand = new SqlCommand("INSERT INTO ALLENAMENTI (ID, data, durata, Ese_ID) Values (" + allenamentoID + ", @Param1, @Param2, @Param3);", Conn);
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
                SqlParameter utenteID = new SqlParameter("@Param1", SqlDbType.Int);
                utenteID.Value = utente.ID;

                SqlCommand insertPianiAllenamenti = new SqlCommand("INSERT INTO PIANIALLENAMENTO Values (@Param1);", Conn);
                insertPianiAllenamenti.Parameters.Add(utenteID);

                insertPianiAllenamenti.ExecuteNonQuery();


                foreach (GiornoAllenamento giornoAllenamento in pianoAllenamento.GiorniAllenamento)
                {
                    int giornoAllenamentoID = generaGiornoAllenamentoID();

                    //fondamentale per salvare l'ID internamente
                    giornoAllenamento.ID = giornoAllenamentoID;

                    SqlParameter tempoRecuperoTraEsercizi = new SqlParameter("@Param4", SqlDbType.Int);
                    tempoRecuperoTraEsercizi.Value = giornoAllenamento.TempoDiRecuperoInSec;

                    SqlParameter utenteID2 = new SqlParameter("@UtenteID", SqlDbType.Int);
                    utenteID2.Value = utente.ID;


                    SqlCommand insertGiorniAllenamenti = new SqlCommand("INSERT INTO GIORNIALLENAMENTI Values (" + giornoAllenamentoID + ", @Param4, @UtenteID);", Conn);
                    insertGiorniAllenamenti.Parameters.Add(tempoRecuperoTraEsercizi);
                    insertGiorniAllenamenti.Parameters.Add(utenteID2);

                    insertGiorniAllenamenti.ExecuteNonQuery();

                    foreach (EsecuzioneEsercizio esecuzioneEsercizio in giornoAllenamento.ListaEsecuzioniEsercizi)
                    {
                        int esecuzioneEsercizioID = generaEsecuzioneEsercizioID();
                        esecuzioneEsercizio.ID = esecuzioneEsercizioID;

                        SqlParameter nomeEsercizio = new SqlParameter("@Param5", SqlDbType.VarChar);
                        nomeEsercizio.Value = esecuzioneEsercizio.Esercizio.Nome;
                        SqlCommand insertEsecuzioneEsercizio;
                        SqlCommand insertEsecuzioneEsercizioSpec;

                        if (esecuzioneEsercizio is EsecuzioneEsercizioASerie)
                        {
                            EsecuzioneEsercizioASerie myEsecuzioneEsercizioASerie = (EsecuzioneEsercizioASerie)esecuzioneEsercizio;
                            SqlParameter esecuzioneEsercizioASerie = new SqlParameter("@Param6", SqlDbType.Int);
                            esecuzioneEsercizioASerie.Value = 1;
                            insertEsecuzioneEsercizio = new SqlCommand("INSERT INTO ESECUZIONIESERCIZI(ID, nomeEsercizio, Ha_ID, ESECUZIONIESERCIZIASERIE Values (" + esecuzioneEsercizioID + ", @Param5, " + giornoAllenamentoID + ",  @Param6);", Conn);
                            insertEsecuzioneEsercizio.Parameters.Add(esecuzioneEsercizioASerie);

                            SqlParameter numeroSerie = new SqlParameter("@Param7", SqlDbType.Int);
                            numeroSerie.Value = myEsecuzioneEsercizioASerie.NumeroSerie;

                            SqlParameter numeroRipetizioni = new SqlParameter("@Param8", SqlDbType.Int);
                            numeroRipetizioni.Value = myEsecuzioneEsercizioASerie.NumeroRipetizioni;

                            SqlParameter tempoDiRecuperoTraSerie = new SqlParameter("@Param9", SqlDbType.Int);
                            tempoDiRecuperoTraSerie.Value = myEsecuzioneEsercizioASerie.TempoDiRecuperoInSec;

                            if (myEsecuzioneEsercizioASerie.Carico != default(int))
                            {
                                SqlParameter carico = new SqlParameter("@Param10", SqlDbType.Int);
                                carico.Value = myEsecuzioneEsercizioASerie.Carico;
                                insertEsecuzioneEsercizioSpec = new SqlCommand("INSERT INTO ESECUZIONIESERCIZIASERIE(ID, numeroSerie, numeroRipetizioni, tempoDiRecuperoTraSerie, carico) values (" + esecuzioneEsercizioID + ", @Param7, @Param8, @Param9, @Param10);");
                                insertEsecuzioneEsercizioSpec.Parameters.Add(carico);
                            }
                            else
                            {
                                insertEsecuzioneEsercizioSpec = new SqlCommand("INSERT INTO ESECUZIONIESERCIZIASERIE(ID, numeroSerie, numeroRipetizioni, tempoDiRecuperoTraSerie) values (" + esecuzioneEsercizioID + ", @Param7, @Param8, @Param9);");
                            }
                            insertEsecuzioneEsercizioSpec.Parameters.Add(numeroSerie);
                            insertEsecuzioneEsercizioSpec.Parameters.Add(numeroRipetizioni);
                            insertEsecuzioneEsercizioSpec.Parameters.Add(tempoDiRecuperoTraSerie);


                        }
                        else
                        {
                            EsecuzioneEsercizioATempo myEsecuzioneEsercizioATempo = (EsecuzioneEsercizioATempo)esecuzioneEsercizio;
                            SqlParameter esecuzioneEsercizioATempo = new SqlParameter("@Param6", SqlDbType.Int);
                            esecuzioneEsercizioATempo.Value = 1;
                            insertEsecuzioneEsercizio = new SqlCommand("INSERT INTO ESECUZIONIESERCIZI(ID, nomeEsercizio, Ha_ID, ESECUZIONIESERCIZIATEMPO) Values (" + esecuzioneEsercizioID + ", @Param5, " + giornoAllenamentoID + ",  @Param6);", Conn);
                            insertEsecuzioneEsercizio.Parameters.Add(esecuzioneEsercizioATempo);

                            SqlParameter tempo = new SqlParameter("@Param11", SqlDbType.Int);
                            tempo.Value = myEsecuzioneEsercizioATempo.Tempo;

                            insertEsecuzioneEsercizioSpec = new SqlCommand("INSERT INTO ESECUZIONIESERCIZIATEMPO values ( " + esecuzioneEsercizioID + ", @Param11);", Conn);
                            insertEsecuzioneEsercizioSpec.Parameters.Add(tempo);

                        }

                        insertEsecuzioneEsercizio.Parameters.Add(nomeEsercizio);

                        insertEsecuzioneEsercizio.ExecuteNonQuery();
                        insertEsecuzioneEsercizioSpec.ExecuteNonQuery();

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
                SqlParameter myParam = new SqlParameter("@Param1", SqlDbType.VarChar);
                myParam.Value = utente.Nome;

                SqlParameter myParam2 = new SqlParameter("@Param2", SqlDbType.VarChar);
                myParam2.Value = utente.Cognome;

                SqlParameter myParam3 = new SqlParameter("@Param3", SqlDbType.VarChar, 7);
                myParam3.Value = utente.Sesso;

                SqlParameter myParam4 = new SqlParameter("@Param4", SqlDbType.Date);
                myParam4.Value = utente.DataDiNascita;

                SqlParameter myParam5 = new SqlParameter("@Param5", SqlDbType.Int);
                myParam5.Value = utente.AltezzaInCm;

                SqlParameter myParam6 = new SqlParameter("@Param6", SqlDbType.Int);
                myParam6.Value = utente.PesoInKg;

                int ID = generaUtenteID();

                //fondamentale per salvare l'ID internamente
                utente.ID = ID;

                SqlCommand insertUtenteAutomatico;
                SqlCommand insertUtenti = new SqlCommand("INSERT INTO UTENTI  Values (" + ID + ", @Param1, @Param2, @Param3, @Param4, @Param5, @Param6);", Conn);
                insertUtenti.Parameters.Add(myParam);
                insertUtenti.Parameters.Add(myParam2);
                insertUtenti.Parameters.Add(myParam3);
                insertUtenti.Parameters.Add(myParam4);
                insertUtenti.Parameters.Add(myParam5);
                insertUtenti.Parameters.Add(myParam6);

                insertUtenti.ExecuteNonQuery();

                if (utente is UtenteAutomatico)
                {
                    UtenteAutomatico utenteAutomatico = (UtenteAutomatico)utente;

                    SqlParameter myParam7 = new SqlParameter("@Param7", SqlDbType.VarChar);
                    myParam7.Value = utenteAutomatico.Risorse;

                    SqlParameter myParam8 = new SqlParameter("@Param8", SqlDbType.Int);
                    myParam8.Value = utenteAutomatico.NumeroGiorniAllenamento;

                    SqlParameter myParam9 = new SqlParameter("@Param9", SqlDbType.VarChar);
                    myParam9.Value = utenteAutomatico.Tipo;

                    insertUtenteAutomatico = new SqlCommand("INSERT INTO UTENTIAUTOMATICI values (" + ID + ", @Param7, @Param8, @Param9);");
                    insertUtenteAutomatico.Parameters.Add(myParam7);
                    insertUtenteAutomatico.Parameters.Add(myParam8);
                    insertUtenteAutomatico.Parameters.Add(myParam9);
                    insertUtenteAutomatico.ExecuteNonQuery();
                }


                return true;
            }
            catch (SqlException e)
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
                SqlCommand myCommand = new SqlCommand("select utente from IDs;", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["utente"] + 1;
                myReader.Close();

                SqlCommand update = new SqlCommand("update IDs set utente = " + ID + ";", Conn);
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
                SqlCommand myCommand = new SqlCommand("select allenamento from IDs;", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["allenamento"] + 1;
                myReader.Close();

                SqlCommand update = new SqlCommand("update IDs set allenamento = " + ID + ";", Conn);
                update.ExecuteNonQuery();
                return ID;
            }
            catch (SqlException e)
            {
                throw;
            }

        }

        public int generaGiornoAllenamentoID()
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("select giornoAllenamento from IDs;", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["giornoAllenamento"] + 1;
                myReader.Close();

                SqlCommand update = new SqlCommand("update IDs set giornoAllenamento = " + ID + ";", Conn);
                update.ExecuteNonQuery();
                return ID;
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public int generaEsecuzioneEsercizioID()
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("select esecuzioneEsercizio from IDs;", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["esecuzioneEsercizio"] + 1;
                myReader.Close();

                SqlCommand update = new SqlCommand("update IDs set esecuzioneEsercizio = " + ID + ";", Conn);
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

                SqlCommand insert = new SqlCommand("insert into IDs values (0,0,0,0);", Conn);
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

                SqlCommand delete = new SqlCommand("delete from IDs;", Conn);
                delete.ExecuteNonQuery();

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

                SqlCommand select = new SqlCommand("select * from IDs;", Conn);
                SqlDataReader myReader = select.ExecuteReader();
                myReader.Read();
                if (myReader.HasRows)
                {
                    myReader.Close();
                    return true;
                }
                else
                {
                    myReader.Close();
                    setIDs();
                    return false;
                }

            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void Reset(Utente utente)
        {
            DeleteUtente(utente);
            resetIDs();

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
            switch (tipoString.ToLower())
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
            switch (sessoString.ToLower())
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
            switch (risorsaString.ToLower())
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
                if (esercizio.Nome.ToLower().Equals(nome.ToLower()))
                    return esercizio;
            }
            return null;
        }
    }
}
