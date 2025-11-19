using DataAccess;
using System;
using SystemModules;
using Extentions;
using System.Data;
using Components;
using System.Collections.Generic;

namespace SystemBusiness
{
    public static class BankUserService
    {
        public static bool checkPermissions(BankUser bankUser, Permissions permission)
        {
            if (bankUser.Permissions == (int)Permissions.All)
                return true;
            if (bankUser.Permissions == (bankUser.Permissions | (int)permission))
                return true;
            return false;
        }

        public static bool Add(string firstName, string lastName, string email, string countryName, string phoneNumber, DateTime birthDate, string gender, string username, string password, int permissions)
        {
            bool AddPerson = false, AddUser = false, AddPhone = false;
            Person person = new Person(null, firstName, lastName, email, PersonService.Gender(gender), birthDate, PersonService.Age(birthDate));
            AddPerson = PersonCRUD.AddNew(person);
            int personID = PersonCRUD.Find(person.FirstName, person.LastName).ID;

            Phone phone = new Phone(null, personID, CountryCRUD.Find(countryName).ID, phoneNumber);
            AddPhone = PhoneCRUD.AddNew(phone);

            BankUser bankUser = new BankUser(personID, null, username, password.Encrypt(), permissions);
            AddUser = BankUserCRUD.AddNew(bankUser);

            return (AddPerson && AddPhone && AddUser);
        }

        public static DataTable Table()
        {
            return BankUserCRUD.GetAll();
        }

        public static bool Update(int ID, string firstName, string lastName, string email, string countryName, string phoneNumber, string password, int permissions)
        {
            bool UpdatePerson = false, UpdatePhone = false, UpdateUser = false;
            int PersonID = BankUserCRUD.FindPersonID(ID);
            Person OldPerson = PersonCRUD.Find(PersonID);
            Person person = new Person(null, firstName, lastName, email, OldPerson.Gender, OldPerson.BirthDate, OldPerson.Age);
            UpdatePerson = PersonCRUD.Update(PersonID, person);

            Phone OldPhone = PhoneCRUD.Find(PersonID);
            if (OldPhone.PhoneNumber == phoneNumber) UpdatePhone = true;
            else
            {
                int NewCountryID = CountryCRUD.Find(countryName).ID;
                Phone phone = new Phone(null, OldPhone.PersonID, NewCountryID, phoneNumber);
                UpdatePhone = PhoneCRUD.Update(OldPhone.ID, phone);
            }
            BankUser OldBankUser = BankUserCRUD.Find(ID);
            BankUser bankUser = new BankUser(OldBankUser.PersonID, null, OldBankUser.Username, password.Encrypt(), permissions);
            UpdateUser = BankUserCRUD.Update(ID, bankUser);

            return (UpdatePerson && UpdatePhone && UpdateUser);
        }

        public static bool Update(string Username, string firstName, string lastName, string email, string countryName, string phoneNumber, string password, int permissions)
        {
            int ID = BankUserCRUD.Find(Username).ID;
            return Update(ID, firstName, lastName, email, countryName, phoneNumber, password, permissions);
        }

        public static bool Delete(int ID)
        {
            bool DeletePerson = false, DeletePhone = false, DeleteUser = false;
            int PersonID = BankUserCRUD.FindPersonID(ID);
            int PhoneID = PhoneCRUD.Find(PersonID).ID;

            DeleteUser = BankUserCRUD.Delete(ID);
            DeletePhone = PhoneCRUD.Delete(PhoneID);
            DeletePerson = PersonCRUD.Delete(PersonID);

            return (DeletePerson && DeletePhone && DeleteUser);
        }

        public static bool Delete(string Username)
        {
            int ID = BankUserCRUD.Find(Username).ID;
            return Delete(ID);
        }

        public static BankUserComponent Component(int ID)
        {
            int PersonID = BankUserCRUD.FindPersonID(ID);
            Person Person = PersonCRUD.Find(PersonID);
            Phone Phone = PhoneCRUD.Find(PersonID);
            BankUser BankUser = BankUserCRUD.Find(ID);

            return new BankUserComponent(Person, Phone, BankUser);
        }

        public static BankUserComponent Component(string Username)
        {
            int ID = BankUserCRUD.Find(Username).ID;
            return Component(ID);
        }

        public static List<String> UsernamesList()
        {
            return BankUserCRUD.UsernamesList();
        }

        public static List<int> IDsList()
        {
            return BankUserCRUD.IDsList();
        }

        public static BankUser Login(string username, string password)
        {
            return BankUserCRUD.Find(username, password.Encrypt());
        }
    }
}