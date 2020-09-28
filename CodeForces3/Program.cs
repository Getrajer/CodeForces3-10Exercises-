using System;

namespace CandiesAndTwoSisters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            long[] results = new long[n];

            for(int i = 0; i < n; i++)
            {
                long number = Convert.ToInt32(Console.ReadLine());

                if(number%2 == 0)
                {
                    long t = (number / 2) - 1;
                    results[i] = t;
                }
                else
                {
                    long t = number / 2;
                    results[i] = t;
                }
            }


            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}
