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

            int evenNumbersSumm = 0;
            int oddNumbersSumm = 0;
            
            Console.WriteLine("Введите первое число границы диапозона");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число границы диапозона");
            int limitValue = int.Parse(Console.ReadLine());

            while (currentValue <= limitValue)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersSumm += currentValue;
                    evenNumbersCount++;
                }
                else
                {
                    oddNumbersSumm += currentValue;
                    oddNumbersCount++;
                }
                currentValue++;
            }
            
            Console.WriteLine("Количество четных чисел: " + evenNumbersCount);
            Console.WriteLine("Количество нечетных чисел: " + oddNumbersCount);
            Console.WriteLine("Сумма четных чисел: " + evenNumbersSumm);
            Console.WriteLine("Сумма нечетных чисел: " + oddNumbersSumm);
            Console.ReadLine();

        }
    }
}
