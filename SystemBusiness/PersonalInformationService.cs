using DataAccess;
using Extentions;
using SystemModules;

namespace SystemBusiness
{
    public static class PersonalInformationService
    {
        public static bool UpdatePassword(this BankUser bankUser, string oldPassword, string newPassword, string confirmNewPassword)
        {
            if(bankUser.Password == oldPassword)
            {
                if(newPassword == confirmNewPassword)
                {
                    bankUser.Password = newPassword.Encrypt();
                    return BankUserCRUD.Update(bankUser.ID, bankUser);
                }
                return false;
            }
            return false;

        }

        public static bool UpdateEmail(this BankUser bankUser, string email)
        {
            int PersonID = BankUserCRUD.FindPersonID(bankUser.ID);
            Person person = PersonCRUD.Find(PersonID);
            person.Email = email;
            return PersonCRUD.Update(person.ID, person);
        }

        public static bool UpdatePhone(this BankUser bankUser, string countryName, string phoneNumber)
        {
            int PersonID = BankUserCRUD.FindPersonID(bankUser.ID);
            Phone phone = PhoneCRUD.Find(PersonID);

            phone.CountryID = CountryCRUD.Find(countryName).ID;
            phone.PhoneNumber = phoneNumber;

            return PhoneCRUD.Update(phone.ID, phone);
        }
    }
}
