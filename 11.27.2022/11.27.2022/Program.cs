using Microsoft.VisualBasic;

internal class Program
{
    class Person
    {

                double age;
                string gender;
                string name;
                string email;
                int id;
                string phone;

        public void age1(int age)
        {
            if (age >= 18 && age <= 60)
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("check your age");
            }
        }


        public void gender1(string gender)
        {
            if (gender == "female")
            {
                Console.WriteLine("female");

            }
            else
            {
                Console.WriteLine("male");
            }


        }


        public void name1(string t)
        {
            name = t;
            Console.WriteLine(name);
        }


        public void email1(string e)
        {

            email = e; 
            Console.WriteLine(email);
        }

        public void chphone(string eph)
        {

            phone = eph;

           

            string x = phone.Substring(0, 3);
            Console.WriteLine(x);
            if (x == "078" || x== "079" || x == "077")
            {
                Console.WriteLine(phone);
            }
            else { Console.WriteLine(" phone number"); }
        }


        public void printID(int w)
        {
            id = w;
            Console.WriteLine(id);
        }


        static void Main(string[] args)
        {
            Person info = new Person();

            Console.WriteLine(" age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" your age");
            info.age1(age);





          

            Console.WriteLine(" gender");
            string gender = Console.ReadLine();
            info.gender1(gender);


            Console.WriteLine("print Name");

            Console.WriteLine("please enter your NAME");
            string name1 = Console.ReadLine();
            info.name1(name1);



            Console.WriteLine("print emaill");

            Console.WriteLine("enter  email");
            string email = Console.ReadLine();
            info.email1(email);



            Console.WriteLine("phone");

            Console.WriteLine(" enter phone");
            string phone = Console.ReadLine();
            info.chphone(phone);




            Console.WriteLine(" ID");

            Console.WriteLine("enter ID");
            int id = Convert.ToInt32(Console.ReadLine());
            info.printID(id);
        }
    }
}