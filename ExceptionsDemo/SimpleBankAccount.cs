using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    public class SimpleBankAccount
    {
        public decimal Balance { get; private set; }
        public int Overdraft { get; init; }

        public SimpleBankAccount(int overdraft)
        {
            Overdraft = Math.Abs(overdraft);
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance - amount < Overdraft*-1)
            {
                throw new InvalidOperationException("Overdraft exceeded");
            }
            Balance -= amount;
        }
        

    }
}
