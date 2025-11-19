using DataAccess;
using System.Collections.Generic;

namespace SystemBusiness
{
    public static class AccountService
    {
        public static List<int> AccountsIDsList()
        {
            return AccountCRUD.AccountsIDsList();
        }
    }
}
