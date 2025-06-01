using LSP.WithoutLSP.Interfaces;

namespace LSP.WithoutLSP
{
    public class CurrentAccount : IAccount
    {
        private double _balance;

        public CurrentAccount()
        {
            _balance = 0;
        }
        public void Deposite(double amount)
        {
            _balance += amount;
            Console.WriteLine("Deposited: " + amount + " in Current Account. New Balance: " + _balance);
        }

        public void Withdraw(double amount)
        {
            if (_balance > amount)
            {
                _balance -= amount;
                Console.WriteLine("Withdrawn: " + amount + " from Current Account. New Balance: " + _balance);
            }
            else
            {
                Console.WriteLine("Insufficient funds in Current Account!\n");
            }
        }
    }
}
