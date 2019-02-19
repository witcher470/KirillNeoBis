using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._2__B_
{
 
    class Animals
    {
        public string name;
        public string WayOfEating;
        public int weight;
        public string habitat;
        public void InfoAnimal()
        {
            Console.WriteLine($"Название: {name} Способ питания: { WayOfEating}  Вес: { weight}  Среда обитания: {habitat}");
        }
        
        
            public void Predator()
            {
                if(WayOfEating == "Хищник")
                {
                    Console.WriteLine($"{name } - Хищник");
                }
            else
            {
                Console.WriteLine($"{name} - Травоядное");
            }
            }
        
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animals Animal_1 = new Animals();
            Animal_1.name = "Лев";
            Animal_1.WayOfEating = "Хищник";
            Animal_1.weight = 190;
            Animal_1.habitat = "Африка и Азия";
            Animal_1.InfoAnimal();
            Animal_1.Predator();



            Animals Animal_2 = new Animals();
            Animal_2.name = "Слон";
            Animal_2.WayOfEating = "Травоядное";
            Animal_2.weight = 6000;
            Animal_2.habitat = "Африка и Азия";
            Animal_2.InfoAnimal();
            Animal_2.Predator();

            Animals Animal_3 = new Animals();
            Animal_3.name = "Кенгуру";
            Animal_3.WayOfEating = "Травоядное";
            Animal_3.weight = 30;
            Animal_3.habitat = "Австралия, Новая Гвинея и Тасмания ";
            Animal_3.InfoAnimal();
            Animal_3.Predator();

            Animals Animal_4 = new Animals();
            Animal_4.name = "Белый медведь";
            Animal_4.WayOfEating = "Хищник";
            Animal_4.weight = 400;
            Animal_4.habitat = "Район Северного Ледовитого океана";
            Animal_4.InfoAnimal();
            Animal_4.Predator();
            Console.ReadKey();
        }

        
    }

}
