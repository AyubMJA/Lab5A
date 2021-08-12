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
        int faucetX1 = 78;
        int faucetY1 = 135;
        int faucetX2 = 78;
        int faucetY2 = 349;

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
            Pen linePen = new Pen(Color.White, 4);
            bucket.DrawLine(linePen, 120, 650, 480, 650); //(x1,y1)(x2,y2) bottom piece
            bucket.DrawLine(linePen, 120, 650, 120, 500); //(x1,y1)(x2,y2) left piece
            bucket.DrawLine(linePen, 480, 650, 480, 500);//(x1,y1)(x2,y2) right piece
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colour_btn_Click(object sender, EventArgs e)
        {

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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
