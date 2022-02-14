using System;
using Aula_Csharp.Models;

namespace ProjetoHeroi
{
    class program
    {
        public static void Main(string[] args)
        {
            Hero hero = new Hero("Lupus", 50, "Gunslinger", 800, 1500, "SS");
            Hero Ninja = new Hero("Lass", 49, "Shinobi", 900, 12000, "S");
            Hero Fighter = new Hero("Jin", 85, "Illuminated",19000, 50000, "SSS");
            Hero Swordsman = new Hero("sieghart", 68, "Avatar",1000, 6000, "S+");

            Console.WriteLine(hero);
            Console.WriteLine(Ninja);
            Console.WriteLine(Fighter);
            Console.WriteLine(Swordsman);
            
        }
    }
}