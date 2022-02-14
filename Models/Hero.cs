namespace Aula_Csharp.Models
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, string Stats)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Stats = Stats;


        }

        public string Name;
        public int Level;
        public string HeroType;

        public string Stats;



        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + "" + this.Stats;
            
        }
        
        public string Attack()
        {
            return this.Name + "Atirou com sua pistola";
        }
        
    }
}