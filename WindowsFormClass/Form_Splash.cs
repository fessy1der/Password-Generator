﻿using System;
using System.Windows.Forms;

namespace WindowsFormClass
{
    public partial class Form_Splash : Form
    {
        public Form_Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;

            if (panelSlide.Left > 270)
            {
                panelSlide.Left = 0;
            }
            
        }

        private void Form_Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
