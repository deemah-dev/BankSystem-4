using DataAccess;
using System.Collections.Generic;
using SystemModules;

namespace SystemBusiness
{
    public static class CountryService
    {
        public static Country Find(int countryID)
        {
            return CountryCRUD.Find(countryID);
        }

        public static List<string> CountriesNamesList()
        {
            return CountryCRUD.CountriesNamesList();
        }

        public static List<string> CountriesCodesList()
        {
            return CountryCRUD.CountriesCodesList();
        }

        public static string PhoneCode(string countryName)
        {
            return CountryCRUD.GetPhoneCode(countryName);
        }
    }
}
