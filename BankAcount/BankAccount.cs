using System;

namespace BankAcount
{
    class BankAccount
    {
        public string name;
        public string gender;
        public string personalId;
        public string age;
        public string address;
        public double balance = 0;

        public BankAccount(string costumerName, double firstDep, string costumerGender, string costumerPersonalId, string costumerAge, string costumerAddress)
        {
            name = costumerName;
            gender = costumerGender;
            personalId = costumerPersonalId;
            age = costumerAge;
            address = costumerAddress;
            balance += firstDep;
        }

     
        public void deposit(double addAmount)
        {
            balance += addAmount;
        }

        public bool withdraw(double withdrawAmount)
        {
            bool check = true;
            if (withdrawAmount <= balance)
            {
                balance -= withdrawAmount;
            }
            else if (withdrawAmount > balance)
            {
                check = false;
            }
            return check;
        }


    }
}
