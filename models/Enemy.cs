namespace inheritance.Models
{
    abstract class Enemy
    {
        internal int HitPoints { get; set; }
        public string Name { get; set; }
        public int ArmorClass { get; set; }
        public int Damage { get; set; }

        public void TakeDamage(int attack, int damage)
        {
            if (attack > ArmorClass)
            {
                HitPoints -= damage;
            }
        }

        public virtual int Attack()
        {
            System.Console.WriteLine("Attacking");
            return Damage;
        }

        public Enemy(int hp, string name, int ac, int damage)
        {
            HitPoints = hp;
            Name = name;
            ArmorClass = ac;
            Damage = damage;
        }
    }
}