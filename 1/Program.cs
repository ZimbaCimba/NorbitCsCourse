using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = GetValueFromUser("Введите целое положительное число:" );
            N.WriteNumber();
            N = GetValueFromUser("Введите длину стороны квадрата: ");
            N.WriteSquare();
        }

        private static int GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());  
        }
    }
}
