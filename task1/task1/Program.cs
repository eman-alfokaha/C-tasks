using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            Console.Write("enter your name");
            Console.ReadLine();
            //task2

            double sal = 23.7;
            string name1 = "eman";
            char firstchare = 'e';
            bool pass = true;
            int age = 23;
            const string name3 = "tima";
            Console.WriteLine(sal);
            Console.WriteLine(name1);
            Console.WriteLine(firstchare);
            Console.WriteLine(pass);
            Console.WriteLine(name3);

            //task3
            string[] car = { "bmw", "fored", "marseds" };
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);

            //task4
            string[] info = { "Input your firstname: Sami", "Input your lastname: Ali", "Input your year of birth: 1999", "Sami Ali 1999" };
            Console.WriteLine(info[0]);
            Console.WriteLine(info[1]);
            Console.WriteLine(info[2]);


            //Task5
            int[] number1 = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(number1);


            //Task6
            int []num = { 1, 2, 3, 4 };
            Console.WriteLine(num[0] + num[1] + num[2] + num[3]);







        }
    }
}
