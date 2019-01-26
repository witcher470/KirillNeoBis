using System;


namespace Zadanie_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите текст ");
                string stroka = Console.ReadLine();

                Console.WriteLine($"Количество символов в строке { stroka.Length}");
                if (stroka.Length >= 80)
                {




                    Console.WriteLine("НЕТ");
                }
                else
                    Console.WriteLine("ДА");


                
            }
        }
    }
}
