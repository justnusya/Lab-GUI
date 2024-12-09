using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_GUI
{
    class Circle:Figure
    {
        private int radius;

        public Circle(int x, int y, int radius)
        {
            this.radius = radius;
            x_cenCoord = x;
            y_cenCoord = y;
        }
        public override void HideDrawingBackGround()
        {

        }
        public override void DrawBlack(int x, int y)
        {
            this.DrawBlack(x, y);
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, x - radius, y - radius, radius * 2, radius * 2);
        }
        
    }
}
