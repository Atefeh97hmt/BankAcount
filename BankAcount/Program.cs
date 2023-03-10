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
            Console.Write("1. Create an account and register the necessary information\nX. Terminate\n\nSelect Function: ");
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
            else
            {
                Console.WriteLine("Invalid Syntax!");
                Console.ReadLine();
            }
            Console.Clear();
        }
    }
}