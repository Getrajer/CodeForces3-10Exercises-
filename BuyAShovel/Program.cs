using System;

namespace BuyAShovel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int price = Convert.ToInt32(input[0]);
            int change = Convert.ToInt32(input[1]);

            bool paid = false;

            int curentPrice = price;
            int items = 1;

            while (paid == false)
            {
                if (curentPrice % 10 != 0 && (curentPrice - change) % 10 != 0)
                {
                    items++;
                    curentPrice += price;
                }
                else
                {
                    paid = true;
                }
            }

            Console.WriteLine(items);
        }
    }
}
