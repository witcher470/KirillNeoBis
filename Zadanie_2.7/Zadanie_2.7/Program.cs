using System;

namespace Zadanie_2._7
{
    class Program
    {

        static void Main(string[] args)
        {
      
            Console.Write("Введите порядок матрицы ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Матрица не может иметь порядок 0");
                goto A;
            }
            else
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                       int  x = i;
                        if (j < x) x = j;
                        if (n - i + 1 < x) x = n - i + 1;
                        if (n - j + 1 < x) x = n - j + 1;
                        Console.Write(x);
                        if (j < n) Console.Write(' ');
                        else Console.Write('\n');
                    }
                }
            Console.Write('\n');
         

        } 
    }

}
