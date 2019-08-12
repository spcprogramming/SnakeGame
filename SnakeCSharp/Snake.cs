using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeCSharp
{
    public partial class Snake : Form
    {
        Bitmap b;
        int xPos;
        int yPos;
        int increment;
        Direction d;
        Point previous;

        public Snake()
        {
            InitializeComponent();
            xPos = mainGraphic.Width / 2;
            yPos = mainGraphic.Height / 2;
            d = Direction.Left;
            previous = new Point(mainGraphic.Width / 2, mainGraphic.Height / 2);
            increment = 10;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            switch (d)
            {
                case Direction.Down:
                    yPos += increment;
                    break;
                case Direction.Up:
                    yPos -= increment;
                    break;
                case Direction.Left:
                    xPos -= increment;
                    break;
                case Direction.Right:
                    xPos += increment;
                    break;
            }

            if(b != null)
            {
                b.Dispose();
                b = null;
            }
               
            b = new Bitmap(mainGraphic.Width, mainGraphic.Height);
            Graphics g = Graphics.FromImage(b);

            Pen p = new Pen(Color.Plum, 5);
            Point current = new Point(xPos, yPos);

            g.DrawLine(p, previous, current);
            previous = current;

            g.Dispose();
            mainGraphic.Invalidate();
        }

        private void mainGraphic_Paint(object sender, PaintEventArgs e)
        {

            if (b != null)
            {
                Graphics g = e.Graphics;
                g.DrawImage(b, 0, 0, b.Width, b.Height);
            }

        }

        private void Snake_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    d = Direction.Left;
                    break;
                case Keys.Right:
                    d = Direction.Right;
                    break;
                case Keys.Down:
                    d = Direction.Down;
                    break;
                case Keys.Up:
                    d = Direction.Up;
                    break;
            }
        }

        private enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }
    }
}
