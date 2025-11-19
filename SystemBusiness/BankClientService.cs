using DataAccess;
using System;
using System.Data;
using SystemModules;
using Components;
using System.Collections.Generic;

namespace SystemBusiness
{
    public static class BankClientService
    {
        public static bool Add(string firstName, string lastName, string email, string country, string phoneNumber, DateTime birthDate, string gender, string pinCode, decimal balance)
        {
            bool AddPerson = false, AddClient = false, AddPhone = false, AddAccount = false;
            Person person = new Person(null, firstName, lastName, email, PersonService.Gender(gender), birthDate, PersonService.Age(birthDate));
            AddPerson = PersonCRUD.AddNew(person);
            int personID = PersonCRUD.Find(person.FirstName, person.LastName).ID;

            BankClient bankClient = new BankClient(personID, null);
            AddClient = BankClientCRUD.AddNew(bankClient);

            Phone phone = new Phone(null, personID, CountryCRUD.Find(country).ID, phoneNumber);
            AddPhone = PhoneCRUD.AddNew(phone);

            Account account = new Account(null, BankClientCRUD.FindCLientID(personID), pinCode, balance);
            AddAccount = AccountCRUD.AddNew(account);

            return (AddPerson && AddClient && AddPhone && AddAccount);
        }
        
        public static DataTable Table()
        {
            return BankClientCRUD.GetAll();
        }

        public static bool Update(int ID, string firstName, string lastName, string email, string countryName, string phoneNumber, string pinCode)
        {
            bool UpdatePerson = false, UpdatePhone = false, UpdatePINCode = false;
            int PersonID = BankClientCRUD.FindPersonID(ID);
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
            Account OldAccount = AccountCRUD.Find(ID);
            if (OldAccount.PINCode == pinCode) UpdatePINCode = true;
            else
            {
                UpdatePINCode = AccountCRUD.UpdatePINCode(OldAccount.ID, pinCode);
            }
            return (UpdatePerson && UpdatePhone && UpdatePINCode);
        }

        public static bool Delete(int ID)
        {
            bool DeletePerson = false, DeletePhone = false, DeleteAccount = false, DeleteClient = false;
            int PersonID = BankClientCRUD.FindPersonID(ID);
            int PhoneID = PhoneCRUD.Find(PersonID).ID;
            int accountID = AccountCRUD.Find(ID).ID;

            DeleteAccount = AccountCRUD.Delete(accountID);
            DeleteClient = BankClientCRUD.Delete(ID);
            DeletePhone = PhoneCRUD.Delete(PhoneID);
            DeletePerson = PersonCRUD.Delete(PersonID);

            return (DeletePerson && DeletePhone && DeleteAccount && DeleteClient);
        }

        public static BankClientComponent Component(int ID)
        {
            int PersonID = BankClientCRUD.FindPersonID(ID);
            Person Person = PersonCRUD.Find(PersonID);
            Phone Phone = PhoneCRUD.Find(PersonID);
            BankClient BankClient = BankClientCRUD.Find(ID);
            Account Account = AccountCRUD.Find(ID);

            return new BankClientComponent(Person, BankClient, Phone, Account);
        }

        public static List<int> IDsList()
        {
            return BankClientCRUD.IDsList();
        }
    }
}