using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using SystemModules;

namespace DataAccess
{
    public static class PhoneCRUD
    {
        public static DataTable GetAll()
        {
            string query = @"SELECT Phones.ID, Countries.PhoneCode, Persons.FirstName, Persons.LastName,
                            Phones.PhoneNumber, Persons.Gender FROM Phones 
                            INNER JOIN Countries ON Phones.CountryID = Countries.CountryID
                            INNER JOIN Persons ON Phones.PersonID = Persons.ID";

            DataTable dataTable = new DataTable();

            dataTable = CommonCRUD.GetAll(query);

            return dataTable;
        }

        private static void SetParameters(SqlCommand command, Phone phone)
        {
            command.Parameters.AddWithValue("@PhoneNumber", phone.PhoneNumber);
            command.Parameters.AddWithValue("@PersonID", phone.PersonID);
            command.Parameters.AddWithValue("@CountryID", phone.CountryID);
        }

        public static bool AddNew(Phone phone)
        {
            string query = "INSERT INTO Phones ([PhoneNumber], [PersonID], [CountryID]) VALUES (@PhoneNumber, @PersonID, @CountryID)";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            SetParameters(command, phone);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Update(int ID, Phone phone)
        {
            string query = "UPDATE Phones SET [PhoneNumber] = @PhoneNumber, [PersonID] = @PersonID, [CountryID] = @CountryID WHERE [ID] = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            SetParameters(command, phone);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Delete(int ID)
        {
            string query = "DELETE FROM Phones WHERE ID = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static Phone Find(int personID)
        {
            string query = "SELECT * FROM Phones WHERE PersonID = @PersonID";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);
            Phone phone = new Phone();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    phone.ID = Convert.ToInt32(reader["ID"]);
                    phone.PersonID = Convert.ToInt32(reader["PersonID"]);
                    phone.CountryID = Convert.ToInt32(reader["CountryID"]);
                    phone.PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
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
            return phone;
        }
    }
}
