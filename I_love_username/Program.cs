using System;

namespace I_love_username
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input = Console.ReadLine().Split(); 

            int[] numbers = new int[n];
            int max = 0;
            int min = 0;
            int amazing = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(input[i]);

                if (i == 0)
                {
                    max = numbers[i];
                    min = numbers[i];
                }
                else
                {
                    for(int j = i; j >= 0; j--)
                    {
                        if(max < numbers[j])
                        {
                            max = numbers[j];
                            amazing++;
                        }

                        if(min > numbers[j])
                        {
                            min = numbers[j];
                            amazing++;
                        }
                    }
                }

            }


            Console.WriteLine(amazing);


        }
    }
}
