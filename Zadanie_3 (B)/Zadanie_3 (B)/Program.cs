using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3__B_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string ");
            string str = Console.ReadLine();
            Console.WriteLine(extractCurrencyValue(str));
            Console.ReadKey();
        }
        static string extractCurrencyValue(string a)
        {
            if (a[0] == '$')
            {
                a = a.Trim('$');
                return a;
            }
            else
            {
                Console.WriteLine("wrong format");

            }
            return " ";
            
        }
    }
}