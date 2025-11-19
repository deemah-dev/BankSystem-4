using System;

namespace SystemModules
{
    public class BankClient
    {
        public BankClient()
        {
            
        }
        public BankClient(int personID, Nullable<int> iD)
        {
            if (iD != null)
                ID = (int)iD;
            PersonID = personID;
        }
        public int ID { get; set; }

        public int PersonID { get; set; }
    }
}
