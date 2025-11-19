using System;

namespace SystemBusiness
{
    internal static class PersonService
    {
        public static char Gender(string gender)
        {
            if (gender.ToLower() == "male") return 'M';
            if (gender.ToLower() == "female") return 'F';
            return 'o';
        }

        public static byte Age(DateTime BirthDate)
        {
            int Age = DateTime.Now.Year - BirthDate.Year;
            return Convert.ToByte(Age);
        }
    }
}
