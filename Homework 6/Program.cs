using System;

namespace Homework_6
{
    /* Написать программу, которая будет считать количество четных и нечетных чисел в диапозоне, а также выводить сумму этих чисел 
     * (диапозон устанавливает пользователь)
     */
    
    internal class Program
    {
        static void Main(string[] args)
        {
            uint evenNumbersCount = 0; // четные числа
            uint oddNumbersCount = 0;  // нечетные числа        

            int evenNumbersSum = 0;
            int oddNumbersSum = 0;
            
            Console.WriteLine("Введите первое число границы диапозона");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число границы диапозона");
            int limitValue = int.Parse(Console.ReadLine());

            while (currentValue <= limitValue)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersSum += currentValue;
                    evenNumbersCount++;
                }
                else
                {
                    oddNumbersSum += currentValue;
                    oddNumbersCount++;
                }
                currentValue++;
            }
            
            Console.WriteLine("Количество четных чисел: " + evenNumbersCount);
            Console.WriteLine("Количество нечетных чисел: " + oddNumbersCount);
            Console.WriteLine("Сумма четных чисел: " + evenNumbersSum);
            Console.WriteLine("Сумма нечетных чисел: " + oddNumbersSum);
            Console.ReadLine();

        }
    }
}
