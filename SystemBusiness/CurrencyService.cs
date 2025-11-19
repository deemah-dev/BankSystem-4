using DataAccess;
using System.Data;
using SystemModules;

namespace SystemBusiness
{
    public static class CurrencyService
    {
        public static DataTable Table()
        {
            return CurrencyCRUD.GetAll();
        }

        public static bool Add(string name, decimal rate, string countryName)
        {
            int countryID = CountryCRUD.Find(countryName).ID;
            Currency currency = new Currency(null, countryID, name, rate);
            return CurrencyCRUD.AddNew(currency);
        }

        public static bool UpdateRate(string CurrencyCode, decimal NewRate)
        {
            int currencyID = CurrencyCRUD.Find(CurrencyCode).ID;
            return CurrencyCRUD.UpdateRate(currencyID, NewRate);
        }

        public static bool DeleteCurrency(string CurrencyCode)
        {
            int currencyID = CurrencyCRUD.Find(CurrencyCode).ID;
            return CurrencyCRUD.Delete(currencyID);
        }
    }
}