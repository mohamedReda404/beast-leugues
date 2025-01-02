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
    public partial class Ligue_1 : Form
    {
       // Label label1 = new Label();
       // Button button1 = new Button();
      //  Button button2 = new Button();
       // Button button3 = new Button();
     //   Button button6 = new Button();
        PictureBox picturebox1 = new PictureBox();
        PictureBox picturebox2 = new PictureBox();
        PictureBox picturebox3 = new PictureBox();
        PictureBox picturebox4 = new PictureBox();
        PictureBox picturebox5 = new PictureBox();
        public Ligue_1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Ligue_1";
            this.BackColor = Color.FromArgb(52, 53, 65);
/*
            // label1
            // 
            this.Controls.Add(label1);
            label1.Location = new Point(12, 9);
            label1.Size = new Size(236, 18);
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.TabIndex = 0;
            label1.Text = "Welcome to league 1";
            // 
            // button1
            // 
            this.Controls.Add(button1);
            button1.Location = new Point(317, 100);
            button1.Size = new Size(144, 48);
            button1.BackColor = Color.FromArgb(52, 53, 65);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.TabIndex = 1;
            button1.Text = "Paris Saint Germain";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.Controls.Add(button2);
            button2.Location = new Point(128, 270);
            button2.Size = new Size(144, 48);
            button2.BackColor = Color.FromArgb(52, 53, 65);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.TabIndex = 3;
            button2.Text = "Marseille ";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.Controls.Add(button3);
            button3.Location = new Point(467, 270);
            button3.Size = new Size(144, 48);
            button3.BackColor = Color.FromArgb(52, 53, 65);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.TabIndex = 5;
            button3.Text = "Saint-Étienne";
            button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.Controls.Add(button6);
            button6.Location = new Point(339, 406);
            button6.Size = new Size(90, 46);
            button6.BackColor = Color.FromArgb(52, 53, 65);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.TabIndex = 11;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = false;*/
            // 
            // pictureBox1
            PictureBox pictureBox1 = new PictureBox();
            this.Controls.Add(pictureBox1);

            pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.psg_removebg_preview;
            pictureBox1.BackColor = Color.FromArgb(0, Color.White);
            pictureBox1.Location = new Point(390, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            //
            // pictureBox2
            PictureBox pictureBox2 = new PictureBox();
            this.Controls.Add(pictureBox2);

            pictureBox2.Image = global::WindowsFormsApp8.Properties.Resources.marcellia_removebg_preview;
            pictureBox2.BackColor = Color.FromArgb(0, Color.White);
            pictureBox2.Location = new Point(150, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            //
            // pictureBox3

            PictureBox pictureBox3 = new PictureBox();
            this.Controls.Add(pictureBox3);

            pictureBox3.Image = global::WindowsFormsApp8.Properties.Resources.saint_etienne_removebg_preview;
            pictureBox3.Location = new Point(617, 270);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            //
            //  pictureBox1.Click += exit_Click;
            // pictureBox1.Click += Button1_Click;
            pictureBox2.Click += button2_Click;
            pictureBox1.Click += button3_Click;

        }
        /*   private void Button1_Click(object sender, EventArgs e)
           {

               TextBox textBox1 = new TextBox();

               this.Controls.Add(textBox1);
               textBox1.Location = new Point(100, 30);
               textBox1.Multiline = true;
               textBox1.ReadOnly = true;

               string information = "                                             Paris Saint-Germain:\r\n" +
                   "Nickname: PSG\r\n" +
                   "Founded: August 12, 1970\r\n" +
                   "Location: Paris, France\r\n" +
                   "Stadium: Parc des Princes\r\n" +
                   "Honors:\r\n" +
                   "Ligue 1\r\n" +
                   "Coupe de la Ligue         Coupe de France \r\n" +
                   "PSG has also had success in European competitions, reaching the UEFA Champions League final.\r\n";



               textBox1.Text = information;

               Font font = new Font("Tahoma", 10.0f, FontStyle.Regular);
               textBox1.Font = font;


               Size size = TextRenderer.MeasureText(textBox1.Text, textBox1.Font);
               textBox1.Size = new Size(size.Width + 10, size.Height + 10);


               textBox1.BringToFront();
           }
           private void Button2_Click(object sender, EventArgs e)
           {

               TextBox textBox2 = new TextBox();

               this.Controls.Add(textBox2);
               textBox2.Location = new Point(100, 105);
               textBox2.Multiline = true;
               textBox2.ReadOnly = true;


               string information = "                            Marseille :\r\n" +
                   "Foundation: Marseille was founded on August 31, 1899, making it one of the oldest football clubs in France.\r\n" +
                   "Stadium: The club plays its home matches at the Stade Vélodrome, located in Marseille\r\n" +
                   " France. The stadium is known for its passionate atmosphere and is one of the largest in France\r\n" +
                   "Colors and Crest: Marseille's colors are blue and white. \r\n" +
                   "Achievements: \r\n" +
                   "Marseille has a rich history of success. The club has won the French Ligue 1 title multiple times and has also achieved success in domestic cup competitions\r\n" +
                   "Fanbase: The club has a passionate fanbase and is known for its fervent supporters\r\n" +
                   "Notable Players:\r\n" +
                   "Marseille has been home to many notable football players throughout its history. \r\n" +
                   "layers like Jean-Pierre Papin, Didier Deschamps, Franck Ribéry, and Eric Cantona ";






               // Set the text
               textBox2.Text = information;

               // Set font size and style
               Font font = new Font("Tahoma", 10.0f, FontStyle.Regular);
               textBox2.Font = font;

               // Adjust size to fit content
               Size size = TextRenderer.MeasureText(textBox2.Text, textBox2.Font);
               textBox2.Size = new Size(size.Width + 10, size.Height + 10); // Add padding
               textBox2.BringToFront();
           }
           private void Button3_Click(object sender, EventArgs e)
           {

               TextBox textBox3 = new TextBox();

               this.Controls.Add(textBox3);
               textBox3.Location = new Point(100, 105);
               textBox3.Multiline = true;
               textBox3.ReadOnly = true;

               string information = "                                      Saint-Étienne :\r\n" +
                   "Nickname: Les Verts (The Greens)\r\n" +
                   "Founded: November 1919\r\n" +
                   "Location: Saint-Étienne, France\r\n" +
                   "Stadium: Stade Geoffroy-Guichard\r\n" +
                   "Honors:\r\n" +
                   "Ligue 1     Coupe de France\r\n" +
                   "AS Saint-Étienne is one of the most successful football clubs in French football history\r\n" +
                   " known for its passionate fanbase and historical\r\n" +
                   "achievements. The club has had periods of great success\r\n" +
                   " particularly in the 1960s and 1970s when they were a dominant force in French and European football. ";


               // Set the text
               textBox3.Text = information;

               // Set font size and style
               Font font = new Font("Tahoma", 10.0f, FontStyle.Regular);
               textBox3.Font = font;

               // Adjust size to fit content
               Size size = TextRenderer.MeasureText(textBox3.Text, textBox3.Font);
               textBox3.Size = new Size(size.Width + 10, size.Height + 10); // Add padding
               textBox3.BringToFront();
           }

           private void exit_Click(object sender, EventArgs e)
           {
               Application.Exit();
           }
        */
        private void button2_Click(object sender, EventArgs e)
        {


            string information = "Marseille :\r\n" +
                                 "Foundation: Marseille was founded on August 31, 1899, making it one of the oldest football clubs in France.\r\n" +
                                 "Stadium: The club plays its home matches at the Stade Vélodrome, located in Marseille\r\n" +
                                 " France. The stadium is known for its passionate atmosphere and is one of the largest in France\r\n" +
                                 "Colors and Crest: Marseille's colors are blue and white. \r\n" +
                                 "Achievements: \r\n" +
                                 "Marseille has a rich history of success. The club has won the French Ligue 1 title multiple times and has also achieved success in domestic cup competitions\r\n" +
                                 "Fanbase: The club has a passionate fanbase and is known for its fervent supporters\r\n" +
                                 "Notable Players:\r\n" +
                                 "Marseille has been home to many notable football players throughout its history. \r\n" +
                                 "layers like Jean-Pierre Papin, Didier Deschamps, Franck Ribéry, and Eric Cantona ";

            MessageBox.Show(information, "Marseille Information");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                string information = "Saint-Étienne :\r\n" +
                                     "Nickname: Les Verts (The Greens)\r\n" +
                                     "Founded: November 1919\r\n" +
                                     "Location: Saint-Étienne, France\r\n" +
                                     "Stadium: Stade Geoffroy-Guichard\r\n" +
                                     "Honors:\r\n" +
                                     "Ligue 1     Coupe de France\r\n" +
                                     "AS Saint-Étienne is one of the most successful football clubs in French football history\r\n" +
                                     " known for its passionate fanbase and historical\r\n" +
                                     "achievements. The club has had periods of great success\r\n" +
                                     " particularly in the 1960s and 1970s when they were a dominant force in French and European football. ";

                MessageBox.Show(information, "Saint-Étienne Information");
            }
        }
    }
}

    

    

