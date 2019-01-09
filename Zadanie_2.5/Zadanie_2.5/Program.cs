using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random(); //объявление экземпляра класса генерации рандомных чисел
            for (int i = 0; i < array.Length; i++) //заполнение массива
            {
                array[i] = rand.Next(-100, 100);
                Console.WriteLine($"X[{i}] {array[i]}");
                if (array[i] <= 0)
                {
                    array[i] = 1;
                }
            }
            Console.WriteLine("Изменённый массив:");
                for (int i = 0; i < array.Length; i++) // замена отрицательных и нулевых элементов массива
            {
                Console.WriteLine($"X[{i}] {array[i]}");
                if (array[i] <= 0)
                {
                    array[i] = 1;
                }               
            }
            Console.ReadKey();
        }
    }
}
