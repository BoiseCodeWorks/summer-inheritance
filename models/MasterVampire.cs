namespace inheritance.Models
{
    class MasterVampire : Vampire
    {

        public override int Attack()
        {
            Regenerate();
            Regenerate();
            return Damage * 2;
        }





        public MasterVampire(int hp, string name, int ac, int damage) : base(hp, name, ac, damage)
        {
        }
    }
}