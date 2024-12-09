using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_GUI
{
    abstract class Figure
    {
        protected int x_cenCoord;
        protected int y_cenCoord;

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public void MoveRight(int startX, int startY, int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                DrawBlack(startX + i, startY);
            }
        }

    }
}
