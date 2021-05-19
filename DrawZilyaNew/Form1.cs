using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawZilyaNew
{
    public partial class Glav_Draw : Form
    {
        public Glav_Draw()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            var paper = pnlDraw.CreateGraphics();
            var pen = new Pen(Color.Black, 5);
            paper.DrawLine(pen, 60, 60, 80, 100);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            var paper = pnlDraw.CreateGraphics();
            var pen = new Pen(Color.Red, 5);
            paper.DrawEllipse(pen, 170, 170, 80, 100);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            var paper = pnlDraw.CreateGraphics();
            var pen = new Pen(Color.Green, 8);
            paper.DrawRectangle(pen, 160, 160, 80, 100);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            var paper = pnlDraw.CreateGraphics();
            var pen = new Pen(Color.Yellow, 5);
            paper.DrawLine(pen, 60, 60, 180, 500);
            paper.DrawLine(pen, 180, 500, 390, 510);
            paper.DrawLine(pen, 390, 510, 60, 60);
        }
    }
}
