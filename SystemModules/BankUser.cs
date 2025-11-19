using System;

namespace SystemModules
{
    public enum Permissions
    {
        ManageUsers = 1,
        AddUsers = 2,
        UpdateUsers = 4,
        DeleteUsers = 8,
        ManageClients = 16,
        AddClients = 32,
        UpdateClients = 64,
        DeleteClients = 128,
        DoTransactions = 256,
        ShowRegisters = 512,
        ManageCurrencies = 1024,
        All = -1
    }
    public class BankUser
    {
        public BankUser()
        {
            
        }
        public BankUser(int personID, Nullable<int> iD, string username, string password, int permissions)
        {
            PersonID = personID;
            if (iD != null)
                ID = (int)iD;
            Username = username;
            Password = password;
            Permissions = permissions;
        }
        
        public int ID { get; set; }

        public int PersonID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Permissions { get; set; }
    }
}