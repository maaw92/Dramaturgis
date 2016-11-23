using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dramaturgis
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            GameWindow GameWindow = new GameWindow();
            GameWindow.FormBorderStyle = FormBorderStyle.None;
            GameWindow.WindowState = FormWindowState.Maximized;
            GameWindow.Show();

        }

        private void optionsButton_Click(object sender, EventArgs e)
        {

        }

        private void editorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editor editor = new Editor();
            editor.Show();
        }
    }
}
