using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._11._2022
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("task1");
            Console.WriteLine("enter first number");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  second number");
            int  num2= Convert.ToInt32(Console.ReadLine());
            if (num1<= num2) { Console.WriteLine(num1); }
            else { Console.WriteLine(num2); }

          
            Console.WriteLine("task2");
            Console.WriteLine("enter sign number");
            int sign_num = Convert.ToInt32(Console.ReadLine());
            if (sign_num >= 0)
            { Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }

            Console.WriteLine("task3");


            Console.WriteLine("enter first number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third num");
            int num5 = Convert.ToInt32(Console.ReadLine());

            int[] array;
            array = new int[] { num3, num4, num5 };

            Array.Sort(array);
            Console.WriteLine(array.Reverse());
           


            Console.WriteLine("task4");

            Console.WriteLine("enter first number");
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second numbe");
            int num7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third numbe");
            int num8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter four  numbe ");
            int num9 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter five numbe");
            int num10 = Convert.ToInt32(Console.ReadLine());


            int[] array2;
            array2 = new int[] { num6, num7, num8, num9, num10 };
            Array.Sort(array2);

            Console.WriteLine(array2[4]);

          

            Console.WriteLine("task5");



            Console.WriteLine("input hours");
            double hour = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(hour * 0.621371);



           

            Console.WriteLine("task6");

            Console.WriteLine("input hours:");
            int hour2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input minutes");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.Write(((hour2 * 60) + minute));

         

            Console.WriteLine("task7");

            Console.WriteLine("input minutes:");
            int total = Convert.ToInt32(Console.ReadLine());
            int h = (total / 60);
            int m = (total % 60);
            Console.WriteLine("hours" + h + "    mintues" + m);


           

            Console.WriteLine("task8");

            string[] arr1 = { "eman", "ruba", "tima", "noor" };
            int l = arr1[0].Length;
            int l2 = arr1[1].Length;
            int l3 = arr1[2].Length;
            int l4 = arr1[3].Length;
            int[] arr = { l, l2, l3, l4 };
            Array.Sort(arr);
            int min = arr[0];
            Console.WriteLine(min);

            Console.WriteLine(arr1[0].Substring(0, min));
            Console.WriteLine(arr1[1].Substring(0, min));
            Console.WriteLine(arr1[2].Substring(0, min));
            Console.WriteLine(arr1[3].Substring(0, min));






        }
    }
}
