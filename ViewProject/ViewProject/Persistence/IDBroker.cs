using Palestra.Persistence;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Persistence
{
    public class IDBroker : IIDGenerator
    {
        private string _connectionString;

        public IDBroker(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int generaUtenteID()
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(_connectionString))
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
                using (SqlConnection Conn = new SqlConnection(_connectionString))
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
                using (SqlConnection Conn = new SqlConnection(_connectionString))
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
                using (SqlConnection Conn = new SqlConnection(_connectionString))
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
                using (SqlConnection Conn = new SqlConnection(_connectionString))
                {
                    SqlCommand insert = new SqlCommand("insert into IDs values (0,0,0,0);", Conn);
                    insert.ExecuteNonQuery();
                }

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
                using (SqlConnection Conn = new SqlConnection(_connectionString))
                {
                    SqlCommand delete = new SqlCommand("delete from IDs;", Conn);
                    delete.ExecuteNonQuery();
                }

            }
            catch (SqlException e)
            {
                throw;
            }
        }
    }
}
