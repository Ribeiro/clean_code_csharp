using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTraining.model
{
    public class Wallet
    {
        public double Balance { get; set; }

        public Wallet(double amount)
        {
            this.Balance = amount;
        }

        public double debit(double amount)
        {
            AssertEnoughFundsForDebitOf(amount);
            this.Balance = Balance - amount;
            return amount;

        }

        private void AssertEnoughFundsForDebitOf(double amount)
        {
            if (amount > this.Balance)
            {
                throw new InsufficientFundsException("Sorry! Not sufficient funds...");
            }

        }

    }

}