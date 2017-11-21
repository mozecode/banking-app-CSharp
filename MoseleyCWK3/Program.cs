using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyCWK3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            double accountBalance = 1000.50;

            string userInput;

            int counter;
            counter = 1;

            string accountInput;

            double accountAction;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\tWelcome to Your Banking Application");

            Console.WriteLine();//blank

            Console.Write("Would you like to make a (D)eposit, (W)ithdrawal, or (Q)uit: ");
            Console.ForegroundColor = ConsoleColor.Red;
            userInput = Console.ReadLine();

            
            while (userInput!="Q" )
            {
                if (userInput=="D" && counter >= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("How much would you like to deposit? $");
                    Console.ForegroundColor = ConsoleColor.Red;
                    accountInput = Console.ReadLine();
                    accountAction = double.Parse(accountInput);
                    accountBalance = accountBalance + accountAction;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your account balance is {0:C}.", accountBalance);
                    counter++;
                }

                else if (userInput=="W" && counter >= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("How much would you like to withdraw? $");
                    Console.ForegroundColor = ConsoleColor.Red;
                    accountInput = Console.ReadLine();
                    accountAction = double.Parse(accountInput);
                    accountBalance = accountBalance - accountAction;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your account balance is {0:C}.", accountBalance);
                    counter++;

                    if (accountBalance<0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your account is overdrawn.  Penalty assessed of $25.");
                        accountBalance = accountBalance - 25;
                        Console.WriteLine("Your account balance is negative {0:C}.", accountBalance);
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Please enter D, W, or Q.");
                }

               
                Console.WriteLine(); //blank
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Would you like to make a (D)eposit, (W)ithdrawal, or (Q)uit: ");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput = Console.ReadLine(); //test condition again

            }//while ends
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You have completed {0} transactions.  Your final balance is {1:C}.", counter-1, accountBalance);
            Console.ReadKey();
        }
    }
}
