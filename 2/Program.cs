using System;
using LibraryBmiArrayWord;

namespace ConsoleProgram

{
    class Program
    {
        static void Main(string[] args)
        {
            Bmi();
            Console.WriteLine(BmiArrayWord.Array(args));
            Word();
        }

        private static void Word()
        {
            var str = GetStringFromUser("Введите строку: ");
            Console.WriteLine("Средняя длина слова равна " + BmiArrayWord.Word(str) + " символов");
        }

        private static void Bmi()
        {
            var weight = GetValueFromUser("Введите свой вес ");
            var height = GetValueFromUser("Введите свой рост ");
            Console.WriteLine("Ваш индкс массы тела состваляет " + BmiArrayWord.Bmi(weight, height) + "\n\r");
        }

        private static double GetValueFromUser(string message)
            {
                Console.WriteLine(message);
                return Convert.ToDouble(Console.ReadLine());
            }
            private static string GetStringFromUser(string message)
            {
                Console.WriteLine(message);
                return Convert.ToString(Console.ReadLine());
            }
    }
}

