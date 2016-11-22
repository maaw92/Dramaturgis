using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dramaturgis
{
    class Player : ITakeDamage
    {
        public string playerName { get; set; }
        public double healthPoints { get; set; }             
        public int manaPoints { get; set; }           
        public int attackValue { get; set; }
        public int defenseValue { get; set; }
        public Bags bag { get; set; }           
        public Equip equipment { get; set; }        
        

        void dealDamageToEnemy(ITakeDamage enemy)                       
        {
            int totalDamage = this.attackValue + 5;
            enemy.takeDamageFromEnemy(totalDamage);
        }
        void ITakeDamage.takeDamageFromEnemy(int damageTaken)          
        {
            this.healthPoints -= damageTaken * 0.1 * defenseValue;
        }
        Player (string playerName)
        {
            healthPoints = 100;
            manaPoints = 100;
            attackValue = 10;
            defenseValue = 10;
            Bags bag = new Bags();
            Equip equipment = new Equip();
        }

        
        


    }
}
