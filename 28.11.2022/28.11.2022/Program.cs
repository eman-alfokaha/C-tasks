using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tasks
{
    class car
    {
        public int Year { get; set; }
        public int Pallet_No { get; set; }
        public double Price { get; set; }
        public string Make { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public int l { get; set; }


        public car()
        {

        }
        public car(int year, int palletNo, double price, string carMake, string type, string model, string color)
        {
            Year = year;
            Pallet_No = palletNo;
            Price = price;
            this.Make = carMake;
            Type = type;
            Model = model;
            Color = color;
        }

        //method liter
        public void liter(int x = 10)
        {


            Console.WriteLine("The distance traveled in  = " + (x * 20));


        }
        //method start
        public void start()
        {
            Console.WriteLine("The car is start ");
        }
        //method stop
        public void stop()
        {
            Console.WriteLine("The car is stop ");
        }
        //method print
        public void print()
        {
            Console.WriteLine($"The Year of car : {Year} ");
            Console.WriteLine($"the model : {Model}");
            Console.WriteLine($" type : {Type} ");
            Console.WriteLine($" car make {Make} ");
            Console.WriteLine($" pallet number of car {Pallet_No} ");
            Console.WriteLine($"  price: {Price} ");
            Console.WriteLine($" car color :{Color} ");



        }
        class ford : car
        {
        }
         class Test
        {

            static void Main(string[] args)
            {

                Console.WriteLine("Enter the year of car");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the pallet number of car");
                int palletNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the price of car");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the car Make ");
                string carMake = Console.ReadLine();

                Console.WriteLine("Enter the type of car");
                string type = Console.ReadLine();

                Console.WriteLine("Enter the model of car");
                string model = Console.ReadLine();

                Console.WriteLine("Enter the color of car");
                string color = Console.ReadLine();

                car Car1 = new car(year, palletNo, price, carMake, type, model, color);
                Car1.start();
                Car1.stop();
                Car1.print();
                Car1.liter();

                ford car = new ford();

            }
        }

    }


}