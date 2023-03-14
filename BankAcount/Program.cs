using BankAcount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<BankAccount> bank = new List<BankAccount>();
        while (true)
        {
            Console.Write("1. Create an account and register the necessary information\n2. Check balance\n3. Deposit\n4. Withdraw\n5. Exit\n\n\nSelect Function: ");
            string selectedOption = Console.ReadLine();
            Console.WriteLine("\n");
            if (selectedOption == "1")
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your personal id: ");
                string personalId = Console.ReadLine();
                Console.Write("Enter your genger: ");
                string gender = Console.ReadLine();
                Console.Write("Enter your age: ");
                string age = Console.ReadLine();
                Console.Write("Enter your address: ");
                string address = Console.ReadLine();
                Console.Write("Enter your initial balance: ");
                double init = double.Parse(Console.ReadLine());
                bank.Add(new BankAccount(name, init, personalId, gender, age, address));
                Console.WriteLine("Your Bank Account Added!");
                Console.ReadLine();
            }

            else if (selectedOption == "2")
            {
                Console.Write("Enter name: ");
                string nameCheck = Console.ReadLine();
                for (int i = 0; i < bank.Count; i++)
                {
                    if (bank[i].name == nameCheck)
                    {
                        Console.WriteLine("Account Found!\nName: {0}\nBalance: {1}", bank[i].name, bank[i].balance);
                    }
                }
                Console.ReadLine();
            }
            else if (selectedOption == "3")
            {
                Console.Write("Enter name: ");
                string nameCheck = Console.ReadLine(), nmNow = null;
                int accountName = -1;
                for (int i = 0; i < bank.Count; i++)
                {
                    if (bank[i].name == nameCheck)
                    {
                        nmNow = nameCheck;
                        accountName = i;
                    }
                }
                if (accountName != -1)
                {
                    Console.Write("Amount to Deposit: ");
                    bank[accountName].deposit(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Amount successfully deposited!");
                }
                else { Console.WriteLine("Account not found!"); }
                Console.ReadLine();
            }
            else if (selectedOption == "4")
            {
                Console.Write("Enter name: ");
                string nameCheck = Console.ReadLine(), nmNow = null;
                int accountName = -1;
                for (int i = 0; i < bank.Count; i++)
                {
                    if (bank[i].name == nameCheck)
                    {
                        nmNow = nameCheck;
                        accountName = i;
                    }
                }
                if (accountName != -1)
                {
                    Console.Write("Amount to Withdraw: ");
                    bool ok = bank[accountName].withdraw(double.Parse(Console.ReadLine()));
                    if (ok)
                    {
                        Console.WriteLine("Amount successfully withdrawn!");
                       
                    }
                    else { Console.WriteLine("Your account balance is insufficient!"); }
                }
                else { Console.WriteLine("Account not found!"); }
                Console.ReadLine();
            }
            else if (selectedOption == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Syntax!");
                Console.ReadLine();
            }
            Console.Clear();
        }
    }
}