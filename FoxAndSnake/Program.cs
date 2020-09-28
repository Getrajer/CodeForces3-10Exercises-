using System;

namespace FoxAndSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);

            int c = 0;
            bool r = true;

            char[,] snake = new char[a, b];


            for(int i = 0; i < a; i++)
            {
                if(c == 0)
                {
                    for(int j = 0; j < b; j++)
                    {
                        snake[i, j] = '#';
                    }
                    c++;
                }
                else if(c == 1)
                {
                    if (r)
                    {
                        for(int j = 0; j < b - 1; j++)
                        {
                            snake[i, j] = '.';
                        }
                        snake[i, b - 1] = '#';
                        c = 0;
                        r = false;
                    }
                    else
                    {
                        snake[i, 0] = '#';
                        for (int j = 1; j < b; j++)
                        {
                            snake[i, j] = '.';
                        }
                        c = 0;
                        r = true;
                    }
                }
            }


            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    Console.Write(snake[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
