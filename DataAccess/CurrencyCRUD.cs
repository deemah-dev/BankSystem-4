using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SystemModules;

namespace DataAccess
{
    public static class CurrencyCRUD
    {
        public static DataTable GetAll()
        {
            string query = "SELECT Currencies.ID, Countries.CountryName, Countries.CountryCode AS Code, Currencies.Name, Currencies.Rate FROM   Currencies INNER JOIN Countries ON Currencies.CountryID = Countries.CountryID";

            DataTable dataTable = new DataTable();

            dataTable = CommonCRUD.GetAll(query);

            return dataTable;
        }

        public static bool AddNew(Currency currency)
        {
            string query = "INSERT INTO Currencies ([CountryID], [Name], [Rate]) VALUES (@CountryID, @Name, @Rate)";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", currency.CountryID);
            command.Parameters.AddWithValue("@Name", currency.Name);
            command.Parameters.AddWithValue("@Rate", currency.Rate);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool UpdateRate(int ID, decimal newRate)
        {
            string query = "UPDATE Currencies SET [Rate] = @Rate WHERE [ID] = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Rate", newRate);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Delete(int ID)
        {
            string query = "DELETE FROM Currencies WHERE ID = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static List<string> CodesList()
        {
            string query = "SELECT Countries.CountryCode FROM   Countries INNER JOIN Currencies ON Countries.CountryID = Currencies.CountryID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            List<string> Codes = new List<string>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Codes.Add(Convert.ToString(reader["CountryCode"]));
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
            return Codes;
        }

        public static Currency Find(string currencyCode)
        {
            string query = "SELECT Currencies.* FROM   Countries INNER JOIN Currencies ON Countries.CountryID = Currencies.CountryID WHERE Countries.CountryCode = @CountryCode";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryCode", currencyCode);
            Currency currency = new Currency();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    currency.ID = Convert.ToInt32(reader["ID"]);
                    currency.CountryID = Convert.ToInt32(reader["CountryID"]);
                    currency.Name = Convert.ToString(reader["Name"]);
                    currency.Rate = Convert.ToDecimal(reader["Rate"]);
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
            return currency;
        }
    }
}