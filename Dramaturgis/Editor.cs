using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dramaturgis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createMonsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monster monster = new Monster();
            GameController.monsterList.Add(monster);
        }
    }
}
