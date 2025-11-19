using DataAccess;
using System;
using System.Data;
using SystemModules;

namespace SystemBusiness
{
    public static class RegisterService
    {
        public static DataTable LoginRegisterTable()
        {
            return LoginRecordCRUD.GetAll();
        }

        public static bool AddLoginRecord(int UserID, DateTime LoginDate)
        {
            LoginRecord loginRecord = new LoginRecord(null, UserID, LoginDate);
            return LoginRecordCRUD.AddNew(loginRecord);
        }

        public static DataTable TransferRegisterTable()
        {
            return TransferRecordCRUD.GetAll();
        }

        public static bool AddTransferRecord(int senderID, int recieverID, decimal transferAmount, int userID, DateTime TransferDate)
        {
            TransferRecord transferRecord = new TransferRecord(null, senderID, recieverID, transferAmount, userID, TransferDate);
            return TransferRecordCRUD.AddNew(transferRecord);
        }

        public static DataTable PhoneRegisterTable()
        {
            return PhoneCRUD.GetAll();
        }
    }
}