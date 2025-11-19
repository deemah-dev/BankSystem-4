using System;
using System.Data;
using System.Data.SqlClient;
using SystemModules;

namespace DataAccess
{
    public static class PersonCRUD
    {
        public static bool AddNew(Person person)
        {
            string query = "INSERT INTO Persons ([FirstName], [LastName], [Email], [BirthDate], [Age], [Gender]) VALUES (@FirstName, @LastName, @Email, @BirthDate, @Age, @Gender)";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", person.FirstName);
            command.Parameters.AddWithValue("@LastName", person.LastName);
            if(person.Email != null) command.Parameters.AddWithValue("@Email", person.Email);
            else command.Parameters.AddWithValue("@Email", DBNull.Value);
            command.Parameters.AddWithValue("@BirthDate", person.BirthDate);
            command.Parameters.AddWithValue("@Age", person.Age);
            command.Parameters.AddWithValue("@Gender", person.Gender);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Update(int ID, Person person)
        {
            string query = "UPDATE Persons SET [FirstName] = @FirstName, [LastName] = @LastName, [Email] = @Email, [BirthDate] = @BirthDate, [Age] = @Age, [Gender] = @Gender WHERE [ID] = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@FirstName", person.FirstName);
            command.Parameters.AddWithValue("@LastName", person.LastName);
            if (person.Email != null) command.Parameters.AddWithValue("@Email", person.Email);
            else command.Parameters.AddWithValue("@Email", DBNull.Value);
            command.Parameters.AddWithValue("@BirthDate", person.BirthDate);
            command.Parameters.AddWithValue("@Age", person.Age);
            command.Parameters.AddWithValue("@Gender", person.Gender);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static bool Delete(int ID)
        {
            string query = "DELETE FROM Persons WHERE ID = @ID";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            return CommonCRUD.Execute(connection, command, query);
        }

        public static Person Find(string firstName, string lastName)
        {
            string query = "SELECT * FROM Persons WHERE FirstName = @FirstName AND LastName = @LastName";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"FirstName", firstName);
            command.Parameters.AddWithValue(@"LastName", lastName);

            Person person = new Person();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    person.ID = Convert.ToInt32(reader["ID"]);
                    person.FirstName = Convert.ToString(reader["FirstName"]);
                    person.LastName = Convert.ToString(reader["LastName"]);
                    if (reader["Email"] != DBNull.Value) person.Email = Convert.ToString(reader["Email"]);
                    else person.Email = "";
                    person.BirthDate = Convert.ToDateTime(reader["BirthDate"]);
                    person.Age = Convert.ToByte(reader["Age"]);
                    person.Gender = Convert.ToChar(reader["Gender"]);
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
            return person;
        }

        public static Person Find(int ID)
        {
            string query = "SELECT * FROM Persons WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"ID", ID);

            Person person = new Person();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    person.ID = Convert.ToInt32(reader["ID"]);
                    person.FirstName = Convert.ToString(reader["FirstName"]);
                    person.LastName = Convert.ToString(reader["LastName"]);
                    if (reader["Email"] != DBNull.Value) person.Email = Convert.ToString(reader["Email"]);
                    else person.Email = "";
                    person.BirthDate = Convert.ToDateTime(reader["BirthDate"]);
                    person.Age = Convert.ToByte(reader["Age"]);
                    person.Gender = Convert.ToChar(reader["Gender"]);
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
            return person;
        }
    }
}