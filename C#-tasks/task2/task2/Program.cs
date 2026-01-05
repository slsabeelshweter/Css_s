using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*PAAART 1 */

            int counteven = 0;
            int countodd = 0;

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("enter the number : ");
                int num=int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                if (num<0)
                {
                    continue;
                }
                if (num % 2 == 0)
                {
                    counteven++;
                }
                else
                {
                    countodd++;
                }
            }
            Console.WriteLine($"Even numbers count: {counteven}");
            Console.WriteLine($"Odd numbers count: {countodd}");


            /*PAART 2 */
            int grade;

            while (true)
            {
                Console.Write("Enter student grade : ");
                grade = int.Parse(Console.ReadLine());

                if (grade >= 0 && grade <= 100)
                {
                    break;
                }

                Console.WriteLine("Invalid grade");
            }

            if (grade >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
           /* part 3 */
            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("(1)  Addition");
                Console.WriteLine("(2) Subtraction");
                Console.WriteLine("(3)  Multiplication");
                Console.WriteLine("(4)  Division");

                char operation = char.Parse(Console.ReadLine());

                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (operation)
                {
                    case '1':
                        Console.WriteLine($"Result: {num1 + num2}");
                        break;

                    case '2':
                        Console.WriteLine($"Result: {num1 - num2}");
                        break;

                    case '3':
                        Console.WriteLine($"Result: {num1 * num2}");
                        break;

                    case '4':
                        if (num2 != 0)
                            Console.WriteLine($"Result: {num1 / num2}");
                        else
                            Console.WriteLine("Cannot divide by zero");
                        break;

                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

                Console.Write("Do you want to continue? (y/n): ");
                char choice = char.Parse(Console.ReadLine());

                if (choice == 'n' || choice == 'N')
                {
                    break;
                }
            }



        }
    }
}
