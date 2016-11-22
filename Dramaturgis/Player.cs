using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dramaturgis
{
    class Player : ITakeDamage
    {
        public int healthPoints { get; set; }             
        public int manaPoints { get; set; }           
        public int attackValue { get; set; }         
        public Bags bag { get; set; }           
        public Equip equipment { get; set; }        
        

        void dealDamageToEnemy()                       
        {

        }
        void ITakeDamage.takeDamageFromEnemy()          
        {

        }

        
        


    }
}
