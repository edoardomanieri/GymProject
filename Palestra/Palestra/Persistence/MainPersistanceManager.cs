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
            _esercizi.Add(new Esercizio("Panca piana", FasciaMuscolare.Pettorali, "", Risorsa.SalaPesi ));
            //mettere tutti gli esercizi nella lista
        }

        private Esercizio GetEsercizioByName(string nome)
        {
            foreach(Esercizio esercizio in _esercizi)
            {
                if (esercizio.Nome.Equals(nome))
                    return esercizio;
            }
            return null;
        }

        public SqlConnection Conn { get => _conn; set => _conn = value; }


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

        public bool DeletePianoAllenamento(PianoAllenamento pianoAllenamento)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUtente(Utente utente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Allenamento> GetAllAllenamenti()
        {
            List<Allenamento> allenamenti = new List<Allenamento>();
            try
            { 
                SqlCommand myCommand = new SqlCommand("select * from ALLENAMENTI",   Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    allenamenti.Add(new Allenamento((int)myReader["DurataInMinuti"], (DateTime)myReader["Data"]));
                }
            }
            catch (SqlException e)
            {
                //eccezione da gestire
                throw;
            }
            return allenamenti;
        }

        public IEnumerable<Esercizio> GetAllEsercizi()
        {
            return _esercizi;
        }

        public PianoAllenamento GetPianoAllenamento()
        {
            PianoAllenamento pianoAllenamento;
            try
            {
                SqlCommand myCommand = new SqlCommand("select * from PIANIALLENAMENTO", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                string tipoString = (string) myReader["TipoAllenamento"];
                TipoAllenamento tipo;
                switch (tipoString)
                {
                    case "Ipertofia":
                        tipo = TipoAllenamento.Ipertrofia;
                        break;
                    case "Definizione":
                        tipo = TipoAllenamento.Definizione;
                        break;
                    case "Tonificazione":
                        tipo = TipoAllenamento.Tonificazione;
                        break;
                    case "Forza":
                        tipo = TipoAllenamento.Forza;
                        break;
                    default:
                        throw new Exception();
                }
                pianoAllenamento = new PianoAllenamento(tipo);

                SqlCommand myCommand2 = new SqlCommand("select * from GIORNIALLENAMENTI", Conn);
                SqlDataReader myReader2 = myCommand.ExecuteReader();
                GiornoAllenamento giornoAllenamento;
                while (myReader2.Read())
                {
                    giornoAllenamento = new GiornoAllenamento((int)myReader2["TempoRecuperoTraEsercizi"]);
                    SqlCommand myCommand3 = new SqlCommand("select * from insiemeSerie where I_G_ID=" + myReader2["ID"], Conn);
                    SqlDataReader myReader3 = myCommand.ExecuteReader();
                    while (myReader3.Read())
                    {
                        giornoAllenamento.addInsiemeSerie(new InsiemeSerie((int)myReader3["tempoDiRecuperoTraSerie"], (int)myReader3["numeroRipetizioni"], (int)myReader3["numeroSerie"], GetEsercizioByName((string)myReader3["NomeEsercizio"])));
                    }
                    pianoAllenamento.inserisciGiornoAllenamento(giornoAllenamento);

                }
            }
            catch (SqlException e)
            {
                //eccezione da gestire
                throw;
            }
            return pianoAllenamento;
        }

        public Utente GetUtente()
        {
            throw new NotImplementedException();
        }

        public bool SaveAllenamento(Allenamento allenamento)
        {
            throw new NotImplementedException();
        }

        public bool SavePianoAllenamento(PianoAllenamento pianoAllenamento)
        {
            throw new NotImplementedException();
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
                //eccezione da gestire
                throw;
            }
        }

        //da invocare sempre alla chiusura dell'applicazione
        public void CloseConnection()
        {
            _conn.Close();
        }

        public int generaUtenteID()
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("select Utente from IDs", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["Utente"] + 1;

                SqlCommand update = new SqlCommand("update IDs set Utente = " + ID, Conn);
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
                SqlCommand myCommand = new SqlCommand("select Allenamento from IDs", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["Allenamento"] + 1;

                SqlCommand update = new SqlCommand("update IDs set Allenamento = " + ID, Conn);
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
                SqlCommand myCommand = new SqlCommand("select GiornoAllenamento from IDs", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["GiornoAllenamento"] + 1;

                SqlCommand update = new SqlCommand("update IDs set GiornoAllenamento = " + ID, Conn);
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
                SqlCommand myCommand = new SqlCommand("select InsiemeSerie from IDs", Conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int ID = (int)myReader["InsiemeSerie"] + 1;

                SqlCommand update = new SqlCommand("update IDs set InsiemeSerie = " + ID, Conn);
                update.ExecuteNonQuery();
                return ID;
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void resetID()
        {
            try
            {

                SqlCommand update = new SqlCommand("update IDs set Allenamento = 0, InsiemeSerie = 0, GiornoAllenamento = 0, Utente = 0", Conn);
                update.ExecuteNonQuery();
                
            }
            catch (SqlException e)
            {
                throw;
            }
        }


        public void reset()
        {
            resetID();
        }
    }
}
