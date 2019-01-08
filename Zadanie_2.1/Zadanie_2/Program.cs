//Задание 2.1
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество рабчих "); 
            int CountOfWorkers = Convert.ToInt32(Console.ReadLine()); //Ввод переменной CountOfWorkers

            Console.Write("Введите количество рабочих часов в 1 месяце ");   
            int CountOfHours = Convert.ToInt32(Console.ReadLine());   //Ввод переменной CountOfHours

            Console.Write("Введите зарплату за час ");  
            double DollarsPerHour = Convert.ToDouble(Console.ReadLine()); //Ввод переменной DollarsPerHour

            double Salary = CountOfHours * DollarsPerHour;   //Вычисление Salary

            Console.WriteLine($"NUMBER = {CountOfWorkers}"); //Вывод количества рабочих в консоли
            Console.WriteLine($"SALARY = U$ {Salary}"); //Вывод зарплаты рабочего за месяц
            Console.ReadKey();

        }
    }
}
