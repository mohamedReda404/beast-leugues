using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;

//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp8
{
    public partial class leagues_form : Form
    {
        Label lbl_1 = new Label();
        Label lbl_2 = new Label();
        Label lbl_3 = new Label();
        Label lbl_4 = new Label();

        Label lbl_5 = new Label();
        PictureBox pictureBox1 = new PictureBox();
        PictureBox pictureBox2 = new PictureBox();
        PictureBox pictureBox3 = new PictureBox();
        PictureBox pictureBox4 = new PictureBox();
        PictureBox pictureBox5 = new PictureBox();
        PictureBox pictureBox6 = new PictureBox();

        Label lbl_6 = new Label();
        Label lbl_7 = new Label();
        Label lbl_8 = new Label();
        Label lbl_9 = new Label();
        Label lbl_10 = new Label();
        public leagues_form()
        {
            InitializeComponent();
            this.Load += lbl_1_m;

        }
        private void lbl_1_m(object sender, EventArgs e)
        {
           // this.Controls.Add(lbl_1);
           // this.Controls.Add(lbl_2);
           // this.Controls.Add(lbl_3);
           // this.Controls.Add(lbl_4);
           // this.Controls.Add(pictureBox1);
           // this.Controls.Add(pictureBox2);
          //  this.Controls.Add(pictureBox3);
           // this.Controls.Add(pictureBox4);
           // this.Controls.Add(pictureBox5);
           //// this.Controls.Add(pictureBox6);
            this.Controls.Add(lbl_5);
            this.Controls.Add(lbl_6);
            this.Controls.Add(lbl_7);
            this.Controls.Add(lbl_8);
            this.Controls.Add(lbl_9);
            //this.Controls.Add(lbl_10);

            //form_main
            this.BackColor = Color.FromArgb(52, 53, 65);


            //lbl_1
          
            lbl_1.Text = $"Hello ";
            lbl_1.ForeColor = SystemColors.ButtonHighlight;
            lbl_1.Location = new Point(38, 38);
            lbl_1.Size = new Size(156, 32);
            lbl_1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));


            //lbl_2
            lbl_2.Text = "Here is a List of the best football leagues";
            lbl_2.ForeColor = SystemColors.ButtonHighlight;
            lbl_2.Location = new Point(39, 85);
            lbl_2.Size = new Size(360, 25);
            lbl_2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));


            //lbl_3
            lbl_3.Text = "And Some information about the clubs of each league";
            lbl_3.ForeColor = SystemColors.ButtonHighlight;
            lbl_3.Location = new Point(39, 133);
            lbl_3.Size = new Size(475, 25);
            lbl_3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));

            //lbl_4
            lbl_4.Text = "Click to view...";
            lbl_4.ForeColor = Color.Red;
            lbl_4.Location = new Point(39, 171);
            lbl_4.Size = new Size(135, 25);
            lbl_4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));


            //lbl_5
            lbl_5.Text = "  ^  ";
            lbl_5.BackColor = Color.FromArgb(80, Color.Black);
            // lbl_5.ForeColor = SystemColors.ButtonHighlight;
            lbl_5.ForeColor = Color.Black;
            lbl_5.BackColor = Color.FromArgb(0, Color.White);
            lbl_5.Location = new Point(60, 254);
            lbl_5.Size = new Size(50, 29);
            lbl_5.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_5.Click += clbl5;

            //image_primar_league
            pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.pngwing_com__4_;
            pictureBox1.Location = new Point(271, 237);
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Click += clbl5;

            //lbl_6
            lbl_6.Text = " ^ ";
            lbl_6.ForeColor = Color.Black;
            lbl_6.BackColor = Color.FromArgb(0, Color.White);
            lbl_6.Location = new Point(530, 250);
            lbl_6.Size = new Size(50, 29);
            lbl_6.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_6.Click += clbl6;
            //image_serie A
            pictureBox2.Image = global::WindowsFormsApp8.Properties.Resources.Lega_Serie_A;
            pictureBox2.Location = new Point(271, 297);
            pictureBox2.Size = new Size(64, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Click += clbl6;
            //lbl_7
            lbl_7.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
           // lbl_7.ForeColor = SystemColors.ButtonHighlight;
            lbl_7.Location = new Point(410, 260);
            lbl_7.ForeColor = Color.Black;
            lbl_7.BackColor = Color.FromArgb(0, Color.White);
            
            lbl_7.Size = new Size(50, 29);
            lbl_7.Text = " ^ ";
            lbl_7.Click += clbl7;
            //image_Ligue1
            pictureBox3.Image = global::WindowsFormsApp8.Properties.Resources.Ligue_1_Uber_Eats;
            pictureBox3.Location = new Point(262, 364);
            pictureBox3.Size = new Size(82, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Click += clbl7;
            //lbl_8
            lbl_8.AutoSize = true;
            lbl_8.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
           // lbl_8.ForeColor = SystemColors.ButtonHighlight;
            lbl_8.Location = new Point(280, 245);
            // lbl_8.BackColor = Color.FromArgb(80, Color.Black);
            lbl_8.ForeColor = Color.Black;
            lbl_8.BackColor = Color.FromArgb(0, Color.White);
            lbl_8.Size = new Size(50, 29);
            lbl_8.Text = " ^ ";
            lbl_8.Click += clbl8;
            //image_Bundesliga
            pictureBox4.Image = global::WindowsFormsApp8.Properties.Resources._584d86b2367b6a13e54477d5;
            pictureBox4.Location = new Point(691, 237);
            pictureBox4.Size = new Size(69, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Click += clbl8;
            //lbl_9

            lbl_9.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
           // lbl_9.ForeColor = SystemColors.ButtonHighlight;
            lbl_9.Location = new Point(180, 250);
            lbl_9.ForeColor = Color.Black;
            lbl_9.BackColor = Color.FromArgb(0, Color.White);
            lbl_9.Size = new Size(50, 25);
            lbl_9.Text = " ^ ";
            lbl_9.Click += clbl9;
            //image_Laliga

            pictureBox5.Image = global::WindowsFormsApp8.Properties.Resources.images;
            pictureBox5.Location = new Point(690, 295);
            pictureBox5.Size = new Size(68, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.Click += clbl9;

            //lbl_10

            lbl_10.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_10.ForeColor = SystemColors.ButtonHighlight;
            lbl_10.Location = new Point(450, 375);
            lbl_10.Size = new Size(70, 29);
            lbl_10.Text = "Egyptian Premier League";
            lbl_10.Click += clbl10;
            //image_egypt

            pictureBox6.Image = global::WindowsFormsApp8.Properties.Resources._20210719092337_Epl110;
            pictureBox6.Location = new Point(691, 364);
            pictureBox6.Size = new Size(67, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.Click += clbl10;
           // panel1.Click += panel1_Paint;
        }
        
        private void clbl5(object sender, EventArgs e)
        {
            premier_league pr = new premier_league();
            pr.ShowDialog();
        }
        private void clbl6(object sender, EventArgs e)
        {
            Serie_A se = new Serie_A();
            se.ShowDialog();
        }
        private void clbl7(object sender, EventArgs e)
        {
            Ligue_1 ligue = new Ligue_1();
            ligue.ShowDialog();
        }
        private void clbl8(object sender, EventArgs e)
        {
            Bundesliga bn = new Bundesliga();
            bn.ShowDialog();
        }
        private void clbl9(object sender, EventArgs e)
        {
            Laliga laliga = new Laliga();
            laliga.ShowDialog();
        }
        private void clbl10(object sender, EventArgs e)
        {
            Egyptian_premier_league eg = new Egyptian_premier_league();
            eg.ShowDialog();
        }
        private void img1(object sender, EventArgs e)
        {
            premier_league pr = new premier_league();
            pr.ShowDialog();
        }
        private void img2(object sender, EventArgs e)
        {
            Serie_A se = new Serie_A();
            se.ShowDialog();
        }
        private void img3(object sender, EventArgs e)
        {
            Ligue_1 ligue = new Ligue_1();
            ligue.ShowDialog();
        }
        private void img4(object sender, EventArgs e)
        {
            Bundesliga bn = new Bundesliga();
            bn.ShowDialog();
        }
        private void img5(object sender, EventArgs e)
        {
            Laliga laliga = new Laliga();
            laliga.ShowDialog();
        }
        private void img6(object sender, EventArgs e)
        {
            Egyptian_premier_league eg = new Egyptian_premier_league();
            eg.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            premier_league pr = new premier_league();
            pr.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Laliga laliga = new Laliga();
            laliga.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

            Bundesliga bn = new Bundesliga();
            bn.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Ligue_1 ligue = new Ligue_1();
            ligue.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Serie_A se = new Serie_A();
            se.ShowDialog();
        }
    }
}
    

