using System;

namespace SystemModules
{
    public class Phone
    {
        public Phone()
        {

        }
        public Phone(Nullable<int> iD, int personID, int phoneCodeID, string phoneNumber)
        {
            if (iD != null)
                ID = (int)iD;
            PersonID = personID;
            CountryID = phoneCodeID;
            PhoneNumber = phoneNumber;
        }

        public int ID { get; set; }

        public int PersonID { get; set; }

        public int CountryID { get; set; }

        public string PhoneNumber { get; set; }
    }
}