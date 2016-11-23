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
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void addTrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addTrollToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Troll monster = new Troll();
            GameController.monsterList.Add(monster);
            richTextMonsters.Text = "";
            Label radioButtonMonster = new Label();
            radioButtonMonster.Parent = this;
            radioButtonMonster.Location = new Point(1000, 1000);
            radioButtonMonster.Width = 100;
            radioButtonMonster.Height = 100;
            radioButtonMonster.Show();
        //    radioButtonMonster.Text = m.GetType().ToString() + " " + m.healthPoints.ToString() + '\n';
            foreach (Monster m in GameController.monsterList)
             {
                richTextMonsters.Text += m.GetType().ToString()+" "+m.healthPoints.ToString()+'\n';
               
            }
            
        }
    }
}
