using LSP.WithoutLSP.Interfaces;

namespace LSP.WithoutLSP
{
    public class SavingAccount : IAccount
    {
        private double _balance;

        public SavingAccount()
        {
            _balance = 0;
        }
        public void Deposite(double amount)
        {
            _balance += amount;
            Console.WriteLine("Deposited: " + amount + " in Saving Account. New Balance: " + _balance);
        }

        public void Withdraw(double amount)
        {
            if (_balance > amount)
            {
                _balance -= amount;
                Console.WriteLine("Withdrawn: " + amount + " from Saving Account. New Balance: " + _balance);
            }
            else
            {
                Console.WriteLine("Insufficient funds in Saving Account!\n");
            }
        }
    }
}
