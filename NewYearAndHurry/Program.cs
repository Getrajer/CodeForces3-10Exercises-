using System;

namespace NewYearAndHurry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int p = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);
            int time = 240;

            bool enoughTime = true;
            int i = 1;
            int finished = 0;
            
            while (enoughTime)
            {
                if(time - (i * 5) >= m && p != 0)
                {
                    time -= i * 5;
                    i++;
                    p--;
                    finished++;
                }
                else
                {
                    enoughTime = false;
                }
            }

            Console.WriteLine(finished);

        }
    }
}
