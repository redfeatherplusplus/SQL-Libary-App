using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Library_DAOs
{
    public delegate void ReaderCallback(MySqlDataReader reader);

    public abstract class LibraryDAO
    {
        private string connectionString;

        public LibraryDAO() 
        {
            connectionString =
                "server=localhost;" +
                "uid=root;" +
                "pwd=1234;" +
                "pooling=false;" +
                "database=Library;";
        }

        protected void ExecuteNonQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        protected void ExecuteReader(string query, ReaderCallback readerCallback)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();
                    readerCallback(reader);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
