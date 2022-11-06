using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LaiSuatCalculation
{
    public partial class Form1 : Form
    {

        public volatile Graphics ggg;
        
        public Form1() 
        {
            InitializeComponent();
            ggg = panel1.CreateGraphics();
        }

        private void btplay_Click(object sender, EventArgs e)
        {
            int i = 10;
            Rectangle rect2 = new Rectangle(10, 10, 20, 20);
            ggg.DrawRectangle(Pens.Aqua, rect2);

            while (i < 150)
            {
                i += 1;
                Thread.Sleep(100);
                ggg.Clear(Color.White);
                Rectangle rect1 = new Rectangle(10, i, 20, 20);
                ggg.DrawRectangle(Pens.Aqua, rect1);
            }
        }
    }
}