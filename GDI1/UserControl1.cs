using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        Point[] points = new Point[10];
        public bool turn = false;
        int[] count = new int[18];
        public int player = 1;
        public int check = 0;
        public void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Red, 0, 100, Width, 100);
            e.Graphics.DrawLine(Pens.Red, 0, 200, Width, 200);
            e.Graphics.DrawLine(Pens.Red, 100, 0, 100, Height);
            e.Graphics.DrawLine(Pens.Red, 200, 0, 200, Height);
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics g;
            g = this.CreateGraphics();
            MouseEventArgs e2 = (MouseEventArgs)e;
            //MessageBox.Show(string.Format("X: {0} Y: {1}", e2.X, e2.Y));
            //for (int i = 0; i < 10; i++)
            //{
            if (turn == false)
            {
                if (player % 2 == 0)
                {
                    player++;
                    //turn = false;
                    //MessageBox.Show("Turn Player X");
                }
                else
                {
                    player++;
                    //turn = false;
                    //MessageBox.Show("Turn Player O");

                }
                //1
                if (e2.X < 100 && e2.Y < 100)
                {
                    //turn = true;
                    if (player % 2 == 0 && count[9] != 1)
                    {
                        count[0] = 1;
                        g.DrawLine(Pens.Red, 0, 100, 100, 0);
                        g.DrawLine(Pens.Red, 0, 0, 100, 100);
                    }
                    else if (count[0] != 1)
                    {
                        count[9] = 1;
                        g.DrawArc(Pens.Blue, 0, 0, 100, 100, 0, 360);
                    }
                }
                //2
                else if (e2.X < 200 && e2.X >= 100 && e2.Y < 100)
                {
                    //turn = true;
                    if (player % 2 == 0 && count[10] != 2)
                    {
                        count[1] = 2;
                        g.DrawLine(Pens.Red, 100, 100, 200, 0);
                        g.DrawLine(Pens.Red, 100, 0, 200, 100);
                    }
                    else if (count[1] != 2)
                    {
                        count[10] = 2;
                        g.DrawArc(Pens.Blue, 100, 0, 100, 100, 0, 360);
                    }
                }
                //3
                else if (e2.X < 290 && e2.X > 200 && e2.Y < 100)
                {

                    //turn = true;
                    if (player % 2 == 0 && count[11] != 3)
                    {
                        count[2] = 3;
                        g.DrawLine(Pens.Red, 200, 100, 300, 0);
                        g.DrawLine(Pens.Red, 200, 0, 300, 100);
                    }
                    else if (count[2] != 3)
                    {
                        count[11] = 3;
                        g.DrawArc(Pens.Blue, 200, 0, 100, 100, 0, 360);
                    }
                }
                //4
                else if (e2.X < 100 && e2.Y < 200 && e2.Y > 100)
                {

                    //turn = true;
                    if (player % 2 == 0 && count[12] != 4)
                    {
                        count[3] = 4;
                        g.DrawLine(Pens.Red, 0, 200, 100, 100);
                        g.DrawLine(Pens.Red, 0, 100, 100, 200);
                    }
                    else if (count[3] != 4)
                    {
                        count[12] = 4;
                        g.DrawArc(Pens.Blue, 0, 100, 100, 100, 0, 360);
                    }
                }
                //5
                else if (e2.X < 200 && e2.X > 100 && e2.Y < 200 && e2.Y >= 100)
                {
                    //turn = true;
                    if (player % 2 == 0 && count[13] != 5)
                    {
                        count[4] = 5;
                        g.DrawLine(Pens.Red, 100, 200, 200, 100);
                        g.DrawLine(Pens.Red, 100, 100, 200, 200);
                    }
                    else if (count[4] != 5)
                    {
                        count[13] = 5;
                        g.DrawArc(Pens.Blue, 100, 100, 100, 100, 0, 360);
                    }
                }
                //6
                else if (e2.X < 300 && e2.X > 200 && e2.Y < 200 && e2.Y >= 100)
                {

                    //turn = true;
                    if (player % 2 == 0 && count[14] != 6)
                    {
                        count[5] = 6;
                        g.DrawLine(Pens.Red, 200, 200, 300, 100);
                        g.DrawLine(Pens.Red, 200, 100, 300, 200);
                    }
                    else if (count[5] != 6)
                    {
                        count[14] = 6;
                        g.DrawArc(Pens.Blue, 200, 100, 100, 100, 0, 360);
                    }
                }
                //7
                else if (e2.X < 100 && e2.Y < 260 && e2.Y > 200)
                {

                    //turn = true;
                    if (player % 2 == 0 && count[15] != 7)
                    {
                        count[6] = 7;
                        g.DrawLine(Pens.Red, 0, 300, 100, 200);
                        g.DrawLine(Pens.Red, 0, 200, 100, 300);
                    }
                    else if (count[6] != 7)
                    {
                        count[15] = 7;
                        g.DrawArc(Pens.Blue, 0, 200, 100, 100, 0, 360);
                    }
                }
                //8
                else if (e2.X < 200 && e2.X > 100 && e2.Y < 300 && e2.Y > 200)
                {

                    //turn = true;
                    if (player % 2 == 0 && count[16] != 8)
                    {
                        count[7] = 8;

                        g.DrawLine(Pens.Red, 100, 300, 200, 200);
                        g.DrawLine(Pens.Red, 100, 200, 200, 300);
                    }
                    else if (count[7] != 8)
                    {
                        count[16] = 8;
                        g.DrawArc(Pens.Blue, 100, 200, 100, 100, 0, 360);
                    }
                }
                //9
                if (e2.X < 300 && e2.X > 200 && e2.Y < 300 && e2.Y > 200)
                {

                    //turn = true;
                    if (player % 2 == 0 && count[17] != 9)
                    {
                        count[8] = 9;
                        g.DrawLine(Pens.Red, 200, 300, 300, 200);
                        g.DrawLine(Pens.Red, 200, 200, 300, 300);
                    }
                    else if (count[8] != 9)
                    {
                        count[17] = 9;
                        g.DrawArc(Pens.Blue, 200, 200, 100, 100, 0, 360);
                    }
                }
            }
            int checkwin()
            {
                // diagonal check for X
                if (count[8] == 9 && count[4] == 5 && count[0] == 1 || count[6] == 7 && count[4] == 5 && count[2] == 3)
                {
                    if (player % 2 == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }

                }
                //chorizontal check for x
                else if (count[0] == 1 && count[1] == 2 && count[2] == 3 || count[3] == 4 && count[4] == 5 && count[5] == 6 || count[6] == 7 && count[7] == 8 && count[8] == 9)
                {
                    if (player % 2 == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }

                }
                //vertical check for X
                else if (count[0] == 1 && count[3] == 4 && count[6] == 7 || count[1] == 2 && count[4] == 5 && count[7] == 8 || count[2] == 3 && count[5] == 6 && count[8] == 9)
                {
                    if (player % 2 == 0)
                    {

                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                // diagonal check for O
                if (count[17] == 9 && count[13] == 5 && count[9] == 1 || count[15] == 7 && count[13] == 5 && count[11] == 3)
                {
                    if (player % 2 == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }

                }
                //chorizontal check for O
                else if (count[9] == 1 && count[10] == 2 && count[11] == 3 || count[12] == 4 && count[13] == 5 && count[14] == 6 || count[15] == 7 && count[16] == 8 && count[17] == 9)
                {
                    if (player % 2 == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }

                }
                //vertical check for O
                else if (count[9] == 1 && count[12] == 4 && count[15] == 7 || count[10] == 2 && count[13] == 5 && count[16] == 8 || count[11] == 3 && count[14] == 6 && count[17] == 9)
                {
                    if (player % 2 == 0)
                    {

                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                //equal
                else
                {
                    if (checkFull())
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
            check = checkwin();
            if (check == 1)
            {
                MessageBox.Show("Player X won the game", "Winner Announcer", MessageBoxButtons.OK);
                g.Clear(Color.White);
                this.Invalidate();
                reset();
            }
            else if (check == 2)
            {
                MessageBox.Show("Player O won the game", "Winner Announcer", MessageBoxButtons.OK);
                g.Clear(Color.White);
                this.Invalidate();
                reset();
            }
            else if (check == 0)
            {
                MessageBox.Show("OOps! no one win the game", "Winner Announcer");
                this.Invalidate();
                reset();
            }
        }

        private bool checkFull()
        {
            int c = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                    c++;
            }
            return c == 9;
        }
        void reset()
        {
            for (int i = 0; i < 18; i++)
            {
                count[i] = 0;
            }
        }
    }
}
