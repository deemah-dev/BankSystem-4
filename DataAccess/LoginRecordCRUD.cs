using System;
using System.Data;
using System.Data.SqlClient;
using SystemModules;

namespace DataAccess
{
    public static class LoginRecordCRUD
    {
        public static DataTable GetAll()
        {
            string query = @"SELECT LoginRegister.LoginDate, LoginRegister.UserID, Users.Username, Users.Permissions
                            FROM LoginRegister INNER JOIN Users ON LoginRegister.UserID = Users.ID";

            DataTable dataTable = new DataTable();

            dataTable = CommonCRUD.GetAll(query);

            return dataTable;
        }

        public static bool AddNew(LoginRecord loginRecord)
        {
            string query = "INSERT INTO LoginRegister ([UserID], [LoginDate]) VALUES (@UserID, @LoginDate)";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", loginRecord.UserID);
            command.Parameters.AddWithValue("@LoginDate", loginRecord.LoginDate);

            return CommonCRUD.Execute(connection, command, query);
        }
    }
}