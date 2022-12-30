using System;

namespace Homework_3
{
    /* Написать простой конвертер валют 
     * (без возможности динамическогов выбора валюты пользователем)
     * Валюты заданы хардкодом и не изменяются. Тиа валют на выбор программиста
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double USDtoRub = 72.37;
            
            double USDtoByn = 2.53;
            
            double USD;

            Console.WriteLine("Введите сумму в USD");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD в RUB = " + USD * USDtoRub);

            Console.WriteLine(USD + " USD в BYN = " + USD * USDtoByn);
        }
    }
}
