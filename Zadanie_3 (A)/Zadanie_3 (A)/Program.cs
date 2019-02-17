using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3__A_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string ");
            string str = Console.ReadLine();
            Console.Write("enter maximum string length ");
            int maxlength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(truncate(str, maxlength));

            Console.ReadKey();
        }
        static string truncate(string a, int b)
        {

            if (a.Length > b)
            {
                a = a.Remove(b-3);
                a = a + "...";
            }
            else if (a.Length == b)
            {
                a = a.Remove(b - 3, 3);
                a = a + "...";
            }
            else if (a.Length<b)
            {
                return a;
                
            }
            return a;
        }
    }
}
