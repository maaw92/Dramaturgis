namespace Dramaturgis
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addTrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextMonsters = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTrollToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addTrollToolStripMenuItem
            // 
            this.addTrollToolStripMenuItem.Name = "addTrollToolStripMenuItem";
            this.addTrollToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.addTrollToolStripMenuItem.Text = "Add Troll";
            this.addTrollToolStripMenuItem.Click += new System.EventHandler(this.addTrollToolStripMenuItem_Click_1);
            // 
            // richTextMonsters
            // 
            this.richTextMonsters.Location = new System.Drawing.Point(93, 66);
            this.richTextMonsters.Name = "richTextMonsters";
            this.richTextMonsters.Size = new System.Drawing.Size(187, 96);
            this.richTextMonsters.TabIndex = 1;
            this.richTextMonsters.Text = "";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 371);
            this.Controls.Add(this.richTextMonsters);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Editor";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addTrollToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextMonsters;
    }
}

