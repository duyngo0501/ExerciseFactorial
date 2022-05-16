using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fact = 1, i = 1;
            do
            {
                Console.Write("Enter n to process: ");
                n = int.Parse(Console.ReadLine());


            }
            while (n < 0);
            if (n ==0)
            {
                Console.WriteLine("Factorial number of {0} is {1} ", n, fact);

            }  
            else
            {
                for (i = 1; i <= n;i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("Factorial number of {0} is {1}", n, fact);
            }
            Console.ReadKey();
        }
    }
}
