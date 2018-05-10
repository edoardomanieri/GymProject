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
                        giornoAllenamento.addInsiemeSerie(new InsiemeSerie((int)myReader3["tempoDiRecuperoTraSerie"], (int)myReader3["numeroRipetizioni"], (int)myReader3["numeroSerie"], GetEsercizioByName((string)myReader3["Nome"])));
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

                SqlCommand myCommand = new SqlCommand("INSERT INTO Utenti (Nome, Cognome, DataDiNascita, Sesso, AltezzaInCm, PesoInKg)" +
                    " Values (@Param1, @Param2, @Param3, @Param4, @Param5, @Param6)", Conn);
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
            throw new NotImplementedException();
        }

        public int generaAllenamentoID()
        {
            throw new NotImplementedException();
        }

        public int generaGiornoAllenamentoID()
        {
            throw new NotImplementedException();
        }

        public int generaInsiemeSerieID()
        {
            throw new NotImplementedException();
        }

        public void resetID()
        {
            throw new NotImplementedException();
        }
    }
}
