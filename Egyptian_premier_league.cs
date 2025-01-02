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
    public partial class Egyptian_premier_league : Form

    {

        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button button4 = new Button();
        Button button5 = new Button();
        PictureBox pictureBox1 = new PictureBox();
        PictureBox pictureBox2 = new PictureBox();
        PictureBox pictureBox3 = new PictureBox();
        PictureBox pictureBox4 = new PictureBox();
        PictureBox pictureBox5 = new PictureBox();
        Label label1 = new Label();
        Button button6 = new Button();

        public Egyptian_premier_league()
        {
            InitializeComponent();
            this.Load += sho_2;

        }

        private void sho_2(object sender, EventArgs e)
        {
            // 
            // button1
            // 
            button1.Location = new Point(285, 82);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Al Ahly";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(535, 192);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Al Zamalek";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(46, 192);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Al Ismaily";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(535, 380);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Al Masry";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(58, 380);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "Al Ittihad";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.شعار_النادي_الأهلي_المصري;
            pictureBox1.Location = new Point(385, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.شعار_نادي_الزمالك_المصري;
            pictureBox2.Location = new Point(635, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Masry_removebg_preview__1_;
            pictureBox3.Location = new Point(635, 361);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(115, 77);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = global::WindowsFormsApp8.Properties.Resources.pngwing_com__6_;
            pictureBox4.Location = new Point(146, 174);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 73);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = global::WindowsFormsApp8.Properties.Resources.download_removebg_preview__1_;
            pictureBox5.Location = new Point(169, 361);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(114, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 22);
            label1.Name = "label1";
            label1.Size = new Size(310, 18);
            label1.TabIndex = 10;
            label1.Text = "Welcome to the Egyption league";
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
            button6.Location = new Point(331, 465);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 11;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 523);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
         
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Al Ahly Sporting Club:\r\n\r\nCountry: Egypt\r\nFounded: 1907\r\nNickname: The Red Devils\r\nStadium: Al Ahly plays its home matches at the Cairo International Stadium, located in Cairo, Egypt.\r\nManager (as of January 2022): Pitso Mosimane\r\nMajor Honors:\r\nAl Ahly is one of the most successful football clubs in Africa and the Middle East.\r\nCAF Champions League Titles: Al Ahly has won the CAF Champions League multiple times.\r\nCAF Super Cup Titles: Success in the CAF Super Cup competition.\r\nDomestic Success:\r\nAl Ahly has dominated Egyptian football, winning numerous domestic league titles and Egypt Cups.\r\nInternational Recognition:\r\nAl Ahly is widely recognized as one of the most successful clubs in African football history.\r\nThe club has a strong fan base and is considered a powerhouse in continental competitions.\r\nFamous Players:\r\nOver the years, Al Ahly has been home to many talented players, both local and international.\r\nFanbase:\r\nAl Ahly boasts a passionate and dedicated fanbase, known for their unwavering support.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zamalek Sporting Club:\r\n\r\nCountry: Egypt\r\nFounded: 1911\r\nNickname: The White Knights\r\nStadium: Zamalek plays its home matches at Cairo International Stadium, located in Cairo, Egypt, or at Petro Sport Stadium.\r\nMajor Honors:\r\nZamalek is one of the most successful football clubs in Egypt and Africa.\r\nCAF Champions League Titles: Zamalek has won the CAF Champions League multiple times.\r\nCAF Super Cup Titles: Success in the CAF Super Cup competition.\r\nDomestic Success:\r\nZamalek has a rich history of success in Egyptian football, winning numerous domestic league titles and Egypt Cups.\r\nInternational Recognition:\r\nZamalek is recognized as one of the top football clubs in Africa and has competed in various continental competitions.\r\nFamous Players:\r\nOver the years, Zamalek has been home to many talented players, both local and international.\r\nFanbase:\r\nZamalek has a passionate and dedicated fanbase, known for their support in both domestic and international competitions.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Al-Ismaily Sporting Club:\r\n\r\nCountry: Egypt\r\nFounded: 1924\r\nNickname: The Yellow Dragons\r\nStadium: Ismailia Stadium, located in Ismailia, Egypt.\r\nMajor Honors:\r\nAl-Ismaily has had success in Egyptian football, winning domestic league titles and Egypt Cups.\r\nDomestic Success:\r\nThe club has a history of competing at the top levels of Egyptian football and has enjoyed success in various domestic competitions.\r\nAfrican Competitions:\r\nAl-Ismaily has participated in continental competitions, including the CAF Champions League and the CAF Confederation Cup.\r\nFanbase:\r\nAl-Ismaily has a dedicated fanbase that supports the team in both home and away matches.\r\nClub Colors: Yellow and black are the traditional colors of Al-Ismaily.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Al Masry Sporting Club:\r\n\r\nCountry: Egypt\r\nFounded: 1920\r\nNickname: Green Eagles\r\nStadium: Port Said Stadium, located in Port Said, Egypt.\r\nMajor Honors:\r\nAl Masry has participated in domestic league competitions and Egypt Cups.\r\nDomestic Success:\r\nThe club has a history of competing in the top tiers of Egyptian football.\r\nAfrican Competitions:\r\nAl Masry has participated in continental competitions, including the CAF Confederation Cup.\r\nPort Said Stadium Tragedy:\r\nIn 2012, a tragic incident occurred during a match between Al Masry and Al Ahly at Port Said Stadium, resulting in several casualties.\r\nFanbase:\r\nAl Masry has a dedicated fanbase that supports the team in both home and away matches.\r\nClub Colors: Green and white are the traditional colors of Al Masry.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Al Ittihad Alexandria Club:\r\n\r\nCountry: Egypt\r\nBased in: Alexandria\r\nLeague: Egyptian Premier League\r\nNickname: The Alexandria Union\r\nStadium: Borg El Arab Stadium (Alexandria)\r\nAchievements: Al Ittihad Alexandria has a history of participating in Egyptian football competitions, including the Egyptian Premier League and domestic cup competitions.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
