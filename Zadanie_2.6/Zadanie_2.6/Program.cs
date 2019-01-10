using System;
namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            A:
            Console.Write("Введите порядковый номер числа Фибоначи ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Fib ({m}) = {Fibonachi(m)}");
            Console.ReadKey();
            Console.Clear();
            goto A;
             int Fibonachi(int n)
            {                
                if (n == 0)
                {
                    return 0;
                }
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return Fibonachi(n - 1) + Fibonachi(n - 2);
                }
            }
        }
    }
}