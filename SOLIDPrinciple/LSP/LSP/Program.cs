namespace LSP
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<WithoutLSP.Interfaces.IAccount> withoutLSPAccounts = new List<WithoutLSP.Interfaces.IAccount>();

            withoutLSPAccounts.Add(new WithoutLSP.SavingAccount());
            withoutLSPAccounts.Add(new WithoutLSP.CurrentAccount());
            withoutLSPAccounts.Add(new WithoutLSP.FixedTermAccount());

            WithoutLSP.BankClient withoutLSPBankClient = new WithoutLSP.BankClient(withoutLSPAccounts);
            withoutLSPBankClient.ProcessTransactions();

            Console.WriteLine();

            List<WithLSP.Interfaces.IWithdrawableAccount> withLSPWithdrawableAccounts = new List<WithLSP.Interfaces.IWithdrawableAccount>();
            withLSPWithdrawableAccounts.Add(new WithLSP.SavingAccount());
            withLSPWithdrawableAccounts.Add(new WithLSP.CurrentAccount());

            List<WithLSP.Interfaces.IDepositOnlyAccount> withLSPDepositOnlyAccounts = new List<WithLSP.Interfaces.IDepositOnlyAccount>();
            withLSPDepositOnlyAccounts.Add(new WithLSP.FixedTermAccount());

            WithLSP.BankClient withLSPBankClient = new WithLSP.BankClient(withLSPDepositOnlyAccounts, withLSPWithdrawableAccounts);
            withLSPBankClient.ProcessTransactions();
        }
    }
}
