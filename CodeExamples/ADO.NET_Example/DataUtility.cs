using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Example
{
    public class DataUtility
    {
        private string _connectionString;
     
        public DataUtility(string connectionString)
        {
            _connectionString = connectionString;
        }



        private SqlCommand _createCommand(string sql)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = sql;

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            return command;
        }

        public void ExecuteCommand(string sql)
        {
            using var command = _createCommand(sql);
            command.ExecuteNonQuery();
        }


        public void ExecuteQuery(string query)
        {
            using var command = _createCommand(query);

            /*
            ExecuteNonQuery used for executing queries that does not return any data.
            ExecuteNonQuery: Executes Insert, Update, and Delete statements (DML statements) and returns the number of rows affected.

            ExecuteReader: Executes the SQL query (Select statement) and returns a Reader object from SqlDataReader  which can perform a 
            forward only traversal across the set of records being fetched.
            

            different between ExecuteNonQuery and ExecuteReader :
                ExecuteReader is used for any result set with multiple rows/columns (e.g., SELECT col1, col2 from sometable ).
                ExecuteNonQuery is typically used for SQL statements without results (e.g., UPDATE, INSERT, DELETE etc.).
            */

            List<Dictionary<string, object>> values = new List<Dictionary<string, object>>();

            using SqlDataReader reader =  command.ExecuteReader();



            while (reader.Read())
            {   
                Dictionary<string, object> row = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    //Console.WriteLine($"{reader.GetName(i)} : {reader.GetValue(i)}");
                    row.Add(reader.GetName(i), reader.GetValue(i));
                }
                values.Add(row);

            }

            foreach (var value in values)
            {
                foreach (var item in value.Keys)
                {
                    Console.Write($" {item} : {value[item]} ");
                }
                Console.WriteLine();
            }
        }




    }
}