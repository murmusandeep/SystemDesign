using LSP.WithLSP.Interfaces;

namespace LSP.WithLSP
{
    public class BankClient
    {
        private List<IDepositOnlyAccount> _depositOnlyAccounts;
        private List<IWithdrawableAccount> _withdrawablesAccount;

        public BankClient(List<IDepositOnlyAccount> depositOnlyAccounts, List<IWithdrawableAccount> withdrawableAccounts)
        {
            _depositOnlyAccounts = depositOnlyAccounts;
            _withdrawablesAccount = withdrawableAccounts;
        }

        public void ProcessTransactions()
        {
            foreach (var account in _withdrawablesAccount)
            {
                account.Deposite(1000);
                account.Withdraw(500);
            }

            foreach (var account in _depositOnlyAccounts)
            {
                account.Deposite(1000);
            }
        }
    }
}
