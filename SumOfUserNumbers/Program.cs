using System;

namespace SumOfUserNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Сумма трех чисел
            //приложение предлагает пользователю ввести три числа и выводит на экран их сумму
            //исправленный до рабочего состояния код дает до 5 пунктов 
            int numbers = 0;
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter a number");
                numbers = Convert.ToInt32(Console.ReadLine());
                sum = numbers + sum;
            }

            Console.WriteLine($"Total: {sum}");
        }
    }
}
