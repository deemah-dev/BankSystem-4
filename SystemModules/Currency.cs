using System;

namespace SystemModules
{
    public class Currency
    {
        public Currency()
        {
            
        }
        public Currency(Nullable<int> iD, int countryID, string name, decimal rate)
        {
            if (iD != null)
                ID = (int)iD;
            CountryID = countryID;
            Name = name;
            Rate = rate;
        }

        public int ID { get; set; }

        public int CountryID { get; set; }

        public string Name { get; set; }

        public decimal Rate { get; set; }
    }
}