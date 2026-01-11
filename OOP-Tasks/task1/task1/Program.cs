using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{

    class car
    {
        private string model;
        private string brand;
        private int year;

        public string Model
        {
            get { return model; }
            set
            {
                model = value;
            }
        }
        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
            }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public void Start()
        {
            Console.WriteLine("The car is starting");
        }

        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }

        public void Stop()
        {
            Console.WriteLine("The car has stopped");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
            {
            car c1= new car();
            c1.Brand = "BMW";
            c1.Year = 2023;
            c1.Model = "M5";

            Console.WriteLine($"Brand: {c1.Brand}");
            Console.WriteLine($"Model: {c1.Model}");
            Console.WriteLine($"Year: {c1.Year}");

            c1.Drive();
            c1.Stop();
            c1.Start();


        }

    }
}