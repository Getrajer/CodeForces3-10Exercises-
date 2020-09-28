using System;
using System.Collections.Generic;

namespace BalancedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            for(int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            List<string> results = new List<string>();

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == 2)
                {
                    results.Add("NO");
                }
                else
                {
                    int sum1 = 0;
                    int[] temp = new int[numbers[i] / 2];
                    int num = numbers[i];
                    for (int j = temp.Length - 1; j >= 0; j--)
                    {
                        temp[j] = num;
                        sum1 += num;
                        num -= 2;
                    }
                    int[] temp2 = new int[temp.Length];

                    int sum2 = 0;
                    num = 1;
                    for(int j = 0; j < temp2.Length - 1; j++)
                    {
                        temp2[j] = num;
                        sum2 += num;
                        num += 2;
                    }

                    int test = temp[temp.Length - 1] + temp2[(temp2.Length / 2) - 1];

                    if(test + sum2 == sum1)
                    {
                        temp2[temp2.Length - 1] = test;
                        results.Add("YES");
                        string res = "";

                        for(int g = 0; g < temp.Length; g++)
                        {
                            string p1 = temp[g].ToString();
                            string p2 = " ";
                            string txt = p1 + p2;
                            res +=  txt;
                        }
                        res += ' ';

                        for (int g = 0; g < temp2.Length; g++)
                        {
                            string p1 = temp2[g].ToString();
                            string p2 = " ";
                            string txt = p1 + p2;
                            res += txt;
                        }

                        results.Add(res);
                    }
                    else
                    {
                        results.Add("NO");
                    }

                }
            }

            for(int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }

        }
    }
}
