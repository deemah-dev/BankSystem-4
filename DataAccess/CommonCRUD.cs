using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    internal static class CommonCRUD
    {
        public static DataTable GetAll(string query)
        {
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static bool Execute(SqlConnection connection, SqlCommand command, string query)
        {
            int rowAffected = 0;
            bool success = false;
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
                success = (rowAffected > 0);
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return success;
        }
    }
}