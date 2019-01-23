using System;

namespace Zadanie2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Выберите номер товара ");
            int kod = Convert.ToInt32(Console.ReadLine());
            int CountOfProducts;
            Double TotalPrice;
            
            switch(kod)
            {
                case 0:
                    break;

                case 1:
                    Console.WriteLine("Вы выбрали товар № 1\nВыберите количество товара ");
                    CountOfProducts = Convert.ToInt32(Console.ReadLine());
                    TotalPrice = 4 * CountOfProducts;
                    Console.WriteLine($"Total: R$ {TotalPrice} ");
                    Console.WriteLine("Для выхода из программы нажмите 0");
                    

                case 2:
                    Console.WriteLine("Вы выбрали товар № 2\nВыберите количество товара");
                    CountOfProducts = Convert.ToInt32(Console.ReadLine());
                    TotalPrice= 4.50 * CountOfProducts;
                    Console.WriteLine($"Total: R$ {TotalPrice}");
                    Console.WriteLine("Для выхода из программы нажмите 0");
                   

                case 3:
                    Console.WriteLine("Вы выбрали товар № 3\nВыберите количество товара");
                    CountOfProducts = Convert.ToInt32(Console.ReadLine());
                    TotalPrice = 5 * CountOfProducts;
                    Console.WriteLine($"Total: R$ {TotalPrice}");
                    Console.WriteLine("Для выхода из программы нажмите 0");
                   

                case 4:
                    Console.WriteLine("Вы выбрали товар № 4\nВыберите количество товара");
                    CountOfProducts = Convert.ToInt32(Console.ReadLine());
                    TotalPrice = 2 * CountOfProducts;
                    Console.WriteLine($"Total: R$ {TotalPrice}");
                    Console.WriteLine("Для выхода из программы нажмите 0");
                  

                case 5:
                    Console.WriteLine("Вы выбрали товар № 5\nВыберите количество товара");
                    CountOfProducts = Convert.ToInt32(Console.ReadLine());
                    TotalPrice = 1.50 * CountOfProducts;
                    Console.WriteLine($"Total: R$ {TotalPrice}");
                    Console.WriteLine("Для выхода из программы нажмите 0");
                   

                default:
                    Console.WriteLine("Такого товара в списке нет");
                    Console.WriteLine("Для выхода из программы нажмите 0");
                    
            }
        }
    }
}
