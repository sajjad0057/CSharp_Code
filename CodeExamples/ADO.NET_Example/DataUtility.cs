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

        public void AddData()
        {
            string connectionString = "Server = DESKTOP-SU7UN5F\\SQLEXPRESS ; Database=CSharpPractice1 ; User Id = CSharpPractice1 ;Password = 123456;";
            /*
             * uses of using statement : using statement can work with IDisposable implemented classes 
            The using statement defines a scope at the end of which an object will be disposed. 
            */
            using SqlConnection connection = new SqlConnection(connectionString);  // we can pass connectionString in SqlConnection constructor.

            // connection.ConnectionString = connectionString;

            var sql = "insert into Students([Name],Cgpa,DateOfBirth) values('zibon',3.48,'1982-07-11')";

            /*
            we can also - pass connection object in SqlConnection constructor.
            for this we need to pass with another parameter name CommandText like as sql statement ;
            example:
            SqlCommand command = new SqlCommand(sql,connection); 
             */

            using SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = sql;

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();


            /*
            ExecuteNonQuery used for executing queries that does not return any data.
            ExecuteNonQuery: Executes Insert, Update, and Delete statements (DML statements) and returns the number of rows affected.
            
            ExecuteReader: Executes the SQL query (Select statement) and returns a Reader object which can perform a forward only traversal
            across the set of records being fetched.
            different between ExecuteNonQuery and ExecuteReader :
                ExecuteReader is used for any result set with multiple rows/columns (e.g., SELECT col1, col2 from sometable ).
                ExecuteNonQuery is typically used for SQL statements without results (e.g., UPDATE, INSERT, DELETE etc.).
            */

            command.ExecuteNonQuery();

        }




    }
}