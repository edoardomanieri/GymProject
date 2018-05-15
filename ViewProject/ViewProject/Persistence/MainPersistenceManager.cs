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

        //Da rendere singleton ed estrarre la classe IDBroker

        public MainPersistanceManager()
        {
            //connessione al database che rimarrà connesso per tutta la durata dell'applicazione
            Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=EDOARDO;Initial Catalog=PalestraDB;Integrated Security=True";
            Conn.Open();

            _esercizi = new List<Esercizio>();
            //esercizi petto
            _esercizi.Add(new Esercizio("panca piana", FasciaMuscolare.Pettorali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("panca inclinata", FasciaMuscolare.Pettorali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("distensioni con manubri", FasciaMuscolare.Pettorali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("chest press", FasciaMuscolare.Pettorali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("croci con manubri", FasciaMuscolare.Pettorali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("croci basse ai cavi", FasciaMuscolare.Pettorali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("croci alte ai cavi", FasciaMuscolare.Pettorali, Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("flessioni", FasciaMuscolare.Pettorali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("flessioni con gambe rialzate", FasciaMuscolare.Pettorali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("push up diamond", FasciaMuscolare.Pettorali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("push up plank", FasciaMuscolare.Pettorali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("mountain climber", FasciaMuscolare.Pettorali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("wiper push up", FasciaMuscolare.Pettorali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("dip alle parallele per pettorali", FasciaMuscolare.Pettorali,  Risorsa.CorpoLibero));
            //esercizi bicipiti
            _esercizi.Add(new Esercizio("curl con bilanciere", FasciaMuscolare.Bicipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("curl con manubri", FasciaMuscolare.Bicipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("curl a martello", FasciaMuscolare.Bicipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("curl di concentrazione con maubri", FasciaMuscolare.Bicipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("curl con corda", FasciaMuscolare.Bicipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("arm curl", FasciaMuscolare.Bicipiti,  Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("chin up", FasciaMuscolare.Bicipiti,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("headbangers", FasciaMuscolare.Bicipiti,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("bodyweight biceps curl", FasciaMuscolare.Bicipiti,  Risorsa.CorpoLibero));

            //esercizi tricipiti
            _esercizi.Add(new Esercizio("french press con bilanciere", FasciaMuscolare.Tricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("french press con manubri", FasciaMuscolare.Tricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("push down ai cavi", FasciaMuscolare.Tricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("estensioni con corda sopra la testa", FasciaMuscolare.Tricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("estensioni con manubrio sopra la testa", FasciaMuscolare.Tricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("panca presa stretta", FasciaMuscolare.Tricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("estensioni con manubrio busto flesso", FasciaMuscolare.Tricipiti,  Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("flessioni presa stretta", FasciaMuscolare.Tricipiti,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("dip tra due panche", FasciaMuscolare.Tricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("dip alle parallele per tricipiti", FasciaMuscolare.Tricipiti,  Risorsa.CorpoLibero));
            //esercizi quadricipiti
            _esercizi.Add(new Esercizio("squat al multipower", FasciaMuscolare.Quadricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("jefferson squat", FasciaMuscolare.Quadricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("sumo squat", FasciaMuscolare.Quadricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("pressa", FasciaMuscolare.Quadricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("leg extension", FasciaMuscolare.Quadricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("hack squat", FasciaMuscolare.Quadricipiti,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("front squat", FasciaMuscolare.Quadricipiti,  Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("squat", FasciaMuscolare.Quadricipiti,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("lateral squat", FasciaMuscolare.Quadricipiti,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("bulgarian split squat", FasciaMuscolare.Quadricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("box squat", FasciaMuscolare.Quadricipiti,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("single leg box squat", FasciaMuscolare.Quadricipiti,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("jump squat", FasciaMuscolare.Quadricipiti,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("step", FasciaMuscolare.Quadricipiti,  Risorsa.CorpoLibero));
            //esercizi adduttori
            _esercizi.Add(new Esercizio("leg curl", FasciaMuscolare.Adduttori,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("stacchi da terra con bilanciere", FasciaMuscolare.Adduttori, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("stacchi da terra con manubri", FasciaMuscolare.Adduttori,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("affondi frontali con zavorra", FasciaMuscolare.Adduttori, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("affondi laterali con zavorra", FasciaMuscolare.Adduttori,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("adductor machine", FasciaMuscolare.Adduttori,  Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("affondi laterali", FasciaMuscolare.Adduttori,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("affondi frontali", FasciaMuscolare.Adduttori,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("hamstring curl", FasciaMuscolare.Adduttori,  Risorsa.CorpoLibero));
            //esercizi polpacci
            _esercizi.Add(new Esercizio("calf machine in piedi", FasciaMuscolare.Polpacci,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("calf machine seduto", FasciaMuscolare.Polpacci,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("calf sdraiato alla leg press", FasciaMuscolare.Polpacci,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("calf al multipower", FasciaMuscolare.Polpacci,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("calf con manubri", FasciaMuscolare.Polpacci,  Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("seated calf raise", FasciaMuscolare.Polpacci,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("calf raise", FasciaMuscolare.Polpacci,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("donkey calf raise", FasciaMuscolare.Polpacci,  Risorsa.CorpoLibero));
            //esercizi dorsali
            _esercizi.Add(new Esercizio("rematore con bilanciere", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("rematore con manubri", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("rematore su panca con manubri", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("pulley basso", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("lateral pulley", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("lat machine", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("pullover sdraiato ai cavi", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("dorsy machine", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("nautilus machine", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("trazioni a presa larga", FasciaMuscolare.Dorsali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("trazioni a presa stretta", FasciaMuscolare.Dorsali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("trazioni a presa inversa", FasciaMuscolare.Dorsali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("inverted row", FasciaMuscolare.Dorsali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("scapola push up", FasciaMuscolare.Dorsali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("downward dog", FasciaMuscolare.Dorsali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("reverse snow", FasciaMuscolare.Dorsali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("superman", FasciaMuscolare.Dorsali,  Risorsa.CorpoLibero));
            //esercizi deltoidi
            _esercizi.Add(new Esercizio("military press", FasciaMuscolare.Deltoidi,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("alzate laterali", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("lento avanti con manubri", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("lento avanti con bilanciere", FasciaMuscolare.Dorsali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("shoulder press", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("crossover ai cavi", FasciaMuscolare.Deltoidi,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("military press", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("alzate frontali con manubri", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("alzate frontali con bilanciere", FasciaMuscolare.Deltoidi,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("alzate a 90 gradi", FasciaMuscolare.Deltoidi,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("arnold press", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("inclined push-ups", FasciaMuscolare.Deltoidi, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("plank to down dog", FasciaMuscolare.Deltoidi,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("pike push-ups", FasciaMuscolare.Deltoidi,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("rotating plank", FasciaMuscolare.Deltoidi, Risorsa.CorpoLibero));

            //esercizi addominali
            _esercizi.Add(new Esercizio("ab rollout con manubrio", FasciaMuscolare.Addominali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("decline crunch con peso", FasciaMuscolare.Addominali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("crunch machine", FasciaMuscolare.Addominali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("crunch avanti su panca", FasciaMuscolare.Addominali,  Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("weighted crunch", FasciaMuscolare.Addominali,  Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("ab rollout", FasciaMuscolare.Addominali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("crunch", FasciaMuscolare.Addominali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("crunch con gambe a 90 gradi", FasciaMuscolare.Addominali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("reverse crunch", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("sit up", FasciaMuscolare.Addominali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("hill climber", FasciaMuscolare.Addominali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("plank", FasciaMuscolare.Addominali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("spider plank", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("lateral plank", FasciaMuscolare.Addominali,  Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("leg raise", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));

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
                    pianoAllenamento.addGiornoAllenamento(giornoAllenamento);

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
                if (!(utente is UtenteAutomatico))
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

                    
                    SqlCommand insertUtenti = new SqlCommand("INSERT INTO UTENTI  Values (" + ID + ", @Param1, @Param2, @Param3, @Param4, @Param5, @Param6);", Conn);
                    insertUtenti.Parameters.Add(myParam);
                    insertUtenti.Parameters.Add(myParam2);
                    insertUtenti.Parameters.Add(myParam3);
                    insertUtenti.Parameters.Add(myParam4);
                    insertUtenti.Parameters.Add(myParam5);
                    insertUtenti.Parameters.Add(myParam6);

                    insertUtenti.ExecuteNonQuery();

                }
                if (utente is UtenteAutomatico)
                {
                    SqlCommand insertUtenteAutomatico;
                    UtenteAutomatico utenteAutomatico = (UtenteAutomatico)utente;

                    SqlParameter myParam7 = new SqlParameter("@Param7", SqlDbType.VarChar);
                    myParam7.Value = utenteAutomatico.Risorse;

                    SqlParameter myParam8 = new SqlParameter("@Param8", SqlDbType.Int);
                    myParam8.Value = utenteAutomatico.NumeroGiorniAllenamento;

                    SqlParameter myParam9 = new SqlParameter("@Param9", SqlDbType.VarChar);
                    myParam9.Value = utenteAutomatico.Tipo;

                    insertUtenteAutomatico = new SqlCommand("INSERT INTO UTENTIAUTOMATICI values (" + utente.ID + ", @Param7, @Param8, @Param9);");
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

        public  bool ThereIsASavedAccount()
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
