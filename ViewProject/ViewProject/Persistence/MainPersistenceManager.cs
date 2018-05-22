using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewProject.model;
using ViewProject.Persistence;

namespace ViewProject.Persistence
{
    public class MainPersistanceManager : IAllenamentoPersistenceManager, IEsercizioPersistanceManager, IPianoAllenamentoPersistenceManager, IUtentePersistenceManager
    {
        private List<Esercizio> _esercizi;
        private SqlConnection _conn;
        private IIDGenerator _IDBroker;
        private static MainPersistanceManager _instance;

        public static MainPersistanceManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainPersistanceManager();
                }
                return _instance;
            }
        }

        private MainPersistanceManager()
        {
            //connessione al database che rimarrà connesso per tutta la durata dell'applicazione
            Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=GIOVANNI-PC;Initial Catalog=PalestraDB;Integrated Security=True";
            _IDBroker = new IDBroker(Conn.ConnectionString);
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
            _esercizi.Add(new Esercizio("push up diamond", FasciaMuscolare.Pettorali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("push up plank", FasciaMuscolare.Pettorali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("mountain climber", FasciaMuscolare.Pettorali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("wiper push up", FasciaMuscolare.Pettorali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("dip alle parallele per pettorali", FasciaMuscolare.Pettorali, Risorsa.CorpoLibero));
            //esercizi bicipiti
            _esercizi.Add(new Esercizio("curl con bilanciere", FasciaMuscolare.Bicipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("curl con manubri", FasciaMuscolare.Bicipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("curl a martello", FasciaMuscolare.Bicipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("curl di concentrazione con maubri", FasciaMuscolare.Bicipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("curl con corda", FasciaMuscolare.Bicipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("arm curl", FasciaMuscolare.Bicipiti, Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("chin up", FasciaMuscolare.Bicipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("commando chin up", FasciaMuscolare.Bicipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("isometric chin up", FasciaMuscolare.Bicipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("headbangers", FasciaMuscolare.Bicipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("bodyweight biceps curl", FasciaMuscolare.Bicipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("doorway curl", FasciaMuscolare.Bicipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("towel biceps curl", FasciaMuscolare.Bicipiti, Risorsa.CorpoLibero));
            //esercizi tricipiti
            _esercizi.Add(new Esercizio("french press con bilanciere", FasciaMuscolare.Tricipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("french press con manubri", FasciaMuscolare.Tricipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("push down ai cavi", FasciaMuscolare.Tricipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("estensioni con corda sopra la testa", FasciaMuscolare.Tricipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("estensioni con manubrio sopra la testa", FasciaMuscolare.Tricipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("panca presa stretta", FasciaMuscolare.Tricipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("estensioni con manubrio busto flesso", FasciaMuscolare.Tricipiti, Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("forearm triceps extension", FasciaMuscolare.Tricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("power triceps extension", FasciaMuscolare.Tricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("flessioni presa stretta", FasciaMuscolare.Tricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("triceps bow", FasciaMuscolare.Tricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("narrow push up", FasciaMuscolare.Tricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("dip tra due panche", FasciaMuscolare.Tricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("dip alle parallele per tricipiti", FasciaMuscolare.Tricipiti, Risorsa.CorpoLibero));
            //esercizi quadricipiti
            _esercizi.Add(new Esercizio("squat al multipower", FasciaMuscolare.Quadricipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("jefferson squat", FasciaMuscolare.Quadricipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("pressa", FasciaMuscolare.Quadricipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("leg extension", FasciaMuscolare.Quadricipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("hack squat", FasciaMuscolare.Quadricipiti, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("front squat", FasciaMuscolare.Quadricipiti, Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("squat", FasciaMuscolare.Quadricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("lateral squat", FasciaMuscolare.Quadricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("bulgarian split squat", FasciaMuscolare.Quadricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("box squat", FasciaMuscolare.Quadricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("single leg box squat", FasciaMuscolare.Quadricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("jump squat", FasciaMuscolare.Quadricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("step", FasciaMuscolare.Quadricipiti, Risorsa.CorpoLibero));
            //esercizi adduttori
            _esercizi.Add(new Esercizio("leg curl", FasciaMuscolare.Adduttori, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("stacchi da terra con bilanciere", FasciaMuscolare.Adduttori, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("stacchi da terra con manubri", FasciaMuscolare.Adduttori, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("affondi frontali con zavorra", FasciaMuscolare.Adduttori, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("affondi laterali con zavorra", FasciaMuscolare.Adduttori, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("adductor machine", FasciaMuscolare.Adduttori, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("sumo squat con manubrio", FasciaMuscolare.Quadricipiti, Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("sumo squat", FasciaMuscolare.Quadricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("affondi laterali", FasciaMuscolare.Adduttori, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("affondi frontali", FasciaMuscolare.Adduttori, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("il pattinaggio", FasciaMuscolare.Quadricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("l'elastico", FasciaMuscolare.Quadricipiti, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("hamstring curl", FasciaMuscolare.Adduttori, Risorsa.CorpoLibero));
            //esercizi polpacci
            _esercizi.Add(new Esercizio("calf machine in piedi", FasciaMuscolare.Polpacci, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("calf machine seduto", FasciaMuscolare.Polpacci, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("calf sdraiato alla leg press", FasciaMuscolare.Polpacci, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("calf al multipower", FasciaMuscolare.Polpacci, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("calf con manubri", FasciaMuscolare.Polpacci, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("boxe jump con zavorra", FasciaMuscolare.Polpacci, Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("seated calf raise", FasciaMuscolare.Polpacci, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("calf raise", FasciaMuscolare.Polpacci, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("donkey calf raise", FasciaMuscolare.Polpacci, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("boxe jump", FasciaMuscolare.Polpacci, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("salto sulle punte", FasciaMuscolare.Polpacci, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("marcia sulle punte", FasciaMuscolare.Polpacci, Risorsa.CorpoLibero));
            //esercizi dorsali
            _esercizi.Add(new Esercizio("rematore con bilanciere", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("rematore con manubri", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("rematore su panca con manubri", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("pulley basso", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("lateral pulley", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("lat machine", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("pullover sdraiato ai cavi", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("dorsy machine", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("nautilus machine", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("trazioni a presa larga", FasciaMuscolare.Dorsali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("trazioni a presa stretta", FasciaMuscolare.Dorsali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("trazioni a presa inversa", FasciaMuscolare.Dorsali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("inverted row", FasciaMuscolare.Dorsali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("scapola push up", FasciaMuscolare.Dorsali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("downward dog", FasciaMuscolare.Dorsali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("reverse snow", FasciaMuscolare.Dorsali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("superman", FasciaMuscolare.Dorsali, Risorsa.CorpoLibero));
            //esercizi deltoidi
            _esercizi.Add(new Esercizio("military press", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("alzate laterali", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("lento avanti con manubri", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("lento avanti con bilanciere", FasciaMuscolare.Dorsali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("shoulder press", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("crossover ai cavi", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("military press", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("alzate frontali con manubri", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("alzate frontali con bilanciere", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("alzate a 90 gradi", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("arnold press", FasciaMuscolare.Deltoidi, Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("inclined push up", FasciaMuscolare.Deltoidi, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("plank to down dog", FasciaMuscolare.Deltoidi, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("pike push up", FasciaMuscolare.Deltoidi, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("elevated pike push up", FasciaMuscolare.Deltoidi, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("rotating plank", FasciaMuscolare.Deltoidi, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("handstand", FasciaMuscolare.Deltoidi, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("v push up", FasciaMuscolare.Deltoidi, Risorsa.CorpoLibero));
            //esercizi addominali
            _esercizi.Add(new Esercizio("ab rollout con manubrio", FasciaMuscolare.Addominali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("decline crunch con peso", FasciaMuscolare.Addominali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("crunch machine", FasciaMuscolare.Addominali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("crunch avanti su panca", FasciaMuscolare.Addominali, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("weighted crunch", FasciaMuscolare.Addominali, Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("ab rollout", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("crunch", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("crunch con gambe a 90 gradi", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("reverse crunch", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("sit up", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("hill climber", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("plank", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("spider plank", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("lateral plank", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("leg raise", FasciaMuscolare.Addominali, Risorsa.CorpoLibero));
            //esercizi cardio
            _esercizi.Add(new Esercizio("cyclette", FasciaMuscolare.Cardio, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("tapys roulant", FasciaMuscolare.Cardio, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("skillmill", FasciaMuscolare.Cardio, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("ellittica", FasciaMuscolare.Cardio, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("vogatore", FasciaMuscolare.Cardio, Risorsa.SalaPesi));
            _esercizi.Add(new Esercizio("kranking", FasciaMuscolare.Cardio, Risorsa.SalaPesi));

            _esercizi.Add(new Esercizio("skip alto", FasciaMuscolare.Cardio, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("skip basso", FasciaMuscolare.Cardio, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("jumping jacks", FasciaMuscolare.Cardio, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("salto con la corda", FasciaMuscolare.Cardio, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("step up", FasciaMuscolare.Cardio, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("corsa in pianura", FasciaMuscolare.Cardio, Risorsa.CorpoLibero));
            _esercizi.Add(new Esercizio("corsa in salita", FasciaMuscolare.Cardio, Risorsa.CorpoLibero));

        }



        public SqlConnection Conn { get => _conn; set => _conn = value ?? throw new ArgumentException();
    }

        /*
         * 
         * 
         * funzioni loading salvataggio e deleting
         * 
         */


        public bool DeleteAllenamenti(Utente utente)
        {
            if (utente == null)
                throw new ArgumentException();
            try
            {
                SqlCommand delete = new SqlCommand("delete from ALLENAMENTI where username = '" + utente.Username + "' ;", Conn);
                return delete.ExecuteNonQuery() > 0;
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }

        public bool DeletePianoAllenamento(Utente utente)
        {
            if (utente == null)
                throw new ArgumentException();
            //grazie ad on delete cascade mi si eliminano anche tutti le tuple referenziate
            try
            {
                SqlCommand delete = new SqlCommand("delete from PIANIALLENAMENTO where username= '" + utente.Username + "' ;", Conn);
                return delete.ExecuteNonQuery() > 0;
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }

        public bool DeleteUtente(Utente utente)
        {
            if (utente == null)
                throw new ArgumentException();
            try
            {
                SqlCommand delete = new SqlCommand("delete from UTENTI where username='" + utente.Username + "';", Conn);
                return delete.ExecuteNonQuery() > 0;
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Allenamento> LoadAllAllenamenti(Utente utente)
        {
            if (utente == null)
                throw new ArgumentException();
            List<Allenamento> allenamenti = new List<Allenamento>();
            try
            {
                SqlCommand selectAllenamenti = new SqlCommand("select * from ALLENAMENTI where username = '" + utente.Username + "' ;", Conn);
                SqlDataReader readerAllenamenti = selectAllenamenti.ExecuteReader();
                while (readerAllenamenti.Read())
                {
                    try
                    {
                        int peso = (int)readerAllenamenti["peso"];
                        allenamenti.Add(new Allenamento((int)readerAllenamenti["durata"], (DateTime)readerAllenamenti["data"], peso));
                    } catch(InvalidCastException)
                    {
                        allenamenti.Add(new Allenamento((int)readerAllenamenti["durata"], (DateTime)readerAllenamenti["data"]));
                    }
                }
                readerAllenamenti.Close();
                return allenamenti;
            }
            catch (SqlException)
            {
                throw;
            }
           
        }

        public IEnumerable<Esercizio> LoadAllEsercizi()
        {
            return _esercizi;
        }

        public bool CheckUsername(string username)
        {
            if (String.IsNullOrEmpty(username))
                throw new ArgumentException();
            try
            {
                SqlCommand select = new SqlCommand("delete from UTENTI where username='" + username + "';", Conn);
                SqlDataReader sqlDataReader = select.ExecuteReader();
                bool res = !sqlDataReader.HasRows;
                sqlDataReader.Close();
                return res;
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }

        public bool ThereIsAPianoAllenamento(Utente utente)
        {
            if (utente == null)
                throw new ArgumentException();
            try
            {
                bool res;
                SqlCommand commandSelect = new SqlCommand("select * from PIANIALLENAMENTO where username = '" + utente.Username +  "' ;", Conn);
                SqlDataReader readerPiani = commandSelect.ExecuteReader();
                readerPiani.Read();
                if (readerPiani.HasRows)
                    res = true;
                else
                    res = false;
                readerPiani.Close();
                return res;
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }

        public PianoAllenamento LoadPianoAllenamento(Utente utente)
        {
            if (utente == null)
                throw new ArgumentException();
            PianoAllenamento pianoAllenamento;
            try
            {
                pianoAllenamento = new PianoAllenamento();

                SqlCommand commandGiorniAllenamenti = new SqlCommand("select * from GIORNIALLENAMENTI where username='" + utente.Username + "';", Conn);
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
                                    readerEsecuzioneEsercizioAtempo.Close();
                                    SqlCommand commandEsecuzioneEsercizioASerie = new SqlCommand("select * from ESECUZIONIESERCIZIASERIE where ID=" + readerEsecuzioneEsercizio["ID"] + ";", conn3);
                                    SqlDataReader readerEsecuzioneEsercizioASerie = commandEsecuzioneEsercizioASerie.ExecuteReader();

                                    if (readerEsecuzioneEsercizioASerie.HasRows)
                                    {
                                        readerEsecuzioneEsercizioASerie.Read();
                                        EsecuzioneEsercizioASerie esecASerie = new EsecuzioneEsercizioASerie(GetEsercizioByName((string)readerEsecuzioneEsercizio["NomeEsercizio"]), (int)readerEsecuzioneEsercizioASerie["tempoDiRecuperoTraSerie"],
                                        (int)readerEsecuzioneEsercizioASerie["numeroRipetizioni"], (int)readerEsecuzioneEsercizioASerie["numeroSerie"]);
                                        esecASerie.ID = (int)readerEsecuzioneEsercizioASerie["ID"];
                                        giornoAllenamento.addEsecuzioneEsercizio(esecASerie);
                                    }
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
            catch (SqlException)
            {
                throw;
            }
            
        }


        public Utente Autentica(string username, string password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                throw new ArgumentException();
            try
            {
                Utente utente;
                SqlParameter utentePassword = new SqlParameter("@password", SqlDbType.VarChar, 50);
                utentePassword.Value = password;
                SqlParameter utenteUsername = new SqlParameter("@username", SqlDbType.VarChar, 50);
                utenteUsername.Value = username;
                SqlCommand myCommand = new SqlCommand("select * from UTENTI where username =  @username AND password = @password;" , Conn);
                myCommand.Parameters.Add(utenteUsername);
                myCommand.Parameters.Add(utentePassword);
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (!myReader.HasRows)
                {
                    myReader.Close();
                    utente = null;
                    return utente;

                }
                myReader.Read();
                Sesso? sesso = getSesso((string)myReader["sesso"]);
                string nome = (string)myReader["nome"];
                string cognome = (string)myReader["cognome"];
                DateTime data = (DateTime)myReader["dataNascita"];
                int peso = (int)myReader["peso"];
                int altezza = (int)myReader["altezza"];
                myReader.Close();

                //verifico se è un utente automatico
                SqlParameter utenteUsername2 = new SqlParameter("@username2", SqlDbType.VarChar, 50);
                utenteUsername2.Value = username;
                SqlCommand myCommand2 = new SqlCommand("select * from UTENTIAUTOMATICI where username = @username2;", Conn);
                myCommand2.Parameters.Add(utenteUsername2);
                SqlDataReader myReader2 = myCommand2.ExecuteReader();
                if (myReader2.HasRows)
                {
                    myReader2.Read();
                    Risorsa? risorsa = getRisorsa((string)myReader2["risorseDisponibili"]);
                    TipoAllenamento? tipo = getTipoAllenamento((string)myReader2["tipoAllenamento"]);
                    utente = new UtenteAutomatico(username, nome,cognome , data, peso, altezza, sesso.Value, risorsa.Value, (int)myReader2["numeroGiorniAllenamento"], tipo.Value);
                    
                }
                else
                {
                    utente = new Utente(username, nome, cognome, data, peso, altezza, sesso.Value);
                }
                
                myReader2.Close();
                return utente;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public bool SaveAllenamento(Utente utente, Allenamento allenamento)
        {
            if (utente == null || allenamento == null)
                throw new ArgumentException();
            try
            {
                int allenamentoID = _IDBroker.generaAllenamentoID();

                //uso di SqlParameter per garantire sicurezza e evitare Sql Injection
                SqlParameter data = new SqlParameter("@Param1", SqlDbType.Date);
                data.Value = allenamento.Data;

                SqlParameter durata = new SqlParameter("@Param2", SqlDbType.Int);
                durata.Value = allenamento.DurataInMinuti;

                SqlParameter utenteUsername = new SqlParameter("@Param3", SqlDbType.VarChar,50);
                utenteUsername.Value = utente.Username;

                

                //fondamentale per salvare l'ID internamente
                allenamento.ID = allenamentoID;
                if (allenamento.PesoInKg != default(int))
                {
                    SqlParameter peso = new SqlParameter("@Param4", SqlDbType.Int);
                    peso.Value = allenamento.PesoInKg;
                    SqlCommand myCommand = new SqlCommand("INSERT INTO ALLENAMENTI Values (" + allenamentoID + ", @Param4, @Param1, @Param2, @Param3);", Conn);
                    myCommand.Parameters.Add(data);
                    myCommand.Parameters.Add(utenteUsername);
                    myCommand.Parameters.Add(durata);
                    myCommand.Parameters.Add(peso);

                    myCommand.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand myCommand = new SqlCommand("INSERT INTO ALLENAMENTI (ID, data, durata, username) Values (" + allenamentoID + ", @Param1, @Param2, @Param3);", Conn);
                    myCommand.Parameters.Add(data);
                    myCommand.Parameters.Add(utenteUsername);
                    myCommand.Parameters.Add(durata);

                    myCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public bool SavePianoAllenamento(Utente utente, PianoAllenamento pianoAllenamento)
        {
            if (utente == null || pianoAllenamento == null)
                throw new ArgumentException();
            if (ThereIsAPianoAllenamento(utente))
            {
                DeletePianoAllenamento(utente);
            }
            try
            {
                //uso di SqlParameter per garantire sicurezza e evitare Sql Injection
                SqlParameter utenteUsername = new SqlParameter("@Param1", SqlDbType.VarChar, 50);
                utenteUsername.Value = utente.Username;

                SqlCommand insertPianiAllenamenti = new SqlCommand("INSERT INTO PIANIALLENAMENTO Values (@Param1);", Conn);
                insertPianiAllenamenti.Parameters.Add(utenteUsername);

                insertPianiAllenamenti.ExecuteNonQuery();


                foreach (GiornoAllenamento giornoAllenamento in pianoAllenamento.GiorniAllenamento)
                {
                    int giornoAllenamentoID = _IDBroker.generaGiornoAllenamentoID();

                    //fondamentale per salvare l'ID internamente
                    giornoAllenamento.ID = giornoAllenamentoID;

                    SqlParameter tempoRecuperoTraEsercizi = new SqlParameter("@Param4", SqlDbType.Int);
                    tempoRecuperoTraEsercizi.Value = giornoAllenamento.TempoDiRecuperoInSec;

                    SqlParameter utenteUsername2 = new SqlParameter("@UtenteUsername", SqlDbType.VarChar, 50);
                    utenteUsername2.Value = utente.Username;


                    SqlCommand insertGiorniAllenamenti = new SqlCommand("INSERT INTO GIORNIALLENAMENTI Values (" + giornoAllenamentoID + ", @Param4, @UtenteUsername);", Conn);
                    insertGiorniAllenamenti.Parameters.Add(tempoRecuperoTraEsercizi);
                    insertGiorniAllenamenti.Parameters.Add(utenteUsername2);

                    insertGiorniAllenamenti.ExecuteNonQuery();

                    foreach (EsecuzioneEsercizio esecuzioneEsercizio in giornoAllenamento.ListaEsecuzioniEsercizi)
                    {
                        int esecuzioneEsercizioID = _IDBroker.generaEsecuzioneEsercizioID();
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
                            insertEsecuzioneEsercizio = new SqlCommand("INSERT INTO ESECUZIONIESERCIZI(ID, nomeEsercizio, Ha_ID, ESECUZIONIESERCIZIASERIE) Values (" + esecuzioneEsercizioID + ", @Param5, " + giornoAllenamentoID + ",  @Param6);", Conn);
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
                                insertEsecuzioneEsercizioSpec = new SqlCommand("INSERT INTO ESECUZIONIESERCIZIASERIE(ID, numeroSerie, numeroRipetizioni, tempoDiRecuperoTraSerie, carico) values (" + esecuzioneEsercizioID + ", @Param7, @Param8, @Param9, @Param10);", Conn);
                                insertEsecuzioneEsercizioSpec.Parameters.Add(carico);
                            }
                            else
                            {
                                insertEsecuzioneEsercizioSpec = new SqlCommand("INSERT INTO ESECUZIONIESERCIZIASERIE(ID, numeroSerie, numeroRipetizioni, tempoDiRecuperoTraSerie) values (" + esecuzioneEsercizioID + ", @Param7, @Param8, @Param9);", Conn);
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
                            insertEsecuzioneEsercizio = new SqlCommand("INSERT INTO ESECUZIONIESERCIZI(ID, nomeEsercizio, Ha_ID, ESECUZIONIESERCIZIATEMPO) values (" + esecuzioneEsercizioID + ", @Param5, " + giornoAllenamentoID + ",  @Param6);", Conn);
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
            catch (SqlException)
            {
                throw;
            }
        }
        public bool updateUtente(Utente utente)
        {
            if (utente == null)
                throw new ArgumentException();
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

                SqlCommand insertUtenti;

                if (utente.FotoPath != default(string))
                {
                    SqlParameter myParam8 = new SqlParameter("@Param8", SqlDbType.VarChar, 200);
                    myParam8.Value = utente.FotoPath;
                    insertUtenti = new SqlCommand("UPDATE UTENTI SET   nome = @Param1, cognome = @Param2, sesso = @Param3, dataNascita = @Param4, altezza = @Param5, peso = @Param6, fotopath = @Param8 where username ='" + utente.Username + "' ;", Conn);
                    insertUtenti.Parameters.Add(myParam8);
                }

                else
                {
                    insertUtenti = new SqlCommand("UPDATE UTENTI SET   nome = @Param1, cognome = @Param2, sesso = @Param3, dataNascita = @Param4, altezza = @Param5, peso = @Param6 where username ='" + utente.Username + "' ;", Conn);

                }

                insertUtenti.Parameters.Add(myParam);
                insertUtenti.Parameters.Add(myParam2);
                insertUtenti.Parameters.Add(myParam3);
                insertUtenti.Parameters.Add(myParam4);
                insertUtenti.Parameters.Add(myParam5);
                insertUtenti.Parameters.Add(myParam6);


                insertUtenti.ExecuteNonQuery();

                return true;

            }
            catch (SqlException)
            {
                throw;
            }
        }
    

        public bool SaveUtente(Utente utente, string password)
        {
            if (utente == null || String.IsNullOrEmpty(password))
                throw new ArgumentException();
            try
            {
                //uso di SqlParameter per garantire sicurezza e evitare Sql Injection
                    SqlParameter myParam7 = new SqlParameter("@Param7", SqlDbType.VarChar, 50);
                    myParam7.Value = utente.Username;

                    SqlParameter myParam8 = new SqlParameter("@Param8", SqlDbType.VarChar, 50);
                    myParam8.Value = password;

                    SqlParameter myParam = new SqlParameter("@Param1", SqlDbType.VarChar,50);
                    myParam.Value = utente.Nome;

                    SqlParameter myParam2 = new SqlParameter("@Param2", SqlDbType.VarChar,50 );
                    myParam2.Value = utente.Cognome;

                    SqlParameter myParam3 = new SqlParameter("@Param3", SqlDbType.VarChar, 7);
                    myParam3.Value = utente.Sesso;

                    SqlParameter myParam4 = new SqlParameter("@Param4", SqlDbType.Date);
                    myParam4.Value = utente.DataDiNascita;

                    SqlParameter myParam5 = new SqlParameter("@Param5", SqlDbType.Int);
                    myParam5.Value = utente.AltezzaInCm;

                    SqlParameter myParam6 = new SqlParameter("@Param6", SqlDbType.Int);
                    myParam6.Value = utente.PesoInKg;

            
                    SqlCommand insertUtenti = new SqlCommand("INSERT INTO UTENTI (username, password,nome, cognome, sesso, dataNascita, peso, altezza)  Values (@Param7, @Param8, @Param1, @Param2, @Param3, @Param4, @Param5, @Param6);", Conn);
                    insertUtenti.Parameters.Add(myParam8);
                    insertUtenti.Parameters.Add(myParam7);
                    insertUtenti.Parameters.Add(myParam);
                    insertUtenti.Parameters.Add(myParam2);
                    insertUtenti.Parameters.Add(myParam3);
                    insertUtenti.Parameters.Add(myParam4);
                    insertUtenti.Parameters.Add(myParam5);
                    insertUtenti.Parameters.Add(myParam6);

                    insertUtenti.ExecuteNonQuery();

                return true;
                
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }


        public bool SaveUtenteAutomatico(Utente utente, Risorsa risorsa, int numeroGiorniAllenamento, TipoAllenamento tipo)
        {
            if (utente == null || numeroGiorniAllenamento<=0 || numeroGiorniAllenamento>7)
                throw new ArgumentException();
            try
            {
                    SqlCommand insertUtenteAutomatico;

                    SqlParameter myParam7 = new SqlParameter("@Param7", SqlDbType.VarChar);
                    myParam7.Value = risorsa.ToString();

                    SqlParameter myParam8 = new SqlParameter("@Param8", SqlDbType.VarChar);
                    myParam8.Value = tipo.ToString();

                    SqlParameter myParam9 = new SqlParameter("@Param9", SqlDbType.Int);
                    myParam9.Value = numeroGiorniAllenamento;



                    insertUtenteAutomatico = new SqlCommand("INSERT INTO UTENTIAUTOMATICI values ('" + utente.Username + "', @Param7, @Param8, @Param9);", Conn);
                    insertUtenteAutomatico.Parameters.Add(myParam7);
                    insertUtenteAutomatico.Parameters.Add(myParam8);
                    insertUtenteAutomatico.Parameters.Add(myParam9);
                    insertUtenteAutomatico.ExecuteNonQuery();


                return true;
            }
            catch (SqlException)
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



        public  bool ThereIsASavedAccount()
        {
            try
            {

                SqlCommand select = new SqlCommand("select * from UTENTI;", Conn);
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
                    return false;
                }

            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }

        public void Reset(Utente utente)
        {
            DeleteUtente(utente);

        }

        /*
         * 
         * 
         * FUNZIONI ACCESSORIE
         * 
         */

        public static TipoAllenamento? getTipoAllenamento(string tipoString)
        {
            if (String.IsNullOrEmpty(tipoString))
                throw new ArgumentException();
            TipoAllenamento? tipo = null;
            switch (tipoString.ToLower())
            {
                case "ipertrofia":
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


        public static Sesso? getSesso(string sessoString)
        {
            if (String.IsNullOrEmpty(sessoString))
                throw new ArgumentException();
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

        public static Risorsa? getRisorsa(string risorsaString)
        {
            if (String.IsNullOrEmpty(risorsaString))
                throw new ArgumentException();
            Risorsa? risorsa = null;
            switch (risorsaString.ToLower())
            {
                case "corpo libero":
                    risorsa = Risorsa.CorpoLibero;
                    break;
                case "corpolibero":
                    risorsa = Risorsa.CorpoLibero;
                    break;
                case "sala pesi":
                    risorsa = Risorsa.SalaPesi;
                    break;
                case "salapesi":
                    risorsa = Risorsa.SalaPesi;
                    break;
            }
            return risorsa;
        }

        public Esercizio GetEsercizioByName(string nome)
        {
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentException();
            foreach (Esercizio esercizio in _esercizi)
            {
                if (esercizio.Nome.ToLower().Equals(nome.ToLower()))
                    return esercizio;
            }
            return null;
        }

        public static FasciaMuscolare? getFasciaMuscolare(string fasciaMuscolareString)
        {
            if (String.IsNullOrEmpty(fasciaMuscolareString))
                throw new ArgumentException();
            FasciaMuscolare? fasciaMuscolare = null;
            switch (fasciaMuscolareString.ToLower())
            {
                case "bicipiti":
                    fasciaMuscolare = FasciaMuscolare.Bicipiti;
                    break;
                case "adduttori":
                    fasciaMuscolare = FasciaMuscolare.Adduttori;
                    break;
                case "addominali":
                    fasciaMuscolare = FasciaMuscolare.Addominali;
                    break;
                case "cardio":
                    fasciaMuscolare = FasciaMuscolare.Cardio;
                    break;
                case "deltoidi":
                    fasciaMuscolare = FasciaMuscolare.Deltoidi;
                    break;
                case "dorsali":
                    fasciaMuscolare = FasciaMuscolare.Dorsali;
                    break;
                case "pettorali":
                    fasciaMuscolare = FasciaMuscolare.Pettorali;
                    break;
                case "polpacci":
                    fasciaMuscolare = FasciaMuscolare.Polpacci;
                    break;
                case "quadricipiti":
                    fasciaMuscolare = FasciaMuscolare.Quadricipiti;
                    break;
                case "tricipiti":
                    fasciaMuscolare = FasciaMuscolare.Tricipiti;
                    break;

            }
            return fasciaMuscolare;
        }
    }
}
