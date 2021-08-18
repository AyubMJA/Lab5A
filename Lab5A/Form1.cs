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
        Color cColor; //current colour variable

        //Faucet vairables.
        int faucetX1 = 214;
        int faucetY1 = 250;
        int faucetX2 = 214;
        int faucetY2 = 645;

        
        //Bucket variables.
        int bucketX1 = 120;
        int bucketY1 = 650;
        int bucketX2 = 480;
        int bucketY2 = 650;

        bool bucketIsFull = false;

        public Form1()
        {
            InitializeComponent();
            cColor = Color.Aqua;
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
        /// This closes the application with a button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This button allows the user to pick color from color dialog box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colour_btn_Click(object sender, EventArgs e)
        {
            DialogResult colorDialog = colorDialog1.ShowDialog();
            if (colorDialog == DialogResult.OK)
            {
                cColor = colorDialog1.Color;

                if (trackBar1.Value > 0)
                {
                    cColor = colorDialog1.Color;
                    //Not finished obviously add some nonsense later.
                }
                else
                {
                    cColor = colorDialog1.Color;
                }
            }


        }

        /// <summary>
        /// Keeps track of track bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Bucket placement on window Form
        /// </summary>
        /// <param name="bucket"></param>
        public void BucketDrawing(Graphics bucket)
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

            cColor = color;
            Graphics graphics = CreateGraphics();
            Pen pen = new Pen(color, 12);

            graphics.DrawLine(pen, faucetX1, faucetY1, faucetX2, faucetY2);
        }


        // TODO: FIx inverted weird if statements thought would save time but doesn't do it what I experimented with. 
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0)
            {
                if (trackBar1.Value != 1)
                {
                    if (trackBar1.Value != 2)
                    {
                        if (trackBar1.Value != 3)
                        {
                            if (trackBar1.Value != 4)
                            {
                                if (trackBar1.Value != 5)
                                {
                                    if (trackBar1.Value != 6)
                                    {
                                        if (trackBar1.Value != 7)
                                        {
                                            if (trackBar1.Value != 8)
                                            {
                                                if (trackBar1.Value != 9)
                                                {
                                                    if (trackBar1.Value != 10)
                                                    {
                                                        return;
                                                    }
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
                                                else
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
                                            }
                                            else
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
                                        }
                                        else
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
                                    }
                                    else
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
                                }
                                else
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
                            }
                            else
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
                        }
                        else
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
                    }
                    else
                    {
                        if (bucketIsFull)
                        {
                            bucketIsFull = false;
                            Graphics black = CreateGraphics();
                            Brush brushBlack = new SolidBrush(Color.Black);
                            black.FillRectangle(brushBlack, faucetX1, faucetY1, faucetX2, faucetY2);
                        }
                        paint(colorDialog1.Color, faucetX1, faucetY1, faucetX2, faucetY2);
                        timer1.Interval = 400;
                        timer1.Start();
                    }
                }
                else
                {
                    if (bucketIsFull)
                    {
                        bucketIsFull = false;
                        Graphics black = CreateGraphics();
                        Brush brushBlack = new SolidBrush(Color.Black);
                        black.FillRectangle(brushBlack, 66, 250, 213, 100);
                    }
                    paint(colorDialog1.Color, faucetX1, faucetY1, faucetX2, faucetY2);
                    timer1.Interval = 500;
                    timer1.Start();
                }
            }
            else
            {
                paint(Color.Black, faucetX1, faucetY1, faucetX2, faucetY2);
                timer1.Stop();
            }
        }


        /// <summary>
        /// timer func that keeps track of flow rate of paint into bucket.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Timer1Func(object sender, EventArgs e)
        {
            Graphics fill = CreateGraphics();
            Brush brush = new SolidBrush(cColor);

            fill.FillRectangle(brush, bucketX1, bucketY1, bucketX2, bucketY2);

            bucketY1--;

            //features doesn't work paint outside of bucket.
            //fix later.
            if (bucketY1 >= 40 || faucetY2 >= 40)
            {
                return;
            }
            bucketIsFull = true;
            paint(Color.Black, faucetX1, faucetY1, faucetX2, faucetY2);

            timer1.Stop();

            //faucet init default values
            faucetX1 = 214;
            faucetY1 = 250;
            faucetX2 = 214;
            faucetY2 = 645;
            //bucket init default values
            bucketX1 = 120;
            bucketY1 = 650;
            bucketX2 = 480;
            bucketY2 = 650;

            //suppose to set value to trackbar to 0 and erase the bucket.
            //not done.
            trackBar1.Value = 0;
        }
    }
}
