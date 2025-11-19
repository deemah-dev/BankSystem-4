using SystemModules;

namespace Components
{
    public class BankClientComponent
    {
        public BankClientComponent(Person person, BankClient bankClient, Phone phone, Account account)
        {
            Person = person;
            BankClient = bankClient;
            Phone = phone;
            Account = account;
        }

        public Person Person { get; set; }

        public BankClient BankClient { get; set; }

        public Phone Phone { get; set; }

        public Account Account { get; set; }
    }
}