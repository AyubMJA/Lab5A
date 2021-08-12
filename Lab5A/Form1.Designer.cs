
namespace Lab5A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colour_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // colour_btn
            // 
            this.colour_btn.Location = new System.Drawing.Point(136, 103);
            this.colour_btn.Name = "colour_btn";
            this.colour_btn.Size = new System.Drawing.Size(200, 70);
            this.colour_btn.TabIndex = 0;
            this.colour_btn.Text = "Colour";
            this.colour_btn.UseVisualStyleBackColor = true;
            this.colour_btn.Click += new System.EventHandler(this.colour_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(915, 103);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(234, 70);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 150);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(915, 246);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(208, 90);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1752, 764);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.colour_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button colour_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

