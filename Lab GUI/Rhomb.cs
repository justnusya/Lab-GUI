using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_GUI
{
    class Rhomb : Figure
    {
        private int sideLength;

        public Rhomb(int x, int y, int sideLength)
        {
            this.sideLength = sideLength;
            x_cenCoord = x;
            y_cenCoord = y;
        }
        public override void HideDrawingBackGround(Graphics graphics)
        {
            graphics.Clear(Color.White);
        }
        public override void DrawBlack(Graphics graphics)
        {
            Point[] points = new Point[4]
            {
                new Point(x_cenCoord, y_cenCoord - sideLength / 2),
                new Point(x_cenCoord + sideLength / 2, y_cenCoord),
                new Point(x_cenCoord, y_cenCoord + sideLength / 2), 
                new Point(x_cenCoord - sideLength / 2, y_cenCoord) 
            };
            graphics.DrawPolygon(Pens.Black, points);
        }
    }
}
