internal class Program
{
    private static void Main(string[] args)
    {
        //task1
        static void sum_average()
        {
            float sum = 0;
            float avg = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                avg = sum / i;
            }

            Console.WriteLine(" the sum of nnmber is :" + sum);
            Console.WriteLine(" the sum of nnmber is :" + avg);

        }
        sum_average();

    
        //task2
        static void cube_of_number(int x, int y, int z, int r, int a)
        {
            Console.WriteLine(x * x * x);
            Console.WriteLine(y * y * y);
            Console.WriteLine(z * z * z);
            Console.WriteLine(r * r * r);
            Console.WriteLine(a * a * a);
        }
        cube_of_number(1, 2, 3, 4, 5);



        //task3
        static void Years()
        {
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            foreach (int y in years)
            {
                if (y > 1950)
                {
                    Console.Write(y + "\t \t \t \t");
                }
            }

        }
        Console.WriteLine("the years greater than 1950 : ");
        Years();

     
        //task4
        static void age_in_days(int ageinyears)
        {
            int ageindays = ageinyears * 365;
            Console.WriteLine("age in days : " + ageindays);
        }
        age_in_days(15);

        //task5
        int chickens;
        Console.Write("enter the number of chickens : ");
        chickens = Convert.ToInt32(Console.ReadLine());
        int cows;
        Console.Write("enter the number of  cows : ");
        cows = Convert.ToInt32(Console.ReadLine());
        int pigs;
        Console.Write("enter the number of  pigs : ");
        pigs = Convert.ToInt32(Console.ReadLine());

        static int animals(int chickens, int cows, int pigs)
        {
            return (chickens * 2) + (cows * 4) + (pigs * 4);
        }
        Console.WriteLine("The number of legs that can be counted among all his animals is: " + animals(chickens, cows, pigs));

        //task6

        static void success_login(string username, string pass)
        {
            string[] usernames = { "raghad", "alaa", "marah" };
            string[] passwords = { "raghad123", "alaa123", "marah123" };
            for (int i = 0; i < 3; i++)
            {
                if (username == usernames[i] && pass == passwords[i])
                {
                    Console.WriteLine("success login.welcome {0}", username);
                    break;
                }
                else if (i == 2)
                {
                    Console.WriteLine("login failed");
                }
            }

        }
        success_login("marah", "marah1263");

       
        //task7
        static int Power(int w)
        {
            return w * w;
        }

        Console.WriteLine("the power of w : " + Power(6));


        //task8

        static void leap_year(int year)
        {
            if (year < 2024 && year > 1900)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("{0} is a leap year.", year);
                }
                else
                {
                    Console.WriteLine("this is not leap year");
                }
            }
        }
        leap_year(2020);



        //task9
        int n;

        Console.WriteLine("Enter a positive  integer: ");
        n = Convert.ToInt32(Console.ReadLine());


        if (check_prime(n))
        {
            Console.WriteLine(n + " is a prime number.");
        }
        else
        {
            Console.WriteLine(n + " is not a prime number."); ;
        }

        bool check_prime(int n)
        {
            bool is_prime = true;

            // 0 and 1 are not prime numbers
            if (n == 0 || n == 1)
            {
                is_prime = false;
            }

            for (int i = 2; i <= n / 2; ++i)
            {
                if (n % i == 0)
                {
                    is_prime = false;
                    break;
                }
            }

            return is_prime;
        }

        //task10
        static int number_of_words(string sentence)
        {
            string[] slicer = sentence.Split(' ');
            int count = 0;
            foreach (string s in slicer)
                count++;

            return count;
        }
        Console.WriteLine("Enter a sentence ");
        string sentence = Console.ReadLine();
        Console.WriteLine(" Number of words in that sentence is " + number_of_words(sentence));
    }
}