using System;

namespace Library1
{
    public struct BmiArrayWord
    {
        public static string Bmi(double weight, double height)
        {   
            var bmi = Math.Round((weight / (Math.Pow(height, 2))),2);
            return bmi.ToString();
        }

        public static string Array(string[] args)
        {
            int[] intArray = new int[10];
            Random rand = new Random();
            for (int x = 0; x < intArray.Length; x++)
            {
                intArray[x] = rand.Next(50);
            }
            Console.WriteLine("Неотсортированный массив: ");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }
            for (int i = 0; i < intArray.Length; i++)
                for (int j = i + 1; j < intArray.Length; j++)
                    if (intArray[i] > intArray[j])
                    {
                        int temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
            Console.WriteLine("\r\nОтсортированный массив: ");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine("\r\nМинимальное значение: " + intArray[0]);
            Console.WriteLine("Максимальное значение массива: " + intArray[intArray.Length - 1]);
            return intArray.ToString();
        }

        public static double Word(string str)
        {
            char[] arrayCharString = str.ToCharArray();
            for (int i = 0; i <arrayCharString.Length;i++)
            {
                char a = arrayCharString[i];
                if (char.IsSeparator(a) || char.IsPunctuation(a))
                {
                    arrayCharString[i] = ' ';
                }
            }
            string result = new string(arrayCharString);
            double averageValue = 0;
            result = string.Join(" ", result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            string[] arrayString = result.Split(" ");
            for (int i = 0; i< arrayString.Length; i++)
            {
                averageValue += arrayString[i].Length;
            }
            return Math.Round((averageValue / arrayString.Length),2);
        }
    }
}

