using System;

namespace VasyaTheHipster
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);

            int r1 = 0;
            int r2 = 0;

            if(a > b)
            {
                r1 = b;

                if((a-b) % 2 == 0)
                {
                    r2 = (a - b) / 2;
                }
                else
                {
                    r2 = (a - b - 1) / 2;
                }
            }
            else if(a < b)
            {
                r1 = a;

                if ((b - a) % 2 == 0)
                {
                    r2 = (b - a) / 2;
                }
                else
                {
                    r2 = (b - a - 1) / 2;
                }

            }
            else
            {
                r1 = a;
                r2 = 0;
            }


            Console.WriteLine(r1 + " " + r2);

        }
    }
}
