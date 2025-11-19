using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;
using SystemModules;

namespace DataAccess
{
    public static class AccountCRUD
    {
        public static DataTable GetAll()
        {
            string query = "SELECT * FROM Accounts";

            DataTable dataTable = new DataTable();

            dataTable = CommonCRUD.GetAll(query);

            return dataTable;
        }

        public static bool AddNew(Account account)
        {
            string query = "INSERT INTO Accounts ([Balance], [PINCode], [ClientID]) VALUES (@Balance, @PINCode, @ClientID)";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Balance", account.Balance);
            command.Parameters.AddWithValue("@PINCode", account.PINCode);
            command.Parameters.AddWithValue("@ClientID", account.ClientID);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool UpdatePINCode(int ID, string pinCode)
        {
            string query = "UPDATE  Accounts SET [PINCode] = @PINCode WHERE [ID] = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@PINCode", pinCode);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool UpdateBalance(int ID, decimal newBalance)
        {
            string query = "UPDATE  Accounts SET [Balance] = @Balance WHERE [ID] = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Balance", newBalance);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Delete(int ID)
        {
            string query = "DELETE FROM Accounts WHERE ID = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static Account Find(int clientID)
        {
            string query = "SELECT * FROM Accounts WHERE ClientID = @ClientID";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"ClientID", clientID);
            Account account = new Account();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    account.ID = Convert.ToInt32(reader["ID"]);
                    account.PINCode = Convert.ToString(reader["PINCode"]);
                    account.Balance = Convert.ToDecimal(reader["Balance"]);
                    account.ClientID = Convert.ToInt32(reader["ClientID"]);
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
            return account;
        }

        public static List<int> AccountsIDsList()
        {
            string query = "SELECT ID FROM Accounts";
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