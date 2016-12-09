using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTriangles
{
    public partial class Window : Form
    {

    

        public Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawTri = new Pen(Color.Red, 3);
            DrawTriangle(drawTri, 100, 150, 200, 200, 200, 400);
            DrawTriangle(drawTri, 75, 12, 11, 103, 300, 6);
        }

        public void DrawTriangle(Pen drawTri, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            #region Draw Triangle Method
            Graphics g = this.CreateGraphics();
            g.DrawLine(drawTri, x1, y1, x2, y2);
            g.DrawLine(drawTri, x2, y2, x3, y3);
            g.DrawLine(drawTri, x3, y3, x1, y1);
            #endregion
        }

    }
}
