///Задание №1

using System;
using System.Linq;

namespace Ukhova_CSharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите числа и/или имена, разделив их пробелом (дробные числа пишите с запятой, например 17,5):");
            string input = Console.ReadLine();

            string[] inputs = input.Split(' ');

            foreach (string inputItem in inputs)
            {
                if (double.TryParse(inputItem, out double number))
                {
                    Console.Write($"{number}: ");
                    if (number > 7)
                    {
                        Console.WriteLine("Привет");
                    }
                    else
                    {
                        Console.WriteLine("Это число меньше или равно 7");
                    }
                }
                else if (inputItem == "Вячеслав")
                {
                    Console.WriteLine("Привет, Вячеслав");
                }
                else
                {
                    Console.WriteLine("Нет такого имени");
                }
            }

            Console.WriteLine("\nЭлементы массива кратные 3:");
            double[] correctAnswer = inputs
                .Where(inputItem => double.TryParse(inputItem, out double _))
                .Select(inputItem => double.Parse(inputItem))
                .ToArray();

            double[] divisors = MultiplesOf3(correctAnswer);

            foreach (double multiple in divisors)
            {
                Console.WriteLine(multiple);
            }
        }

        static double[] MultiplesOf3(double[] numbers)
        {
            int count = 0;
            foreach (double num in numbers)
            {
                if (num % 3 == 0)
                {
                    count++;
                }
            }

            double[] divisors = new double[count];
            int index = 0;

            foreach (double num in numbers)
            {
                if (num % 3 == 0)
                {
                    divisors[index] = num;
                    index++;
                }
            }

            return divisors;
        }
    }
}

/// Задание №2
/// Последовательность скобок [((())()(())]] является неправильной, так как она содержит неравное количество квадратных скобок, 
/// в данном случае дополнительную закрывающую квадратную скобку ] в конце.
/// У неё нет соответствующей открывающей парной квадратной скобки. Чтобы исправить эту ошибку, 
/// нужно удалить эту дополнительную закрывающую скобку, чтобы правильно сбалансировать скобки. 
/// Исправленная последовательность будет выглядеть как [((())()(())]).