namespace Aula_Csharp.Models
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Hp, int Mp, string Stats)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
            this.Stats = Stats;

        }

        public string Name;
        public int Level;
        public string HeroType;
        public string Stats;
        public int Hp;
        public int Mp;



        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " +  this.Hp + " " + this.Mp + " " + this.Stats;
            
        }
        
        public string Attack()
        {
            return this.Name + "Atirou com sua pistola";
        }
        
    }
}