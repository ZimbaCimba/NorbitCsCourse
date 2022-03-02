using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            N.WriteNumber();

            Console.WriteLine(" ");
            Console.WriteLine("Введите длину стороны квадрата: ");
            N = Convert.ToInt32(Console.ReadLine());
            N.WriteSqr();
        }
    }
}
