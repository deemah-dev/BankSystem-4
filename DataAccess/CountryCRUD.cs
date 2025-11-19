using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SystemModules;

namespace DataAccess
{
    public static class CountryCRUD
    {
        public static List<string> PhoneCodesList()
        {
            string query = "SELECT PhoneCode FROM Countries";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            List<string> PhoneCodes = new List<string>();
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PhoneCodes.Add(Convert.ToString(reader["PhoneCode"]));
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
            return PhoneCodes;
        }

        public static string GetPhoneCode(string CountryName)
        {
            string query = "SELECT PhoneCode FROM Countries WHERE CountryName = @CountryName";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);
            string PhoneCode = null;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PhoneCode = Convert.ToString(reader["PhoneCode"]);
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
            return PhoneCode;
        }

        public static DataTable GetAll()
        {
            string query = "SELECT * FROM Countries";

            DataTable dataTable = new DataTable();

            dataTable = CommonCRUD.GetAll(query);

            return dataTable;
        }

        private static void SetParameters(SqlCommand command, Country country)
        {
            command.Parameters.AddWithValue("@CountryName", country.CountryName);
            command.Parameters.AddWithValue("@CountryCode", country.CountryCode);
            command.Parameters.AddWithValue("@PhoneCode", country.PhoneCode);
        }

        public static bool AddNew(Country country)
        {
            string query = "INSERT INTO Countries ([CountryName], [CountryCode], [PhoneCode]) VALUES (@CountryName, @CountryCode, @PhoneCode)";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            SetParameters(command, country);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Update(int ID, Country country)
        {
            string query = "UPDATE Countries SET [CountryName] = @CountryName, [CountryCode] = @CountryCode, [PhoneCode] = @PhoneCode WHERE [CountryID] = @CountryID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", ID);
            SetParameters(command, country);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Delete(int ID)
        {
            string query = "DELETE FROM Countries WHERE CountryID = @CountryID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", ID);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static Country Find(string countryName)
        {
            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"CountryName", countryName);

            Country country = new Country();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    country.ID = Convert.ToInt32(reader["CountryID"]);
                    country.CountryName = Convert.ToString(reader["CountryName"]);
                    country.CountryCode = Convert.ToString(reader["CountryCode"]);
                    country.PhoneCode = Convert.ToString(reader["PhoneCode"]);
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
            return country;
        }

        public static Country Find(int countryID)
        {
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"countryID", countryID);

            Country country = new Country();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    country.ID = Convert.ToInt32(reader["countryID"]);
                    country.CountryName = Convert.ToString(reader["CountryName"]);
                    country.CountryCode = Convert.ToString(reader["CountryCode"]);
                    country.PhoneCode = Convert.ToString(reader["PhoneCode"]);
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
            return country;
        }

        public static List<string> CountriesNamesList()
        {
            string query = "SELECT CountryName FROM Countries";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            List<string> Names = new List<string>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Names.Add(Convert.ToString(reader["CountryName"]));
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
            return Names;
        }

        public static List<string> CountriesCodesList()
        {
            string query = "SELECT CountryCode FROM Countries";
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
    }
}