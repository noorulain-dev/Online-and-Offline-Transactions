using System;

namespace Passtask3
{
    // Main class called Program where our Program begins
    class Program
    {
        // Storing information in an array such as Transaction number, Transaction Date, Transaction Amount, Points etc.
        // Each array is known as myTransactions
        public static void Show(Transaction[] transactions){

                Console.WriteLine(transactions[0].StringMessage());
                Console.WriteLine("Total amount: " + transactions[0].Amounts);
                Console.WriteLine("Points: " + transactions[0].UpdatePoints());
                Console.WriteLine("----------------");

                Console.WriteLine(transactions[1].StringMessage());
                Console.WriteLine("Total amount: " + transactions[1].Amounts);
                Console.WriteLine("Points: " + transactions[1].UpdatePoints());
                Console.WriteLine("----------------");

                Console.WriteLine(transactions[2].StringMessage());
                Console.WriteLine("Total amount: " + transactions[2].Amounts);
                Console.WriteLine("Points: " + transactions[2].UpdatePoints());
                Console.WriteLine("Date: " + transactions[2].Date);
                Console.WriteLine("----------------");

                Console.WriteLine(transactions[3].StringMessage());
                Console.WriteLine("----------------");

        }
        
        //The program executes from here and then calls the main class Program
        static void Main(string[] args)
        {
            Transaction[] myTransactions = new Transaction[4];

            // Passing the following values to the Constructor Transaction in the same order
            // Saving values to both the arrays respectively
            myTransactions[0] = new Online(280, Online.PaymentMode.CreditCard, "date");
            myTransactions[1] = new Online(280, Online.PaymentMode.Paypal, "date");    
            myTransactions[2] = new Offline(280, "3/3/2021", true);
            myTransactions[3] = new Offline(280, "4/4/2021", false);


            // Calling the Show method to print the arrays
            Show(myTransactions);
        }


    

        
    }
}