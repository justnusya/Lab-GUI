using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_GUI
{
    abstract class Figure
    {
        protected int x_cenCoord;
        protected int y_cenCoord;

        public abstract void DrawBlack(Graphics graphics);
        public abstract void HideDrawingBackGround();
        public void MoveRight(Graphics graphics)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(100);
                graphics.Clear(Color.White);
                x_cenCoord++;
                DrawBlack(graphics);
            }
        }

    }
}
