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
        public override void HideDrawingBackGround(Graphics graphics)
        {
            graphics.Clear(Form1.ActiveForm.BackColor);
        }
        public override void DrawBlack(Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Black, x_cenCoord - radius, y_cenCoord - radius, radius * 2, radius * 2);
        }
        
    }
}
