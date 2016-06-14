using CleanCodeTraining.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTraining.LawOfDemeter
{
    public class MainLawOfDemeter
    {

        public static void Main()
        {
            Wallet wallet = new Wallet(1000);
            Customer customer = new Customer(wallet);

            PaperBoy paperboy = new PaperBoy();

            //WTF!!! Are you crazy to deliver your wallet to anyone, dude???
            Wallet customersWallet = customer.Wallet;

            Console.WriteLine("Original Customers Wallet balance is: " + customersWallet.Balance);

            //WTF 2!!! Are you crazy to allow anyone with your wallet´s reference set the balance they want, dude???
            customersWallet.Balance = 200;

            Console.WriteLine("Customers Wallet NEW balance is: " + customersWallet.Balance + " changed by anyone with his Wallet's memory reference!");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("WTF, Dude !!!");
            }

            Console.Read();
        }

    }

}
