using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Repositries.Repostry
{
    public class ConnectionManager
    {
        public SqlConnection conn;

        public ConnectionManager()
        {
            conn = new SqlConnection();
            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings
                ["testDB"].ToString();
        }

        public bool Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    return false;
                }
            }
            return false;
        }

        public bool Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    conn.Close();
                    return true;
                }
                catch (SqlException ex)
                {
                    return false;
                }
            }
            return false;
        }
    }
}