using System;

namespace Zadanie_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x;
            Console.Write("Введите целое число Х ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x >= 1 && x <= 1000) // Проверка,находится ли число в диапазоне от 1 до 1000
            {
                for (int i = 0; i <= x; i++)
                {
                    if (i % 2 == 1) // нахождение нечётных чисел
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Введите число в диапазоне от 1 до 1000");
                 
            }
        }
    }
}
