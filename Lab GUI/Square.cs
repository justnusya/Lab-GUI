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
        public Square(int centerX, int centerY, int size, Form1 form1)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.size = size;
            this.form1 = form1;
        }

        protected int centerX;
        protected int centerY;
        protected int size;
        protected Form1 form1;

        private Point[] GetCurrPoints()
        {
            return new Point[] {
                new Point(centerX - size,  centerY - size),
                new Point(centerX - size,  centerY + size),
                new Point(centerX + size,  centerY + size),
                new Point(centerX + size,  centerY - size),
            };
        }

        public void Draw()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawPolygon(Pens.Black, GetCurrPoints());
        }

        public void Erase()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawPolygon(new Pen(form1.BackColor), GetCurrPoints());
        }

        public void MoveRight()
        {
            for (int i = 0; i < 50; i++)
            {
                Draw();
                System.Threading.Thread.Sleep(100);
                Erase();
                centerX++;
            }
        }
    }
}
