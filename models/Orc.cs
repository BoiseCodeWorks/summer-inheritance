namespace inheritance.Models
{
    class Orc : Enemy
    {
        public void Rage()
        {
            System.Console.WriteLine("Raging!!!");
            Damage = Damage * 2;
        }

        public Orc(int hp, string name, int ac, int damage) : base(hp, name, ac, damage)
        {
        }
    }
}