using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_tasks
{

    public class Employee
    {
        protected string Name;
        protected int BIRTH;
        protected int ID;

        public Employee() { }
        public Employee(string name, int birth, int id)
        {
            Name = name;
            BIRTH = birth;
            ID = id;
        }

        public virtual void welcome()
        {
            Console.WriteLine("wel");
        }

    }

    class Manager : Employee
    {
        public Manager(string name, int birth, int id) : base(name, birth, id)
        {

        }
        public override void welcome()
        {
            Console.WriteLine("welcome to Manager");
        }

        public void print()
        {

            int Age = (2022 - Convert.ToInt32(BIRTH));
            Console.WriteLine(Name + " " + Age + "  " + ID);
        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            Manager employee1 = new Manager("AHMAD", 2022 , 20012485);
            employee1.welcome();
            employee1.print();
            Console.WriteLine("enter your name");
            string _name = Console.ReadLine();
            Console.WriteLine("enter your birth-year");
             int _birth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your id");
            int _id = Convert.ToInt32(Console.ReadLine());
            Manager employee2 = new Manager(_name, _birth, _id);
            employee2.welcome();
            employee2.print();

        }
    }
}
