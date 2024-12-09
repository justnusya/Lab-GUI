using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_GUI
{
    class Square:Figure
    {
        private int sideLength;
        public Square(int x, int y, int sideLength)
        {
            this.sideLength = sideLength;
            x_cenCoord = x;
            y_cenCoord = y;
        }
        public override void HideDrawingBackGround(Graphics graphics)
        {
            graphics.Clear(Form1.ActiveForm.BackColor);
        }
        public override void DrawBlack(Graphics graphics)
        {
            Point[] points = new Point[4]
            {
                new Point(x_cenCoord , y_cenCoord),
                new Point(x_cenCoord, y_cenCoord + sideLength / 2),
                new Point(x_cenCoord + sideLength/2, y_cenCoord + sideLength / 2),
                new Point(x_cenCoord + sideLength / 2, y_cenCoord),
            };
            graphics.DrawPolygon(Pens.Black, points);
        }
    }
}
