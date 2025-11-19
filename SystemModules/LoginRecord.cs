using System;

namespace SystemModules
{
    public class LoginRecord
    {
        public LoginRecord(Nullable<int> iD, int userID, DateTime loginDate)
        {
            if (iD != null)
                ID = (int)iD;
            UserID = userID;
            LoginDate = loginDate;
        }

        public int ID { get; set; }

        public int UserID { get; set; }

        public DateTime LoginDate { get; set; }
    }
}