using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();
        Console.WriteLine( text);
        Console.WriteLine("------------------------");

        double Dou = 15.5;
        string Str = "Slsabeel";
        char cha = 'S';
        bool boo = true;
        int y = 10;
        const int z = 2025;

        Console.WriteLine("Double: " + Dou);
        Console.WriteLine("String: " + Str);
        Console.WriteLine("Char: " + cha);
        Console.WriteLine("Bool: " + boo);
        Console.WriteLine("Int: " + y);
        Console.WriteLine("Const: " + z);
        Console.WriteLine("------------------------");

        string[] cars = { "BMW", "Toyota", "Ford", "Honda" };

        Console.WriteLine("Cars:");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }

        Console.WriteLine( cars.Length);


        Console.Write("inter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("inter your last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Inter your year of birth: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Output: " + firstName + " " + lastName + " " + year);
        Console.WriteLine("------------------------");


        int[] arr = new int[10];

        Console.WriteLine("Input 10 elements :");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("index " + i );
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Elements in array are: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i] + " ");
        }

        }
}


