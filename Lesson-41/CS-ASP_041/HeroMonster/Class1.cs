using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonster
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            //Random random = new Random();
            //int damage = random.Next(this.DamageMaximum);

            dice.Sides = this.DamageMaximum;
            return dice.Roll();
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }

    public class Dice
    {
        public int Sides { get; set; }

        Random random = new Random();
        public int Roll()
        {
            return random.Next(this.Sides);
        }
    }
}
