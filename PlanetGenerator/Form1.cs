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

            moonGenerator(g);
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


        private void moonGenerator(Graphics g)
        {
            int moonNbr = random.Next(1, 14);
            int moonSize = default;
            int moonXPosition = default;
            int moonYPosition = default;

            for (int i = 0; i < moonNbr; i++)
            {
                moonSize = random.Next(3, 21);
                moonXPosition = random.Next(0, 600);
                moonYPosition = random.Next(0, 600);

                Brush smallCircleBrush = new SolidBrush(GetRandomColor());
                g.FillEllipse(smallCircleBrush, moonXPosition, moonYPosition, moonSize, moonSize);
            }
        }
        private void planetGenerator()
        {

        }
    }
}
