using SystemModules;

namespace Components
{
    public class BankUserComponent
    {
        public BankUserComponent(Person person, Phone phone, BankUser bankUser)
        {
            Person = person;
            Phone = phone;
            BankUser = bankUser;
        }

        public Person Person { get; set; }

        public Phone Phone { get; set; }

        public BankUser BankUser { get; set; }
    }
}