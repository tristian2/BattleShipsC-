namespace BattleShips
{
    partial class Form1
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
            this.Quit = new System.Windows.Forms.Button();
            this.Fire = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.TextBox();
            this.statusPanel = new System.Windows.Forms.TextBox();
            this.fireStatusPanel = new System.Windows.Forms.TextBox();
            this.scorePanel = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(12, 517);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 0;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fire
            // 
            this.Fire.Location = new System.Drawing.Point(239, 517);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(75, 23);
            this.Fire.TabIndex = 1;
            this.Fire.Text = "Fire";
            this.Fire.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainPanel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(12, 15);
            this.mainPanel.Multiline = true;
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(302, 391);
            this.mainPanel.TabIndex = 2;
            // 
            // statusPanel
            // 
            this.statusPanel.Location = new System.Drawing.Point(12, 412);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(100, 20);
            this.statusPanel.TabIndex = 3;
            // 
            // fireStatusPanel
            // 
            this.fireStatusPanel.Location = new System.Drawing.Point(12, 438);
            this.fireStatusPanel.Name = "fireStatusPanel";
            this.fireStatusPanel.Size = new System.Drawing.Size(100, 20);
            this.fireStatusPanel.TabIndex = 4;
            // 
            // scorePanel
            // 
            this.scorePanel.Location = new System.Drawing.Point(12, 464);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(100, 20);
            this.scorePanel.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(12, 490);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox2.Location = new System.Drawing.Point(193, 490);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 550);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.fireStatusPanel);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Quit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.TextBox mainPanel;
        private System.Windows.Forms.TextBox statusPanel;
        private System.Windows.Forms.TextBox fireStatusPanel;
        private System.Windows.Forms.TextBox scorePanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}