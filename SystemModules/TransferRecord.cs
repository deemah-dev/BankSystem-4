using System;

namespace SystemModules
{
    public class TransferRecord
    {
        public TransferRecord(Nullable<int> iD, int senderID, int recieverID, decimal transferAmount, int userID, DateTime transferDate)
        {
            if (iD != null)
                ID = (int)iD;
            SenderID = senderID;
            RecieverID = recieverID;
            TransferAmount = transferAmount;
            UserID = userID;
            TransferDate = transferDate;
        }

        public int ID { get; set; }

        public int SenderID { get; set; }

        public int RecieverID { get; set; }

        public decimal TransferAmount { get; set; }

        public int UserID { get; set; }

        public DateTime TransferDate { get; set; }
    }
}
