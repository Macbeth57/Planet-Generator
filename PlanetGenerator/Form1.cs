using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetGenerator
{
    public partial class Form1 : Form
    {
        
        private bool isButtonClicked = false;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            button1.Click += new EventHandler(button1_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            isButtonClicked = true;

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int randomSize = random.Next(101, 300);
            int halfSize = randomSize / 2;
            int centerX = 225 - halfSize;
            int centerY = 225 - halfSize;
            Brush brush = new SolidBrush(GetRandomColor());
            g.FillEllipse(brush, centerX, centerY, randomSize, randomSize);

            cratersGenerator(g);
        }

        private Color GetRandomColor()
        {

            Color randomColor = default;
            int red = random.Next(0, 255);
            int green = random.Next(0, 255);
            int blue = random.Next(0, 255);

            randomColor = Color.FromArgb(red, green, blue);
            
            return randomColor;

        }


        private void cratersGenerator(Graphics g)
        {
            int cratersNbr = random.Next(1, 14);
            int craterSize = default;
            int craterXPosition = default;
            int craterYPosition = default;

            for (int i = 0; i < cratersNbr; i++)
            {
                craterSize = random.Next(3, 21);
                craterXPosition = random.Next(0, 600);
                craterYPosition = random.Next(0, 600);

                Brush smallCircleBrush = new SolidBrush(GetRandomColor());
                g.FillEllipse(smallCircleBrush, craterXPosition, craterYPosition, craterSize, craterSize);
            }
        }
        private void planetGenerator()
        {

        }
    }
}
