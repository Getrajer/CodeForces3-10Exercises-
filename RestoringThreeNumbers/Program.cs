using System;

namespace RestoringThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int[] numbers = new int[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                numbers[i] = Convert.ToInt32(input[i]);
            }

            int max = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            string solution = "";

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] != max)
                {
                    int r = max - numbers[i];
                    solution += r.ToString() + ' ';
                }
            }

            Console.WriteLine(solution);

        }
    }
}
