using System;

namespace ClassLibrary
{
    /// <summary>
    /// На основании принятых от пользователя данных производит вычисления
    /// </summary>
    public static class NumberAndSquare
    {
        /// <summary>
        /// Выводит строку 1,2...n.
        /// </summary>
        /// <param name="N"></param>
        public static void WriteNumber(this int N)
        {
            for (int i = 1; i <= N; i++)
            {
                Console.Write(
                    (i < N)
                        ? i + ", "
                        : i + ".");
            }
        }
        /// <summary>
        /// Выводит квадрат из * с отверстием по середине
        /// </summary>
        /// <param name="N"></param>
        public static void WriteSquare(this int N)
        {
            int center = N / 2;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(
                        (i == center && j == center)
                         ? "   "
                         : " * ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
   
    


            



        

 




