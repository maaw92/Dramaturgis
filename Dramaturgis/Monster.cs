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
        public int healthPoints { get; set; }
        public int manaPoints { get; set; }
        public int attackDamageValue { get; set; }
        public int defenseValue { get; set; }

        void attack()
        {

        }
        void ITakeDamage.takeDamageFromEnemy()
        {

        }
    }
}
