using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    internal class ConnectionManager
    {
        private SqlCommand cmd;
        private SqlConnection conn;
        private string connString = @"Data Source=.;Initial Catalog=The_Bests;Integrated Security=true";
        public void Open()
        {
            conn = new SqlConnection(connString);
            conn.Open();
        }
        public void Close()
        {
            conn.Close();
        }
        public DataTable MultiSelect(string query)
        {

            DataTable dataTable = new DataTable();

            using (cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = query;

                using (SqlDataReader Reader = cmd.ExecuteReader())
                {
                    dataTable.Load(Reader);
                }
            }
            return dataTable;
        }
        public void Query(string query)
        {

            using (cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
        }
        public string GetName(string query)
        {
            string result = "null";

            using (cmd = new SqlCommand())
            {
                
                cmd.Connection = conn;
                cmd.CommandText = query;
                using (SqlDataReader Reader = cmd.ExecuteReader())
                {
                    int columnIndex = Reader.GetOrdinal("Name");

                    while (Reader.Read())
                    {
                        result = Reader.GetString(columnIndex);
                    }
                }

            }
            return result;
        }

    }
}
