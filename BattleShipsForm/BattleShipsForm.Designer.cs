namespace BattleShips
{
    partial class BattleShipsForm
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
            this.cboRow = new System.Windows.Forms.ComboBox();
            this.cboCol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(12, 380);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(54, 23);
            this.Quit.TabIndex = 0;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fire
            // 
            this.Fire.Location = new System.Drawing.Point(103, 379);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(59, 23);
            this.Fire.TabIndex = 1;
            this.Fire.Text = "Fire";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainPanel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Multiline = true;
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(159, 240);
            this.mainPanel.TabIndex = 2;
            // 
            // statusPanel
            // 
            this.statusPanel.Location = new System.Drawing.Point(12, 275);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(150, 20);
            this.statusPanel.TabIndex = 3;
            // 
            // fireStatusPanel
            // 
            this.fireStatusPanel.Location = new System.Drawing.Point(12, 301);
            this.fireStatusPanel.Name = "fireStatusPanel";
            this.fireStatusPanel.Size = new System.Drawing.Size(150, 20);
            this.fireStatusPanel.TabIndex = 4;
            // 
            // scorePanel
            // 
            this.scorePanel.Location = new System.Drawing.Point(12, 327);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(150, 20);
            this.scorePanel.TabIndex = 5;
            // 
            // cboRow
            // 
            this.cboRow.FormattingEnabled = true;
            this.cboRow.Items.AddRange(new object[] {
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
            this.cboRow.Location = new System.Drawing.Point(12, 353);
            this.cboRow.Name = "cboRow";
            this.cboRow.Size = new System.Drawing.Size(36, 21);
            this.cboRow.TabIndex = 6;
            this.cboRow.Text = "5";
            // 
            // cboCol
            // 
            this.cboCol.FormattingEnabled = true;
            this.cboCol.Items.AddRange(new object[] {
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
            this.cboCol.Location = new System.Drawing.Point(127, 353);
            this.cboCol.Name = "cboCol";
            this.cboCol.Size = new System.Drawing.Size(35, 21);
            this.cboCol.TabIndex = 7;
            this.cboCol.Text = "5";
            // 
            // BattleShipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 455);
            this.Controls.Add(this.cboCol);
            this.Controls.Add(this.cboRow);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.fireStatusPanel);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Quit);
            this.Name = "BattleShipsForm";
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
        private System.Windows.Forms.ComboBox cboRow;
        private System.Windows.Forms.ComboBox cboCol;
    }
}