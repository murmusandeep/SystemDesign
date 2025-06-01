using LSP.WithLSP.Interfaces;

namespace LSP.WithLSP
{
    public class FixedTermAccount : IDepositOnlyAccount
    {
        private double _balance;

        public FixedTermAccount()
        {
            _balance = 0;
        }
        public void Deposite(double amount)
        {
            _balance += amount;
            Console.WriteLine("Deposited: " + amount + " in Fixed Term Account. New Balance: " + _balance);
        }
    }
}
