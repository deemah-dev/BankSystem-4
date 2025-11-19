using DataAccess;
using SystemModules;

namespace SystemBusiness
{
    public static class TransactionService
    {
        public static bool Deposit(int accountID, decimal depositAmount)
        {
            Account account = AccountCRUD.Find(accountID);
            decimal newBalance = account.Balance + depositAmount;
            return AccountCRUD.UpdateBalance(accountID, newBalance);
        }

        public static bool Withdraw(int accountID, decimal withdrawAmount)
        {
            if(AccountCRUD.Find(accountID).Balance >= withdrawAmount)
                return Deposit(accountID, -1 * withdrawAmount);
            return false;
        }

        public static bool Transfer(int senderAccountID, int recieverAccountID, decimal transferAmount)
        {
            if (AccountCRUD.Find(senderAccountID).Balance >= transferAmount)
            {
                bool deposit = false, withdraw = false;
                withdraw = Withdraw(senderAccountID, transferAmount);
                deposit = Deposit(recieverAccountID, transferAmount);
                return (withdraw && deposit);
            }
            return false;
        }
    }
}
