using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dramaturgis
{
    enum ArmorType { head, body, legs, foots, leftHand, rightHand }

    class Armor:Item
    {
        
        public int deffence { get; set; }
        public ArmorType armotType { get; set; }


    }
}
