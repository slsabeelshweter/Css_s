using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    class banksystem
    {
        private string name;
        private string branchName;
        private int phoneNumber;
        private int balance;
        private int accountNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string BranchName
        {
            get { return branchName; }
            set { branchName = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public banksystem(string name, int phoneNumber, string ownerName, int balance, int accountNumber)
        {
            this.name = name;
            this.branchName = branchName;
            this.phoneNumber = phoneNumber;
            this.balance = balance;
            this.accountNumber = accountNumber;
        }

        public void CreateAccount()
        {
            Console.Write("Enter your Name: ");
            name = Console.ReadLine();

            Console.Write("Enter your Phone number: ");
            phoneNumber = int.Parse(Console.ReadLine());


            Console.Write("Enter Branch Name: ");
            branchName = Console.ReadLine();



            Console.Write("Enter Balance: ");
            balance = int.Parse(Console.ReadLine());

        }

        public void Withdraw(int amount)
        {
            balance -= amount;
        }

        public void Transfer(banksystem target, int amount)
        {
            balance -= amount;
            target.balance += amount;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Bank Name: {name}");
            Console.WriteLine($"Branch: {branchName}");
            Console.WriteLine($"Owner: {ownerName}");
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine($"Account Number: {accountNumber}");
        }

        ~banksystem()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            banksystem b1 = new banksystem("slsabeel", "amman", 079563251, 200, 25142654);
            banksystem b2 = new banksystem("farah", "irbid", 07562314, 500, 25165454);

            Console.WriteLine("1- Create Account");
            Console.WriteLine("2- Withdraw");
            Console.WriteLine("3- Transfer");
            Console.WriteLine("4- Show Info");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

                case 1:


                    b1.CreateAccount();
                    Console.WriteLine("Account Created Successfully");

                    break;


                case 2:
                    Console.Write("Withdraw Amount: ");
                    int w = int.Parse(Console.ReadLine());

                    if (w % 5 == 0)
                    {
                        b1.Withdraw(w);
                        Console.WriteLine("Withdraw Done");
                    }
                    else
                    {
                        Console.WriteLine("Invalid withdraw amount");
                    }
                    break;


                case 3:
                    Console.Write("Transfer Amount: ");
                    int t = int.Parse(Console.ReadLine());

                    if (t >= 1)
                    {
                        b1.Transfer(b2, t);
                        Console.WriteLine("Transfer Done");
                    }
                    else
                    {
                        Console.WriteLine("Invalid transfer amount");
                    }
                    break;


                case 4:
                    b1.PrintInfo();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}

