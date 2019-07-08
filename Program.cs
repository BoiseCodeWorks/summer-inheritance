using System;
using System.Collections.Generic;
using inheritance.Models;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Enemy> enemies = new List<Enemy>();
            MasterVampire drac = new MasterVampire(100, "Dracula", 17, 23);
            Vampire edward = new Vampire(10, "Edward", 4, 1);
            Orc grog = new Orc(80, "Grog", 15, 7);

            enemies.Add(drac);
            enemies.Add(grog);
            enemies.Add(edward);

            foreach (var enemy in enemies)
            {
                if (enemy is Orc)
                {
                    Orc e = (Orc)enemy;
                    if (e.HitPoints > 10)
                    {
                        e.Rage();
                    }
                }
                if (enemy is Vampire)
                {
                    System.Console.WriteLine("IT BITES YOU!!!!");
                }
                Console.WriteLine(enemy.Attack());
            }





        }
    }
}
