using System;

namespace RemoveSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] results = new string[n];


            for(int g = 0; g < n; g++)
            {
                int arrLenght = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[arrLenght];

                string[] string_numbers = Console.ReadLine().Split();

                for(int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(string_numbers[i]);
                }

        
                for(int j = 1; j < numbers.Length; j++)
                {
                    if(numbers[0] - numbers[j] <= 1 && numbers[0] - numbers[j] >= -1)
                    {
                        int[] newarray = new int[numbers.Length - 1];
                        int c = 0;
                        j--;
                        for(int o = 0; o < numbers.Length; o++)
                        {
                            if(o != j)
                            {
                                newarray[c] = numbers[o];
                                c++;
                            }
                        }

                        numbers = newarray;
                    }
                    
                }

                if (numbers.Length == 1)
                {
                    results[g] = "YES";
                }
                else
                {
                    results[g] = "NO";
                }

            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(results[i]);
            }

        }
    }
}
