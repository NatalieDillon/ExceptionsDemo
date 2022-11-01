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
        public decimal Overdraft { get; init; }

        public SimpleBankAccount(decimal overdraft)
        {
            Overdraft = overdraft;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Math.Abs(Balance - amount) > Overdraft)
            {
                throw new InvalidOperationException("Overdraft exceeded");
            }
            Balance -= amount;
        }
        

    }
}
