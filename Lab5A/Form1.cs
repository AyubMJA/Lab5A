using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5A
{
    public partial class Form1 : Form
    {
        //variables.
        Color currentColor;

        //Faucet vairables.
        int faucetX1 = 214;
        int faucetY1 = 250;
        int faucetX2 = 214;
        int faucetY2 = 645;

        //Bucket variables.
        int bucketX1 = 66;
        int bucketY1 = 348;
        int bucketX2 = 213;
        int bucketY2 = 1;

        bool bucketIsFull = false;

        public Form1()
        {
            InitializeComponent();
            currentColor = Color.Aqua;
            colorDialog1.Color = Color.Aqua;
        }

        /// <summary>
        /// Paint form method. Renders objects in views.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics bucket = CreateGraphics();
            BucketDrawing(bucket);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colour_btn_Click(object sender, EventArgs e)
        {
            DialogResult colorDialog = colorDialog1.ShowDialog();
            if (colorDialog == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;

                if (trackBar1.Value > 0)
                {
                    currentColor = colorDialog1.Color;
                    //Not finished obviously add some nonsense later.
                }
                else
                {
                    currentColor = colorDialog1.Color;
                }
            }


        }

        /// <summary>
        /// This closes the application with a button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value == 0)
            {
                paint(Color.Black, faucetX1,faucetY1,faucetX2,faucetY2);
                timer1.Stop();
            }
            else if(trackBar1.Value == 1)
            {
                if(bucketIsFull)
                {
                    bucketIsFull = false;
                    Graphics black = CreateGraphics();
                    Brush brushBlack = new SolidBrush(Color.Black);
                    black.FillRectangle(brushBlack,66,250,213,100);
                }
                paint(colorDialog1.Color,faucetX1,faucetY1,faucetX2,faucetY2);
                timer1.Interval = 500;
                timer1.Start();
            }
            else if(trackBar1.Value == 2)
            {
                if(bucketIsFull)
                {
                    bucketIsFull = false;
                    Graphics black = CreateGraphics();
                    Brush brushBlack = new SolidBrush(Color.Black);
                    black.FillRectangle(brushBlack,faucetX1,faucetY1,faucetX2,faucetY2);
                }
                paint(colorDialog1.Color,faucetX1,faucetY1,faucetX2,faucetY2);
                timer1.Interval = 400;
                timer1.Start();
            }
            else if (trackBar1.Value == 3)
            {
                if (bucketIsFull)
                {
                    bucketIsFull = false;
                    Graphics black = CreateGraphics();
                    Brush brushBlack = new SolidBrush(Color.Black);
                    black.FillRectangle(brushBlack, faucetX1, faucetY1, faucetX2, faucetY2);
                }
                paint(colorDialog1.Color, faucetX1, faucetY1, faucetX2, faucetY2);
                timer1.Interval = 300;
                timer1.Start();
            }
            else if (trackBar1.Value == 4)
            {
                if (bucketIsFull)
                {
                    bucketIsFull = false;
                    Graphics black = CreateGraphics();
                    Brush brushBlack = new SolidBrush(Color.Black);
                    black.FillRectangle(brushBlack, faucetX1, faucetY1, faucetX2, faucetY2);
                }
                paint(colorDialog1.Color, faucetX1, faucetY1, faucetX2, faucetY2);
                timer1.Interval = 200;
                timer1.Start();
            }
            else if (trackBar1.Value == 5)
            {
                if (bucketIsFull)
                {
                    bucketIsFull = false;
                    Graphics black = CreateGraphics();
                    Brush brushBlack = new SolidBrush(Color.Black);
                    black.FillRectangle(brushBlack, faucetX1, faucetY1, faucetX2, faucetY2);
                }
                paint(colorDialog1.Color, faucetX1, faucetY1, faucetX2, faucetY2);
                timer1.Interval = 100;
                timer1.Start();
            }
            else if (trackBar1.Value == 6)
            {
                if (bucketIsFull)
                {
                    bucketIsFull = false;
                    Graphics black = CreateGraphics();
                    Brush brushBlack = new SolidBrush(Color.Black);
                    black.FillRectangle(brushBlack, faucetX1, faucetY1, faucetX2, faucetY2);
                }
                paint(colorDialog1.Color, faucetX1, faucetY1, faucetX2, faucetY2);
                timer1.Interval = 80;
                timer1.Start();
            }
            else if (trackBar1.Value == 7)
            {
                if (bucketIsFull)
                {
                    bucketIsFull = false;
                    Graphics black = CreateGraphics();
                    Brush brushBlack = new SolidBrush(Color.Black);
                    black.FillRectangle(brushBlack, faucetX1, faucetY1, faucetX2, faucetY2);
                }
                paint(colorDialog1.Color, faucetX1, faucetY1, faucetX2, faucetY2);
                timer1.Interval = 60;
                timer1.Start();
            }
            else if (trackBar1.Value == 8)
            {
                if (bucketIsFull)
                {
                    bucketIsFull = false;
                    Graphics black = CreateGraphics();
                    Brush brushBlack = new SolidBrush(Color.Black);
                    black.FillRectangle(brushBlack, faucetX1, faucetY1, faucetX2, faucetY2);
                }
                paint(colorDialog1.Color, faucetX1, faucetY1, faucetX2, faucetY2);
                timer1.Interval = 40;
                timer1.Start();
            }
            else if (trackBar1.Value == 9)
            {
                if (bucketIsFull)
                {
                    bucketIsFull = false;
                    Graphics black = CreateGraphics();
                    Brush brushBlack = new SolidBrush(Color.Black);
                    black.FillRectangle(brushBlack, faucetX1, faucetY1, faucetX2, faucetY2);
                }
                paint(colorDialog1.Color, faucetX1, faucetY1, faucetX2, faucetY2);
                timer1.Interval = 20;
                timer1.Start();
            }
            else if (trackBar1.Value == 10)
            {
                if (bucketIsFull)
                {
                    bucketIsFull = false;
                    Graphics black = CreateGraphics();
                    Brush brushBlack = new SolidBrush(Color.Black);
                    black.FillRectangle(brushBlack, faucetX1, faucetY1, faucetX2, faucetY2);
                }
                paint(colorDialog1.Color, faucetX1, faucetY1, faucetX2, faucetY2);
                timer1.Interval = 10;
                timer1.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Bucket placement on window Form
        /// </summary>
        /// <param name="bucket"></param>
        public static void BucketDrawing(Graphics bucket)
        {
            Pen linePen = new Pen(Color.White, 4);
            bucket.DrawLine(linePen, 120, 650, 480, 650); //(x1,y1)(x2,y2) bottom piece
            bucket.DrawLine(linePen, 120, 650, 120, 500); //(x1,y1)(x2,y2) left piece
            bucket.DrawLine(linePen, 480, 650, 480, 500);//(x1,y1)(x2,y2) right piece
        }

        /// <summary>
        /// This is a function that handles the Faucet Paint color
        /// </summary>
        /// <param name="color"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
       public void paint(Color color, int x1, int y1, int x2, int y2 )
        {
            faucetX1 = x1;
            faucetY1 = y1;
            faucetX2 = x2;
            faucetY2 = y2;

            currentColor = color;
            Graphics graphics = CreateGraphics();
            Pen pen = new Pen(color, 12);

            graphics.DrawLine(pen, faucetX1, faucetY1, faucetX2, faucetY2);
        }
    }
}
