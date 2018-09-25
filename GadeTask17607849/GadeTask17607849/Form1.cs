﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GadeTask17607849
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Map grid = new Map();
        private int count = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimer.Text = "0";
            grid.initialiseMap();
            grid.draw();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = Convert.ToString(count);
            count++;
            lblMap.Text = grid.reDraw();
        }
    }
}
