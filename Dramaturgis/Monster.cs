using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dramaturgis 
{
    abstract class Monster : ITakeDamage
    {
        public string monsterName { get; set; }
        public double healthPoints { get; set; }
        public int manaPoints { get; set; }
        public int attackDamageValue { get; set; }
        public int defenseValue { get; set; }

        void attack(ITakeDamage player)
        {
            Random random = new Random();
            int totalDamage = random.Next(0, this.attackDamageValue);
            player.takeDamageFromEnemy(totalDamage);
            
        }
        void ITakeDamage.takeDamageFromEnemy(int damageTaken)
        {
            this.healthPoints -= damageTaken * 0.1 * defenseValue; 
        }
    }
}
