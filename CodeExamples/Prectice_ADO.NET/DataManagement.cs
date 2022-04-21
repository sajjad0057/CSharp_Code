using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ADO.NET
{
    public class DataManagement
    {
        private string _connectionString;

        public DataManagement(string connectionString)
        {
            _connectionString = connectionString;
        }


        private SqlCommand _manageCommand(string sql)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand(sql, connection);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            return cmd;
        }


        public void ExecuteCommand(string sql)
        {
            using SqlCommand cmd = _manageCommand(sql);
            cmd.ExecuteNonQuery();
        }


        public List<Dictionary<string, object>> ExecuteQuery(string query)
        {
            using SqlCommand cmd = _manageCommand(query);

            List<Dictionary<string, object>> values = new List<Dictionary<string, object>>();

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Dictionary<string, object> value = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    value.Add(reader.GetName(i), reader.GetValue(i));
                }
                values.Add(value);
            }
            return values;
        }
    }
}