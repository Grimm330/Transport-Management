using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Management
{
    
        public class DataAccess
        {
            private readonly string _connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Bus Managment system\final project\Transport Management\Transport Management\TransportDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public int Execute(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        public int ExecuteNonQuery(string query, SqlParameter[] parameters)
{
    using (SqlConnection con = GetConnection())
    using (SqlCommand cmd = new SqlCommand(query, con))
    {
        if (parameters != null)
            cmd.Parameters.AddRange(parameters);
        con.Open();
        return cmd.ExecuteNonQuery();
    }
}


        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                con.Open();
                return cmd.ExecuteScalar();
            }
        }
        public DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            return ExecuteQuery(query, parameters);
        }

    }
}


