using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SystemModules;

namespace DataAccess
{
    public static class BankUserCRUD
    {
        public static DataTable GetAll()
        {
            string query = @"SELECT Users.ID AS UserID, Persons.FirstName, Persons.LastName, Persons.Email,
                            Persons.BirthDate, Persons.Age, Persons.Gender, Users.Username, Users.Password,
                            Users.Permissions FROM Users INNER JOIN Persons ON Users.PersonID = Persons.ID";

            DataTable dataTable = new DataTable();

            dataTable = CommonCRUD.GetAll(query);

            return dataTable;
        }

        public static bool AddNew(BankUser bankUser)
        {
            string query = "INSERT INTO Users ([PersonID], [Username], [Password], [Permissions]) VALUES (@PersonID, @Username, @Password, @Permissions)";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", bankUser.PersonID);
            command.Parameters.AddWithValue("@Username", bankUser.Username);
            command.Parameters.AddWithValue("@Password", bankUser.Password);
            command.Parameters.AddWithValue("@Permissions", bankUser.Permissions);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Update(int ID, BankUser bankUser)
        {
            string query = "UPDATE Users SET [Password] = @Password, [Permissions] = @Permissions WHERE [ID] = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Password", bankUser.Password);
            command.Parameters.AddWithValue("@Permissions", bankUser.Permissions);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Delete(int ID)
        {
            string query = "DELETE FROM Users WHERE ID = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static BankUser Find(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"Username", username);
            command.Parameters.AddWithValue(@"Password", password);
            BankUser bankUser = new BankUser();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    bankUser.ID = Convert.ToInt32(reader["ID"]);
                    bankUser.PersonID = Convert.ToInt32(reader["PersonID"]);
                    bankUser.Username = Convert.ToString(reader["Username"]);
                    bankUser.Password = Convert.ToString(reader["Password"]);
                    bankUser.Permissions = Convert.ToInt32(reader["Permissions"]);
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
            return bankUser;
        }

        public static BankUser Find(string username)
        {
            string query = "SELECT * FROM Users WHERE Username = @Username";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"Username", username);
            BankUser bankUser = new BankUser();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    bankUser.ID = Convert.ToInt32(reader["ID"]);
                    bankUser.PersonID = Convert.ToInt32(reader["PersonID"]);
                    bankUser.Username = Convert.ToString(reader["Username"]);
                    bankUser.Password = Convert.ToString(reader["Password"]);
                    bankUser.Permissions = Convert.ToInt32(reader["Permissions"]);
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
            return bankUser;
        }

        public static BankUser Find(int ID)
        {
            string query = "SELECT * FROM Users WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"ID", ID);
            BankUser bankUser = new BankUser();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    bankUser.ID = Convert.ToInt32(reader["ID"]);
                    bankUser.PersonID = Convert.ToInt32(reader["PersonID"]);
                    bankUser.Username = Convert.ToString(reader["Username"]);
                    bankUser.Password = Convert.ToString(reader["Password"]);
                    bankUser.Permissions = Convert.ToInt32(reader["Permissions"]);
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
            return bankUser;
        }

        public static int FindPersonID(int ID)
        {
            string query = "SELECT PersonID FROM Users WHERE ID = @ID";
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

        public static List<string> UsernamesList()
        {
            string query = "SELECT Username FROM Users";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            List<string> Usernames = new List<string>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Usernames.Add(Convert.ToString(reader["Username"]));
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
            return Usernames;
        }

        public static List<int> IDsList()
        {
            string query = "SELECT ID FROM Users";
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