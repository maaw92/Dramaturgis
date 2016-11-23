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
        static int test = 1;
        private void addTrollToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            Troll monster = new Troll();
            GameController.monsterList.Add(monster);
            RadioButton radioButtonMonster = new RadioButton();
            radioButtonMonster.Parent = flowLayoutPanel1;
            radioButtonMonster.Text = "";
            radioButtonMonster.Show();
            Random rand = new Random();
            
            test++;
            GameController.MonstersAndTheirVisualisationPairs.Add(radioButtonMonster,monster);
            
             
            
            
            foreach (Monster m in GameController.monsterList)
             {
                RadioButton myKey = GameController.MonstersAndTheirVisualisationPairs.FirstOrDefault(x => x.Value == m).Key;
                myKey.Text =m.healthPoints.ToString();
             
               
            }
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
              Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             var  buttons = flowLayoutPanel1.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            if (buttons != null)
            {
                GameController.MonstersAndTheirVisualisationPairs[buttons].healthPoints -= 30;
          //      buttons.Text = GameController.MonstersAndTheirVisualisationPairs[buttons].healthPoints.ToString();
            }



        }
    }
}
