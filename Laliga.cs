using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Laliga : Form
    {
        public Laliga()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private readonly object pictureBox5;
        /*Label label1 = new Label();
        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button button4 = new Button();
        Button button5 = new Button();
        Button button6 = new Button();*/
        PictureBox picturebox1 = new PictureBox();
        PictureBox picturebox2 = new PictureBox();
        PictureBox picturebox3 = new PictureBox();
        PictureBox picturebox4 = new PictureBox();
        PictureBox picturebox5 = new PictureBox();
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Laliga";
            BackColor = Color.FromArgb(52, 53, 65);
            // label1            
          /*  Controls.Add(label1);
            label1.Location = new Point(12, 9);
            label1.Size = new Size(236, 18);
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Text = "Welcome to the Ligue_1";
            // 
            // button1
            // 
            Controls.Add(button1);
            button1.Location = new Point(317, 51);
            button1.Size = new Size(144, 48);
            button1.BackColor = Color.FromArgb(52, 53, 65);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Text = "Barcelona";
            // 
            // button2
            // 
            Controls.Add(button2);
            button2.Location = new Point(128, 123);
            button2.Size = new Size(144, 48);
            button2.BackColor = Color.FromArgb(52, 53, 65);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Text = " Real Madrid";
            // 
            // button3
            // 
            Controls.Add(button3);
            button3.Location = new Point(467, 123);
            button3.Size = new Size(144, 48);
            button3.BackColor = Color.FromArgb(52, 53, 65);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Text = "Atletico Madrid";

            // 
            // button4
            // 
            Controls.Add(button4);
            button4.Location = new Point(128, 222);
            button4.Size = new Size(144, 48);
            button4.BackColor = Color.FromArgb(52, 53, 65);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Text = "Seville";
            // button5
            // 
            Controls.Add(button5);
            button5.Location = new Point(467, 222);
            button5.Size = new Size(144, 48);
            button5.BackColor = Color.FromArgb(52, 53, 65);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Text = "Valencia";

            // button6
            // 
            Controls.Add(button6);
            button6.Location = new Point(339, 350);
            button6.Size = new Size(90, 46);
            button6.BackColor = Color.FromArgb(52, 53, 65);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.TabIndex = 11;
            button6.Text = "Exit";*/
            //pictureBox1
            Controls.Add(picturebox1);
            picturebox1.Image = Properties.Resources.صورة_واتساب_بتاريخ_2023_12_17_في_21_27_24_c305b5eb;
            picturebox1.BackColor = Color.FromArgb(0, Color.White);
            picturebox1.Location = new Point(467, 51);
            picturebox1.Size = new Size(66, 48);
            picturebox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //
            // pictureBox2
            Controls.Add(picturebox2);
            picturebox2.Image = Properties.Resources.صورة_واتساب_بتاريخ_2023_12_17_في_21_33_25_dfe46b10;
            picturebox2.BackColor = Color.FromArgb(0, Color.White);
            picturebox2.Location = new Point(278, 250);
            picturebox2.Size = new Size(58, 51);
            picturebox2.SizeMode = PictureBoxSizeMode.StretchImage;
            //
            // pictureBox3
            Controls.Add(picturebox3);
            picturebox3.Image = Properties.Resources.صورة_واتساب_بتاريخ_2023_12_17_في_21_33_30_26e2326f;
            picturebox3.BackColor = Color.FromArgb(0, Color.White);
            picturebox3.Location = new Point(467, 250);
            picturebox3.Size = new Size(58, 51);
            picturebox3.SizeMode = PictureBoxSizeMode.StretchImage;

            //
            // pictureBox4

            Controls.Add(picturebox4);
            picturebox4.Image = Properties.Resources.صورة_واتساب_بتاريخ_2023_12_17_في_21_28_11_5a1854ae;
            picturebox4.BackColor = Color.FromArgb(0, Color.White);
            picturebox4.Location = new Point(278, 51);
            picturebox4.Name = "pictureBox4";
            picturebox4.Size = new Size(58, 51);
            picturebox4.SizeMode = PictureBoxSizeMode.StretchImage;
            //
            // pictureBox5
          /*  this.Controls.Add(picturebox5);

            picturebox5.Image = Properties.Resources.صورة_واتساب_بتاريخ_2023_12_17_في_21_37_57_bdd32cac;
            picturebox5.Location = new Point(617, 222);
            picturebox5.Name = "pictureBox5";
            picturebox5.Size = new Size(58, 51);
            picturebox5.SizeMode = PictureBoxSizeMode.StretchImage;*/
            //
          //  button6.Click += exit_Click;
            picturebox1.Click += Button1_Click;
            picturebox2.Click += Button2_Click;
            picturebox3.Click += Button3_Click;
            picturebox4.Click += Button4_Click;
           // button5.Click += Button5_Click;

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Barcelona Club:\r\n\r\nCountry: Spain\r\nFounded: 1899\r\nNickname: Barça\r\nStadium: Camp Nou\r\nMajor Honors: Barcelona has won numerous domestic and international titles, including 26 La Liga championships, 31 Copa del Rey titles, and 5 UEFA Champions League titles.\r\nFanbase: Barcelona has a large and passionate fanbase that extends beyond Spain and is known for its \"culés\" supporters.");
        }
        private void Button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Real Madrid:\r\n\r\nCountry: Spain\r\nFounded: 1902\r\nNickname: Los Blancos\r\nStadium: Santiago Bernabéu (currently under renovation and temporary games at Estadio Alfredo Di Stéfano)\r\nMajor Honors: Real Madrid is one of the most successful clubs in the world, with 34 La Liga titles, 19 Copa del Rey titles, and a record 13 UEFA Champions League titles.\r\nFanbase: Real Madrid has a large and dedicated fanbase both in Spain and internationally, known as \"Madridistas.\"");
        }
        private void Button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Atletico Madrid\r\nCountry: Spain\r\nFounded: 26 April 1903\r\nNickname: Los Colchoneros (The Mattress Makers)\r\nStadium: Wanda Metropolitano\r\nMajor Honors: 10 La Liga titles, 10 Copa del Rey titles, 3 UEFA Europa League titles, 3 UEFA Super Cup titles\r\nFanbase: Known for having a passionate and loyal fanbase, with \"Ultras Sur\" being the club's most prominent supporter group.");
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valencia Club de Fútbol is based in Valencia, Spain. It was founded on March 18, 1919. The club is commonly known as \"Los Che\" or \"La Real\" by its fans.\r\n\r\nValencia plays its home matches at the Mestalla Stadium, which has a capacity of over 48,000. The team has a significant fanbase, both locally and internationally, known for their passionate support for the club.\r\n\r\nThe club has achieved major honors including six La Liga titles, seven Copa del Rey titles, and one UEFA Cup (now Europa League) among others. Valencia also has a strong history in European competitions, regularly competing in the UEFA Champions League.\r\n\r\nOverall, Valencia CF is one of the most prominent and successful football clubs in Spain with a rich history, strong fanbase, and a track record of success in domestic and international competitions.");
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seville Club:\r\n\r\n- Country: Spain\r\n- Founded: 1890\r\n- Nickname: Los Rojiblancos (The Red and Whites)\r\n- Stadium: Ramón Sánchez Pizjuán\r\n- Major honors: 6 UEFA Europa League titles, 1 Spanish La Liga title, 5 Copa del Rey titles\r\n- Fanbase: Sevilla FC has a large and passionate fanbase, with a strong presence in the city of Seville and a significant following across Spain");

        }
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    

