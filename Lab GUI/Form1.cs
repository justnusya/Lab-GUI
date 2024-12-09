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

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            Circle circ = new Circle(40, 100, 60);
            circ.MoveRight(graphics);
        }
        
        private void buttonRhomb_Click(object sender, EventArgs e)
        {
        Graphics graphics = Form1.ActiveForm.CreateGraphics();
        Rhomb rhomb = new Rhomb(10, 30, 50, 40);
        rhomb.MoveRight(graphics);
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            Square square = new Square(10, 30, 50);
            square.MoveRight(graphics);
        }
    }
}
