using System;

namespace SystemModules
{
    public class Country
    {
        public Country()
        {
            
        }
        public Country(Nullable<int> iD, string countryName, string countryCode, string phoneCode)
        {
            if (iD != null)
                ID = (int)iD;
            CountryName = countryName;
            CountryCode = countryCode;
            PhoneCode = phoneCode;
        }

        public int ID { get; set; }

        public string CountryName { get; set; }

        public string CountryCode { get; set; }

        public string PhoneCode { get; set; }
    }
}
