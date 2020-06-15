using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Person
    {
        private string fiName;
        private string laName;

        public Person()
        {
            fiName = "And";
        }

        public Person(string Name, string Surname)
        {
            fiName = Name;
            laName = Surname;
        }

        public string FirstName
        {
            get
            {
                return fiName;
            }
            set
            {
                fiName = value;
            }
        }

        public string LastName
        {
            get
            {
                return laName;
            }
            set
            {
                laName = value;
            }
        }

        public void Display()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    class Employee : Person
    {
        private string Compa;

        public Employee(string name, string surname, string company) : base(name, surname)
        {
            Company = company;
        }

        public string Company
        {
            get { return Compa; }
            set { Compa = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person Pers = new Person("Чернов", "Алексей");
            Employee Empl = new Employee("Чайкин", "Степан", "Facebook");

            Pers.Display();
            Empl.Display();

            Console.ReadLine();
        }
    }
}
