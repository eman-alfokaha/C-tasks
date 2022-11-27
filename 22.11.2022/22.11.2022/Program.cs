internal class Program
{
    private static void Main(string[] args)
    {
        //task1: Correct the syntax error:
        //string[] ARR = [1, 7  9  45, ]
        //string[] ARR = { 1, 7, 9, 45};

        //int arr2 =["Str" "alex", "moh"
        //int[] arr2 ={"Str", "alex", "moh"};

        //string arr3 = 'the','fox' 'over' lazy, 'dog',]
        //string[] arr3 = { "the","fox", "over","lazy", "dog"};


        //task 2: What the index of "Banana","Tomato"?
        //String [ ] fruits =["Tomato", "Banana", "Watermelon"]
        //correct: String[] fruits = { "Tomato", "Banana", "Watermelon" };
        //index of "Banana" = 1
        //index of "Tomato"=0

        //task3: Create an multiple arrays that represents your:
       
        string[] f = { "Pizza", "Ice Cream", "Fried Chicken", "Bacon" };
        string[] S = { "Tennis", "Football", "Soccer" };
        string[] M = { "Lilo & Stitch", "Wreck-It-Ralph", "Frozen" };

        for (int x = 0; x < f.Length; x++)
        {
            Console.WriteLine(f[x]);
        }
        foreach (string y in f)
        {
            Console.WriteLine(y);
        }
        for (int z = 0; z < S.Length; z++)
        {
            Console.WriteLine(S[z]);
        }
       
        foreach (string w in S)
        {
            Console.WriteLine(w);
        }
        
        for (int q = 0; q < M.Length; q++)
        {
            Console.WriteLine(M[q]);
        }
   

        foreach (string e in M)
        {
            Console.WriteLine(e);
        }


        
        Console.WriteLine("Enter three numbers seperated by comma ");

        string num = Console.ReadLine();

        string[] nums = num.Split('/');

        int suum = 0;

        foreach (string p in nums)
        {
            suum += Convert.ToInt32(p);
        }

        Console.WriteLine("sum:" + suum);


        
        //task 5 : Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
        int i, n, summ = 0;
        Console.WriteLine("Input number of terms : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The odd numbers are :");
        for (i = 1; i <= n; i++)
        {
            Console.Write("{0} ", 2 * i - 1);
            summ += 2 * i - 1;
        }
        Console.WriteLine("The Sum of odd Natural Number upto {0} terms : {1} ", n, summ);

     
        //task6: Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
        int b = 3;
        for (int d = 1; d <= 4; d++)
        {
            for (int m = b; m >= 1; m--)
            {
                Console.Write(" ");

            }
            for (int k = 1; k <= d; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            b--;
        }

        //task7: Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
        int o = 3;
        for (int l = 1; l <= 4; l++)
        {
            for (int v = o; v >= 1; v--)
            {
                Console.Write(" ");

            }
            for (int k = 1; k <= l; k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            o--;
        }
    }
}