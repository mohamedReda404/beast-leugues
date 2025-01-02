using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.Properties;

namespace WindowsFormsApp8
{
    public partial class Serie_A : Form
    {
       
     //   Button button1 = new Button();
      //  Button button2 = new Button();
      //  Button button3 = new Button();
      //  Button button4 = new Button();
       // Button button5 = new Button();
     //   Button button6 = new Button();

        PictureBox pictureBox1 = new PictureBox();
        PictureBox pictureBox2 = new PictureBox();
        PictureBox pictureBox3 = new PictureBox();
        PictureBox pictureBox4 = new PictureBox();
        PictureBox pictureBox5 = new PictureBox();
      //  Label label2 = new Label();
        public Serie_A()
        {
            InitializeComponent();
            this.Load += sho_items;
        }
        private void sho_items(object sender, EventArgs e) {
          //  Controls.Add(label2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
         //   Controls.Add(button6);
           // Controls.Add(button5);
         //   Controls.Add(button4);
           // Controls.Add(button3);
          //  Controls.Add(button2);
         //   Controls.Add(button1);
            // 
            // button1
           /* // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Location = new Point(276, 69);
             button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Juventus";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Location = new Point(530, 171);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Inter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.Location = new Point(49, 171);
        button3.Name = "button3";
            button3.Size = new Size(94, 29);
        button3.TabIndex = 2;
            button3.Text = "Napoli";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.Location = new Point(530, 291);
        button4.Name = "button4";
            button4.Size = new Size(94, 29);
        button4.TabIndex = 3;
            button4.Text = "Roma";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateGray;
            button5.Location = new Point(62, 305);
        button5.Name = "button5";
            button5.Size = new Size(94, 29);
        button5.TabIndex = 4;
            button5.Text = "Lazio";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSeaGreen;
            button6.Location = new Point(353, 476);
        button6.Name = "button6";
            button6.Size = new Size(94, 29);
        button6.TabIndex = 5;
            button6.Text = "Exit";
         
            button6.Click += button6_Click_1;*/
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.ro_1;
            pictureBox1.Click += button1_Click;
            pictureBox1.BackColor = Color.FromArgb(0, Color.White);
            pictureBox1.Location = new Point(450, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = global::WindowsFormsApp8.Properties.Resources.ro_2;
            pictureBox2.Click += button2_Click_1;
            pictureBox2.BackColor = Color.FromArgb(0, Color.White);
            pictureBox2.Location = new Point(700, 200);
        pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 62);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = global::WindowsFormsApp8.Properties.Resources.ro_3;
            pictureBox3.Click += button3_Click_1;
            pictureBox3.BackColor = Color.FromArgb(0, Color.White);
            pictureBox3.Location = new Point(200, 200);
        pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = global::WindowsFormsApp8.Properties.Resources.ro_4;
            pictureBox4.BackColor = Color.FromArgb(0, Color.White);
            pictureBox4.Click += button5_Click_1;
            pictureBox4.Location = new Point(220, 340);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = global::WindowsFormsApp8.Properties.Resources.roma;
            pictureBox5.Click += button4_Click_1;
            pictureBox5.BackColor = Color.FromArgb(0, Color.White);
            pictureBox5.Location = new Point(700, 340);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(111, 73);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
          /*  label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(25, 24);
        label2.Name = "label2";
            label2.Size = new Size(249, 42);
        label2.TabIndex = 12;
            label2.Text = "Welcome to the Serie A\r\n ";*/
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
      
            }
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Juventus, founded in 1897, is an Italian football giant known for its black and white striped jerseys. Competing in Serie A, the club has a storied history, claiming numerous domestic titles and triumphs in European competitions. The Allianz Stadium in Turin witnesses the fervor of fans as they rally behind their team. With a legacy of legendary players and iconic moments, Juventus stands as a symbol of excellence in Italian and international football.");

        }







        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Napoli, founded in 1926, is a prominent Italian football club known for its vibrant style of play and passionate fanbase. Sporting the colors of sky blue and white, the team has achieved success in Serie A, clinching titles and leaving an indelible mark on Italian football. The Stadio Diego Armando Maradona serves as their home ground, named after the legendary Argentine player who graced Napoli with his brilliance in the late '80s. Napoli's journey is a tale of resilience, flair, and a distinctive identity in the beautiful game.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Inter Milan, established in 1908, is a powerhouse in Italian football. Adorned in blue and black, the club has a rich history marked by domestic and international triumphs, including Serie A titles and UEFA Champions League successes. The San Siro Stadium witnesses the passion of fans, creating an electric atmosphere during matches. Inter Milan's emblem, featuring a serpent devouring a human, symbolizes their tenacity on the field. With legendary players and a fervent fanbase, Inter Milan remains a symbol of resilience and excellence in the beautiful game.");

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Lazio, founded in 1900, is a renowned Italian football club distinguished by its royal blue and white colors. Competing in Serie A, Lazio has earned its place in football history with domestic and international successes. The Stadio Olimpico serves as the team's home, hosting unforgettable moments for both players and passionate supporters. Lazio's journey embodies the spirit of Italian football, combining tradition, skill, and a fervent fanbase that adds vibrancy to every match.");

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Roma, established in 1927, is a revered Italian football club recognized for its historical significance and passionate following. Clad in iconic maroon and gold, Roma has left an indelible mark in Serie A, competing at the pinnacle of Italian football. The Stadio Olimpico, their home ground, witnesses the fervor of fans as they cheer for their beloved team. AS Roma's journey is a blend of triumphs, captivating performances, and an enduring legacy in the heart of Italian football.");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
          /*  FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize) pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize) pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize) pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize) pictureBox4).EndInit();
        ((System.ComponentModel.ISupportInitialize) pictureBox5).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

#endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;
    private Label label2;
}
}*/
    

