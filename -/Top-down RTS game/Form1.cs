using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Top_down_RTS_game
{
    public partial class Form1 : Form
    {
        private Graphics _graphics;
        public int rows;
        public int columns;

        int x = 5;
        int y = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void CreatePoint(int x, int y)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(pictureBox1.Image);
            rows = pictureBox1.Height / 10;
            columns = pictureBox1.Width / 10;

            for (int i = 0; i < rows; i++)
            {
                CreateRow(x, y);
            }
        }

        public void CreateRow(int x, int y)
        {
            for (int X = 0; X < rows; X++)
            {
                for (int Y = 0; Y < columns; Y++)
                {
                    _graphics.FillRectangle(Brushes.Black, x, y, 5, 5);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CreatePoint(x, y);

            x += 10;
            y += 10;

        }
    }
}
