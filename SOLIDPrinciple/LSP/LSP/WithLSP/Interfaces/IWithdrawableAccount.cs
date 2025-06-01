namespace LSP.WithLSP.Interfaces
{
    public interface IWithdrawableAccount : IDepositOnlyAccount
    {
        public void Withdraw(double amount);
    }
}
