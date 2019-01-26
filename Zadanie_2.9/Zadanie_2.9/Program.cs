using System;


namespace Zadanie_2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int R, G, B;
                Console.Write("Выберите min, mean или eye :");
                string vibor = Console.ReadLine();
                switch (vibor)
                {                   
                    case "min":
                        Console.WriteLine("Вы выбрали min");
                        Console.Write("Введите R ");
                        R = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите G ");
                        G = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите B ");
                        B = Convert.ToInt32(Console.ReadLine());
                        if (R < G && R<B)
                            {
                            Console.WriteLine($"Caso #1: {R}");
                        }
                        else if (G<R && G<B)
                        {
                            Console.WriteLine($"Caso #1: {G}");                       
                        }
                        else
                        {
                            Console.WriteLine($"Caso #1: {B}");                           
                        }
                        break;
                    case "mean":
                        Console.WriteLine("Вы выбрали mean");
                        Console.Write("Введите R ");
                        R = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите G ");
                        G = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите B ");
                        B = Convert.ToInt32(Console.ReadLine());
                        int mean = (R + G + B) / 3;
                        Console.WriteLine($"Caso #2: {mean}");

                        break;
                    case "eye":
                        Console.WriteLine("Вы выбрали eye");
                        Console.Write("Введите R ");
                        R = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите G ");
                        G = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите B ");
                        B = Convert.ToInt32(Console.ReadLine());
                        double eye = 0.3 * R + 0.59 * G + 0.11 * B;
                        eye = Math.Truncate(eye);
                        Console.WriteLine($"Caso #3: {eye}");
                        break;
                    default:
                        Console.WriteLine("Вы неправильно ввели данные, попробуйте ещё раз");
                        break;
                }


            }
        }
    }
}
