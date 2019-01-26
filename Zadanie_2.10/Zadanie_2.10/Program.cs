using System;

namespace Zadanie_2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            
            Console.Write("Введите количество тестовых попыток ");
            int test = Convert.ToInt32(Console.ReadLine());
            if (test < 2000 && test >= 0)
            {

                for (int turn = 0; turn < test; turn++)
                {
                        Console.Write("Введите ваше число ");
                        int leds = 0;
                        string chislo = Console.ReadLine();
                        for (int i = 0; i < chislo.Length; i++)
                        {
                            if (chislo[i] == '1') leds = leds + 2;
                            if (chislo[i] == '2') leds = leds + 5;
                            if (chislo[i] == '3') leds = leds + 5;
                            if (chislo[i] == '4') leds = leds + 4;
                            if (chislo[i] == '5') leds = leds + 5;
                            if (chislo[i] == '6') leds = leds + 6;
                            if (chislo[i] == '7') leds = leds + 3;
                            if (chislo[i] == '8') leds = leds + 7;
                            if (chislo[i] == '9') leds = leds + 6;
                            if (chislo[i] == '0') leds = leds + 6;

                        }
                        Console.WriteLine($"{leds} leds");
                        

                    }
                }
            else
            {
                Console.WriteLine("Количество попыток должно быть больше 0 и меньше 2000");              
                
            }
            }

        }
    }
}
