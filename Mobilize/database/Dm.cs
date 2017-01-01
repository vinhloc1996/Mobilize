using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Mobilize.database
{
    public class Dm
    {
        public SqlConnection Connection;


        public void ConnectDb()
        {
            string connectionString =
                "Data Source=.;Initial Catalog=Mobilize;Persist Security Info=True;User ID=sa;Pass" +
                "word=123456";
            try
            {
                Connection = new SqlConnection(connectionString);
                Connection.Open();
            }
            catch (SqlException sql)
            {
                MessageBox.Show(@"Error at open connection to database " + sql.Message);
                Connection.Close();
                Environment.Exit(0);
            }
        }

        public SqlDataReader SelectData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader;
            }
            return null;
        }

        public int InsertData(string table, string[] parameters, object[] values)
        {
            int row = 0;
            try
            {
                string query = "INSERT INTO " + table + " VALUES(";
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (i == parameters.Length - 1)
                    {
                        query += "@" + parameters[i] + ")";
                    }
                    else
                    {
                        query += "@" + parameters[i] + ", ";
                    }
                }
                SqlCommand cmd = new SqlCommand(query, Connection);
                for (int j = 0; j < parameters.Length; j++)
                {
                    cmd.Parameters.AddWithValue("@" + parameters[j], values[j]);
                }
                row = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error at insert function in Dm " + ex.Message);
                Connection.Close();
            }
            return row;
        }

        public int UpdateData(string table, string[] parameters, object[] values)
        {
            int row = 0;
            try
            {
                string query = "UPDATE " + table + " SET ";
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (i == parameters.Length - 1)
                    {
                        query += parameters[i] + "=@" + parameters[i];
                    }
                    else if (i == parameters.Length - 2)
                    {
                        query += parameters[i] + "=@" + parameters[i] + " WHERE ";
                    }
                    else
                    {
                        query += parameters[i] + "=@" + parameters[i] + ", ";
                    }
                }
                SqlCommand cmd = new SqlCommand(query, Connection);
                for (int j = 0; j < parameters.Length; j++)
                {
                    cmd.Parameters.AddWithValue("@" + parameters[j], values[j]);
                }

                row = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error at update function in Dm " + ex.Message);
                Connection.Close();
            }
            return row;
        }

        public int DeleteData(string table, string[] parameters, object[] values)
        {
            int row = 0;
            try
            {
                string query = "DELETE FROM " + table + "WHERE ";
                query = parameters.Aggregate(query, (current, t) => current + (t + "=@" + t));
                SqlCommand cmd = new SqlCommand(query, Connection);
                for (int j = 0; j < parameters.Length; j++)
                {
                    cmd.Parameters.AddWithValue("@" + parameters[j], values[j]);
                }
                row = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error at delete function in Dm " + ex.Message);
                Connection.Close();
            }
            return row;
        }
    }
}