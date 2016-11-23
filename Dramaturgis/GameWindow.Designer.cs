namespace Dramaturgis
{
    partial class GameWindow
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.manaBar = new System.Windows.Forms.ProgressBar();
            this.skillButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.equipButt = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.healthBarValue = new System.Windows.Forms.Label();
            this.manaBarValue = new System.Windows.Forms.Label();
            this.healthBarValue2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 108);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 25);
            this.progressBar1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.BackgroundImage = global::Dramaturgis.Properties.Resources.frame;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.healthBarValue2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.healthBar, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.manaBar, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.skillButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.optionsButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.equipButt, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.healthBarValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.manaBarValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(411, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 630);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "MP :";
            // 
            // healthBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.healthBar, 2);
            this.healthBar.Location = new System.Drawing.Point(128, 109);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(116, 19);
            this.healthBar.TabIndex = 5;
            this.healthBar.Value = 100;
            // 
            // manaBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.manaBar, 2);
            this.manaBar.Location = new System.Drawing.Point(128, 147);
            this.manaBar.Name = "manaBar";
            this.manaBar.Size = new System.Drawing.Size(116, 19);
            this.manaBar.TabIndex = 6;
            this.manaBar.Value = 100;
            // 
            // skillButton
            // 
            this.skillButton.Location = new System.Drawing.Point(6, 388);
            this.skillButton.Name = "skillButton";
            this.skillButton.Size = new System.Drawing.Size(52, 19);
            this.skillButton.TabIndex = 7;
            this.skillButton.Text = "Skills";
            this.skillButton.UseVisualStyleBackColor = true;
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(67, 388);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(52, 19);
            this.optionsButton.TabIndex = 8;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            // 
            // equipButt
            // 
            this.equipButt.Location = new System.Drawing.Point(128, 388);
            this.equipButt.Name = "equipButt";
            this.equipButt.Size = new System.Drawing.Size(52, 19);
            this.equipButt.TabIndex = 9;
            this.equipButt.Text = "EQ";
            this.equipButt.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(189, 388);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 19);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // healthBarValue
            // 
            this.healthBarValue.AutoSize = true;
            this.healthBarValue.BackColor = System.Drawing.Color.Transparent;
            this.healthBarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.healthBarValue.Location = new System.Drawing.Point(67, 144);
            this.healthBarValue.Name = "healthBarValue";
            this.healthBarValue.Size = new System.Drawing.Size(30, 31);
            this.healthBarValue.TabIndex = 3;
            this.healthBarValue.Text = "0";
            // 
            // manaBarValue
            // 
            this.manaBarValue.AutoSize = true;
            this.manaBarValue.BackColor = System.Drawing.Color.Transparent;
            this.manaBarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.manaBarValue.Location = new System.Drawing.Point(67, 106);
            this.manaBarValue.Name = "manaBarValue";
            this.manaBarValue.Size = new System.Drawing.Size(30, 31);
            this.manaBarValue.TabIndex = 4;
            this.manaBarValue.Text = "0";
            // 
            // healthBarValue2
            // 
            this.healthBarValue2.AutoSize = true;
            this.healthBarValue2.BackColor = System.Drawing.Color.Transparent;
            this.healthBarValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.healthBarValue2.Location = new System.Drawing.Point(6, 106);
            this.healthBarValue2.Name = "healthBarValue2";
            this.healthBarValue2.Size = new System.Drawing.Size(50, 35);
            this.healthBarValue2.TabIndex = 11;
            this.healthBarValue2.Text = "HP :";
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 4);
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 94);
            this.button1.TabIndex = 12;
            this.button1.Text = "MAPA ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 630);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameWindow";
            this.Text = "DaGEJM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label healthBarValue;
        private System.Windows.Forms.Label manaBarValue;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.ProgressBar manaBar;
        private System.Windows.Forms.Button skillButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button equipButt;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label healthBarValue2;
        private System.Windows.Forms.Button button1;
    }
}