using System;

namespace NovSec
{
    internal class Program
    {
        private const string QuitString = "q";

        public static void Main()
        {
            Greeting();

            var inputLine = Console.ReadLine();
            if (inputLine == QuitString || !int.TryParse(inputLine, out var inputNumber))
            {
                return;
            }

            var factorial = CalculateFactorial(inputNumber);
            var sumOfNumbers = CalculateSumOfNumbers(inputNumber);
            var maxEvenNumber = CalculateMaxEvenNumber(inputNumber);

            PrintResults(factorial, inputNumber, sumOfNumbers, maxEvenNumber);

            Console.ReadLine();
        }

        private static void Greeting()
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа!");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Для выхода из программы введите \"{QuitString}\" ");
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Пожалуйста, введите число: ");
        }

        private static int CalculateFactorial(int inputNumber)
        {
            var factorial = 1;
            for (var i = 1; i <= inputNumber; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static int CalculateSumOfNumbers(int inputNumber)
        {
            return (1 + inputNumber) * inputNumber / 2;
        }

        private static int CalculateMaxEvenNumber(int inputNumber)
        {
            return inputNumber - inputNumber % 2;
        }

        private static void PrintResults(int factorial, int maxNumber, double sumOfNumbers, int maxEvenNumber)
        {
            Console.WriteLine("Факториал равен: " + factorial);
            Console.WriteLine($"Сумма от 1 до {maxNumber} равна: " + sumOfNumbers);
            Console.WriteLine($"Максимальное четное число в пределах {maxNumber} равно: " + maxEvenNumber);
        }
    }
}