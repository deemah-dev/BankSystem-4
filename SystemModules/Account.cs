using System;

namespace SystemModules
{
    public class Account
    {
        public Account()
        {
            
        }
        public Account(Nullable<int> iD, int clientID, string pINCode, decimal balance)
        {
            if(iD != null)
                ID = (int)iD;
            ClientID = clientID;
            PINCode = pINCode;
            Balance = balance;
        }

        public int ID { get; set; }

        public int ClientID { get; set; }

        public string PINCode { get; set; }

        public decimal Balance { get; set; }
    }
}