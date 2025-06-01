using LSP.WithoutLSP.Interfaces;

namespace LSP.WithoutLSP
{
    public class BankClient
    {
        private List<IAccount> _accounts;

        public BankClient(List<IAccount> accounts)
        {
            _accounts = accounts;
        }

        public void ProcessTransactions()
        {
            foreach (var account in _accounts)
            {
                account.Deposite(1000);

                try
                {
                    account.Withdraw(500);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.ToString());
                }
            }
        }
    }
}
