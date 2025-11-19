using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SystemModules;

namespace DataAccess
{
    public static class BankClientCRUD
    {
        public static DataTable GetAll()
        {
            string query = @"SELECT Accounts.ClientID, Persons.FirstName, Persons.LastName, Persons.Email, Persons.Age, Persons.Gender, Accounts.PINCode, Accounts.Balance
             FROM   Clients INNER JOIN
             Accounts ON Clients.ID = Accounts.ClientID INNER JOIN
             Persons ON Clients.PersonID = Persons.ID";

            DataTable dataTable = new DataTable();

            dataTable = CommonCRUD.GetAll(query);

            return dataTable;
        }

        public static bool AddNew(BankClient bankClient)
        {
            string query = "INSERT INTO Clients ([PersonID]) VALUES (@PersonID)";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", bankClient.PersonID);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Update(int ID, BankClient bankClient)
        {
            string query = "UPDATE Clients SET [PersonID] = @PersonID WHERE [ID] = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@PersonID", bankClient.PersonID);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Delete(int ID)
        {
            string query = "DELETE FROM Clients WHERE ID = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static int FindCLientID(int personID)
        {
            string query = "SELECT ID FROM Clients WHERE PersonID = @PersonID";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"PersonID", personID);

            int CLientID = -1;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CLientID = Convert.ToInt32(reader["ID"]);
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
            return CLientID;
        }

        public static int FindPersonID(int ID)
        {
            string query = "SELECT PersonID FROM Clients WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"ID", ID);

            int PersonID = -1;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
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
            return PersonID;
        }

        public static BankClient Find(int ID)
        {
            string query = "SELECT * FROM Clients WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"ID", ID);

            BankClient bankClient = new BankClient();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    bankClient.ID = Convert.ToInt32(reader["ID"]);
                    bankClient.PersonID = Convert.ToInt32(reader["PersonID"]);
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
            return bankClient;
        }

        public static List<int> IDsList()
        {
            string query = "SELECT ID FROM Clients";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            List<int> IDs = new List<int>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IDs.Add(Convert.ToInt32(reader["ID"]));
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
            return IDs;
        }
    }
}