namespace inheritance.Models
{
    class Vampire : Enemy
    {
        public void Regenerate()
        {
            HitPoints += 5;
            System.Console.WriteLine("regenerating!!!");
        }

        public override int Attack()
        {
            Regenerate();
            return Damage;
        }

        public Vampire(int hp, string name, int ac, int damage) : base(hp, name, ac, damage)
        {
        }
    }
}