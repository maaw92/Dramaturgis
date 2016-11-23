using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dramaturgis
{
    static class GameController
    {
        static public List<Monster> monsterList = new List<Monster>();
        static public Dictionary<RadioButton, Monster> MonstersAndTheirVisualisationPairs = new Dictionary<RadioButton, Monster>();
    }
}
