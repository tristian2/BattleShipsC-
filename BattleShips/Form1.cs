﻿using Battleships;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BattleShipGame battleshipGame = new BattleShipGame();
            battleshipGame.showWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
