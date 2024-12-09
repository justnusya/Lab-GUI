using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Move_circle(object sender, EventArgs e)
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            Circle circ = new Circle(80, 100, 60);
            circ.MoveRight(graphics);
        }

        private void Move_rhomb(object sender, EventArgs e)
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            Rhomb rhomb = new Rhomb(10, 30, 50, 40);
            rhomb.MoveRight(graphics);
        }

        private void Move_square(object sender, EventArgs e)
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            Square square = new Square(10, 30, 50);
            square.MoveRight(graphics);
        }
    }
}
