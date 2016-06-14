using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTraining.model
{
    public class Customer
    {
        public Wallet Wallet { get; set; }

        public Customer(Wallet wallet)
        {
            this.Wallet = wallet;
        }

        public double Pay(double amount)
        {
            return this.Wallet.debit(amount);
        }

    }

}
