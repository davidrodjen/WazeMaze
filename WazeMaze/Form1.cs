using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WazeMaze
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            arrow.Text = "J";
            arrow.Location = new Point(30, 40);

            this.KeyDown += new KeyEventHandler(MainForm_KeyInput);
        }

        public void MainForm_KeyInput(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                arrow.Location = new Point(arrow.Location.X - 4, arrow.Location.Y);
            }

            if (e.KeyData == Keys.Right)
            {
                arrow.Location = new Point(arrow.Location.X + 4, arrow.Location.Y);
            }

            if (e.KeyData == Keys.Up)
            {
                arrow.Location = new Point(arrow.Location.X, arrow.Location.Y - 4);
            }

            if (e.KeyData == Keys.Down)
            {
                arrow.Location = new Point(arrow.Location.X, arrow.Location.Y + 4);
            }

            //If the arrow touches the boarders
            if (topBorder.Bounds.IntersectsWith(arrow.Bounds) || bottomBorder.Bounds.IntersectsWith(arrow.Bounds)
             || leftBorder.Bounds.IntersectsWith(arrow.Bounds) || rightBorder.Bounds.IntersectsWith(arrow.Bounds))
            {
                GameOver();
            }

            if (a1.Bounds.IntersectsWith(arrow.Bounds) || a2.Bounds.IntersectsWith(arrow.Bounds)
             //|| b1.Bounds.IntersectsWith(arrow.Bounds) || b2.Bounds.IntersectsWith(arrow.Bounds))
            {
                GameOver();
            }

            //if (arrow.Bounds.IntersectsWith(Label.Bounds))
            //{
            //    GameOver();
            //}
        }

        private void GameOver()
        {
            MessageBox.Show("You failed, back to the start");

            arrow.Location = new Point(48, 43);
        }


    }
}
