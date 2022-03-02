using System;

namespace ClassLibrary1
{
    public static class StringLibrary
    {

        public static void WriteNumber(this int N)
        {
            for (int i = 1; i <= N; i++)
                if (i < N)
                {
                    Console.Write(i + ", ");
                }

                else
                {
                    Console.Write(i + ".");
                }
        }

        public static void WriteSqr(this int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i == N/2)&& (j == N / 2))
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(" * ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}

            



        

 




