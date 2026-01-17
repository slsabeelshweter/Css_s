using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    
        public abstract class Person
        {
            private int id;
            private string name;

            public int Id
            {
                get { return id; }
                set
                {
                    if (value > 0)
                        id = value;
                    else
                        Console.WriteLine("failed");
                }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public Person(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public abstract string GetRole();

            public virtual void GetInfo()
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Name: {Name}");
            }
        }
    
    public class Student : Person
    {
        private string major;
        private double gpa;

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public double GPA
        {
            get { return gpa; }
            set
            {
                if (value >= 50 && value <= 100)
                    gpa = value;
                else
                    Console.WriteLine("Failed");
            }
        }

        public Student(int id, string name, string major, double gpa): base(id, name)
        {
            this.major = major;
            this.gpa = gpa;
        }

        public override string GetRole()
        {
            return "Student";
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Major: {Major}");
            Console.WriteLine($"GPA: {GPA}");
        }
    }
    public class Instructor : Person
    {
        private string department;
        private double salary;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    Console.WriteLine("failed");
            }
        }

        public Instructor(int id, string name, string department, double salary)
            : base(id, name)
        {
            this.department = department;
            this.salary = salary;
        }

        public override string GetRole()
        {
            return "Instructor";
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Student(1, "slsabeel", "Computer Eng", 75);
            Person p2 = new Instructor(2, "Dr. Ali", "Os", 1200);

           
            Console.WriteLine( p1.GetRole());
            p1.GetInfo();

            Console.WriteLine("\n");
            Console.WriteLine(p2.GetRole());
            p2.GetInfo();

            Console.ReadLine();
        
    }
    }
}
