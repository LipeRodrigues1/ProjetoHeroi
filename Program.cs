using System;
using Aula_Csharp.Models;

namespace ProjetoHeroi
{
    class program
    {
        public static void Main(string[] args)
        {
            Hero hero = new Hero("Lupus", 50, "Gunslinger", "SS");
            Hero Ninja = new Hero("Lass", 49, "Shinobi", "S");
            Hero Fighter = new Hero("Jin", 85, "Illuminated","SSS" );
            Hero Swordsman = new Hero("sieghart", 68, "Avatar", "S+");

            Console.WriteLine(hero);
            Console.WriteLine(Ninja);
            Console.WriteLine(Fighter);
            Console.WriteLine(Swordsman);
            
        }
    }
}