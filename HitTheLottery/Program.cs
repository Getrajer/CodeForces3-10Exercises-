using System;

namespace HitTheLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            while(number != 0)
            {
                if(number - 100 >= 0)
                {
                    number -= 100;
                    c++;
                }
                else if(number - 20 >= 0)
                {
                    number -= 20;
                    c++;
                }
                else if(number - 10 >= 0)
                {
                    number -= 10;
                    c++;
                }
                else if(number - 5 >= 0)
                {
                    number -= 5;
                    c++;
                }
                else
                {
                    number -= 1;
                    c++;
                }
            }

            Console.WriteLine(c);
        }
    }
}
