using System;

namespace Homework_5
{
    // Написать простой калькулятор, который умеет выполнять действия: сложение, вычитание, умножение и деление
   
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double firstValue, secondValue;
                string operation;

                try
                {
                    Console.WriteLine("Введите первое число");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Внимание! Ошибка при преобразовании строки в число!");
                    Console.ReadLine();
                    continue;
                }
                
                Console.WriteLine("Введите тип операции: | + | - | * | / |");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;

                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;

                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;

                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine("Ошибка! Деление на 0 невозможно!");
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;

                    default:
                        Console.WriteLine("Ошибка! Неизвестный тип операции!");
                        break;
                }

                Console.ReadLine();
            }
            
        }
    }
}
