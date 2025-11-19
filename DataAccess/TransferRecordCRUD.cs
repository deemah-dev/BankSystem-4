using System;
using System.Data;
using System.Data.SqlClient;
using SystemModules;

namespace DataAccess
{
    public static class TransferRecordCRUD
    {
        public static DataTable GetAll()
        {
            string query = @"SELECT TransferRegister.ID, TransferRegister.TransferDate, TransferRegister.SenderID, 
                            TransferRegister.ReceiverID, TransferRegister.TransferAmount, TransferRegister.UserID,
                            Users.Username, Users.Permissions FROM TransferRegister
							                            INNER JOIN Users ON TransferRegister.UserID = Users.ID";
            DataTable dataTable = new DataTable();

            dataTable = CommonCRUD.GetAll(query);

            return dataTable;
        }

        public static bool AddNew(TransferRecord transferRecord)
        {
            string query = "INSERT INTO TransferRegister ([SenderID], [ReceiverID], [TransferAmount], [UserID], [TransferDate]) VALUES (@SenderID, @ReceiverID, @TransferAmount, @UserID, @TransferDate)";

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SenderID", transferRecord.SenderID);
            command.Parameters.AddWithValue("@ReceiverID", transferRecord.RecieverID);
            command.Parameters.AddWithValue("@TransferAmount", transferRecord.TransferAmount);
            command.Parameters.AddWithValue("@UserID", transferRecord.UserID);
            command.Parameters.AddWithValue("@TransferDate", transferRecord.TransferDate);

            return CommonCRUD.Execute(connection, command, query);
        }
    }
}