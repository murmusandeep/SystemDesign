using LSP.WithoutLSP.Interfaces;

namespace LSP.WithoutLSP
{
    public class FixedTermAccount : IAccount
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

        public void Withdraw(double amount)
        {
            throw new Exception("Withdawn not allowed in Fixed Term Account");
        }
    }
}
