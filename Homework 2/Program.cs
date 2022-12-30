using System;

namespace Homework_2
{
    // Ввести три числа и получить на экране значение суммы и произведения этих чисел
    
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введите первое число");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");

            thirdValue = double.Parse(Console.ReadLine());
            
            double sumResult = firstValue + secondValue + thirdValue;

            double multResult = firstValue * secondValue * thirdValue;

            Console.WriteLine("Сумма трех чисел " + sumResult);
            
            Console.WriteLine("Произведение трех чисел " + multResult);
        }   
    }
}
