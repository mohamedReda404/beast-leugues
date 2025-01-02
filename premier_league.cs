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
    public partial class premier_league : Form
    {
        private readonly object pictureBox5;
        //  Label label1 = new Label();
        //  Button button1 = new Button();
        //  Button button2 = new Button();
        //  Button button3 = new Button();
        //  Button button4 = new Button();
        //  Button button5 = new Button();
        //  Button button6 = new Button();
        PictureBox picturebox1 = new PictureBox();
        PictureBox picturebox2 = new PictureBox();
        PictureBox picturebox3 = new PictureBox();
        PictureBox picturebox4 = new PictureBox();
        PictureBox picturebox5 = new PictureBox();
        public premier_league()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Premier League";
            this.BackColor = Color.FromArgb(52, 53, 65);

            /*   // label1
               // 
               this.Controls.Add(label1);
               label1.Location = new Point(12, 9);
               label1.Size = new Size(236, 18);
               label1.AutoSize = true;
               label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
               label1.ForeColor = Color.Goldenrod;
               label1.TabIndex = 0;
              // label1.Text = "Welcome to the primier league";
               // 
               // button1
               // 
               this.Controls.Add(button1);
               button1.Location = new Point(317, 51);
               button1.Size = new Size(144, 48);
               button1.BackColor = Color.FromArgb(52, 53, 65);
               button1.FlatStyle = FlatStyle.Flat;
               button1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
               button1.ForeColor = Color.White;
               button1.TabIndex = 1;
               button1.Text = "Manchester United";
               button1.UseVisualStyleBackColor = false;
               // 
               // button2
               // 
               this.Controls.Add(button2);
               button2.Location = new Point(128, 123);
               button2.Size = new Size(144, 48);
               button2.BackColor = Color.FromArgb(52, 53, 65);
               button2.FlatStyle = FlatStyle.Flat;
               button2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
               button2.ForeColor = Color.White;
               button2.TabIndex = 3;
               button2.Text = "Liverpool";
               button2.UseVisualStyleBackColor = false;
               // 
               // button3
               // 
               this.Controls.Add(button3);
               button3.Location = new Point(467, 123);
               button3.Size = new Size(144, 48);
               button3.BackColor = Color.FromArgb(52, 53, 65);
               button3.FlatStyle = FlatStyle.Flat;
               button3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
               button3.ForeColor = Color.White;
               button3.TabIndex = 5;
               button3.Text = "Manchester City";
               button3.UseVisualStyleBackColor = false;
               // 
               // button4
               // 
               this.Controls.Add(button4);
               button4.Location = new Point(128, 222);
               button4.Size = new Size(144, 48);
               button4.BackColor = Color.FromArgb(52, 53, 65);
               button4.FlatStyle = FlatStyle.Flat;
               button4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
               button4.ForeColor = Color.White;
               button4.TabIndex = 6;
               button4.Text = "Chelsea";
               button4.UseVisualStyleBackColor = false;
               // 
               // button5
               // 
               this.Controls.Add(button5);
               button5.Location = new Point(467, 222);
               button5.Size = new Size(144, 48);
               button5.BackColor = Color.FromArgb(52, 53, 65);
               button5.FlatStyle = FlatStyle.Flat;
               button5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
               button5.ForeColor = System.Drawing.Color.White;
               button5.TabIndex = 7;
               button5.Text = "Arsenal";
               button5.UseVisualStyleBackColor = false;
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

            pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.OIP_removebg_preview;
            pictureBox1.BackColor = Color.FromArgb(0, Color.White);
            pictureBox1.Click += Button1_Click;
            pictureBox1.Location = new Point(170, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            //
            // pictureBox2
            PictureBox pictureBox2 = new PictureBox();
            this.Controls.Add(pictureBox2);

            pictureBox2.Image = global::WindowsFormsApp8.Properties.Resources.OIP_2_removebg_preview__1_;
            pictureBox2.Click += Button2_Click;
            pictureBox2.BackColor = Color.FromArgb(0, Color.White);
            pictureBox2.Location = new Point(170, 210);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            //
            // pictureBox3

            PictureBox pictureBox3 = new PictureBox();
            this.Controls.Add(pictureBox3);

            pictureBox3.Image = global::WindowsFormsApp8.Properties.Resources.OIP_4_removebg_preview;
            pictureBox3.Click += Button3_Click;
            pictureBox3.BackColor = Color.FromArgb(0, Color.White);
            pictureBox3.Location = new Point(380, 90);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            //
            // pictureBox4
            PictureBox pictureBox4 = new PictureBox();
            this.Controls.Add(pictureBox4);

            pictureBox4.Image = global::WindowsFormsApp8.Properties.Resources.OIP_3_removebg_preview1;
            pictureBox4.Click += Button4_Click;
            pictureBox4.BackColor = Color.FromArgb(0, Color.White);
            pictureBox4.Location = new Point(380, 210);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(58, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            //
            // pictureBox5
            PictureBox pictureBox5 = new PictureBox();
            this.Controls.Add(pictureBox5);

            pictureBox5.Image = global::WindowsFormsApp8.Properties.Resources.OIP_5_removebg_preview;
            pictureBox5.Click += Button5_Click;
            pictureBox5.Location = new Point(617, 222);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 51);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            //
            /*   button6.Click += exit_Click;
               button1.Click += Button1_Click;
               button2.Click += Button2_Click;
               button3.Click += Button3_Click;
               button4.Click += Button4_Click;
               button5.Click += Button5_Click;*/

        }
        /* private void Button1_Click(object sender, EventArgs e)
         {
            TextBox textBox1= new TextBox();

             this.Controls.Add(textBox1);
            // ma1.Location = new Point(100, 30);
            // .Multiline = true;

             string information = "                                             Manchester United Football Club:\r\n" +
                                  "The greatest club in England\r\n" +
                                  "Nickname: The Red Devils\r\n" +
                                  "Founded: 1878 as Newton Heath LYR Football Club; renamed Manchester United in 1902.\r\n" +
                                  "Stadium: Old Trafford, located in Greater Manchester, England.\r\n" +
                                  "Major Honors:   English Premier League Titles\r\n" +
                                  "FA Cup Titles   UEFA Champions League Titles\r\n" +
                                  "Notable Achievements:\r\n" +
                                  "Manchester United is one of the most successful and popular football clubs globally.\r\n" +
                                  "The club has a rich history of success domestically and internationally.\r\n" +
                                  "Notable periods of success under managers like Sir Matt Busby and Sir Alex Ferguson.\r\n" +
                                  "Achieved a historic treble in the 1998-1999 season (Premier League, FA Cup, UEFA Champions League).\r\n" +
                                  "Rivalries:\r\n" +
                                  "Intense rivalries with clubs like Manchester City (Manchester Derby) and Liverpool (North West Derby).\r\n" +
                                  "Famous Players:\r\n" +
                                  "Manchester United has been home to numerous legendary players\r\n " +
                                  "George Best\r\n" +
                                  "Sir Bobby Charlton\r\n" +
                                  "Eric Cantona\r\n" +
                                  "Ryan Giggs\r\n" +
                                  "Paul Scholes\r\n" +
                                  "Cristiano Ronaldo";

             textBox1.Text = information;

             Font font = new Font("Tahoma", 10.0f, FontStyle.Regular);
             textBox1.Font = font;


             Size size = TextRenderer.MeasureText(textBox1.Text, textBox1.Font);
             textBox1.Size = new Size(size.Width + 10, size.Height + 10);


             textBox1.BringToFront();
         }
        /* private void Button2_Click(object sender, EventArgs e)
         {

             TextBox textBox2 = new TextBox();

             this.Controls.Add(textBox2);
             textBox2.Location = new Point(100, 105);
             textBox2.Multiline = true;


             string information = "                          Liverpool Football Club:\r\n" +
                                   "Nickname: The Reds\r\n" +
                                   "Founded: 1892\r\n" +
                                   "Stadium: Anfield, located in Liverpool, England.\r\n" +
                                   "Manager (as of January 2023): Jürgen Klopp\r\n" +
                                   "Major Honors: English First Division/Premier League Titles\r\n" +
                                   "FA Cup Titles    UEFA Champions League Titles\r\n" +
                                   "Notable Achievements:\r\n" +
                                   "Liverpool has a rich history and is one of the most successful clubs in English and European football.\r\n" +
                                   "The club has experienced periods of dominance, particularly in the 1970s and 1980s.\r\n" +
                                   "Achieved a historic treble in the 1976-1977 season (First Division, European Cup, League Cup).\r\n" +
                                   "Rivalries:\r\n" +
                                   "Intense rivalries with Everton (Merseyside Derby) and Manchester United.\r\n" +
                                   "Famous Players:\r\n" +
                                   "Liverpool has been home to numerous legendary players, including Kenny Dalglish\r\n" +
                                   "Steven Gerrard, Ian Rush, Robbie Fowler, and many others";





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


             string information = "                                Manchester City Football Club:\r\n" +
                                 "Nickname: The Citizens\r\n" +
                                 "Founded: 1880 as St. Mark's (West Gorton); became Manchester City in 1894.\r\n" +
                                 "Stadium: Etihad Stadium, located in Manchester, England.\r\n" +
                                 "Manager (as of January 2023): Pep Guardiola\r\n" +
                                 "Major Honors:     English Premier League Titles\r\n" +
                                 "FA Cup Titles    EFL Cup (League Cup) Titles       UEFA Cup Winners' Cup (historical)\r\n" +
                                 "Recent Achievements:\r\n" +
                                 "Manchester City has been highly successful in recent years, particularly under the management of Pep Guardiola.\r\n" +
                                 "Achieved domestic dominance with multiple Premier League titles.\r\n" +
                                 "European Success:\r\n" +
                                 "Manchester City has become a consistent contender in the UEFA Champions League, reaching the final in the 2020-2021 season.\r\n" +
                                 "Notable Players:\r\n" +
                                 "The club has attracted top talent, including players like Sergio Agüero, David Silva, Kevin De Bruyne, and Raheem Sterling.";






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
         private void Button4_Click(object sender, EventArgs e)
         {

             TextBox textBox4 = new TextBox();

             this.Controls.Add(textBox4);
             textBox4.Location = new Point(100, 105);
             textBox4.Multiline = true;

             string information = "                                Chelsea Football Club:\r\n" +
                                 "Nickname: The Blues\r\n" +
                                 "Founded: 1905\r\n" +
                                 "Stadium: Stamford Bridge, located in London, England.\r\n" +
                                 "Major Honors:      English Premier League Titles\r\n" +
                                 "Recent Achievements:\r\n" +
                                 "Chelsea has been a competitive force in English and European football, achieving success domestically and internationally.\r\n" +
                                 "Won the UEFA Champions League in the 2011-2012 and 2020-2021 seasons.\r\n" +
                                 "Consistent presence in the top tier of English football.\r\n" +
                                 "Notable Players:\r\n" +
                                 "Chelsea has had a roster of notable players over the years, including Frank Lampard, Didier Drogba, John Terry, and others.\r\n" +
                                 "Youth Development:\r\n" +
                                 "Known for its youth development system, producing talented players who have become key contributors to the first team.\r\n" +
                                 "Owner: Roman Abramovich";



             textBox4.Text = information;

             Font font = new Font("Tahoma", 10.0f, FontStyle.Regular);
             textBox4.Font = font;

             Size size = TextRenderer.MeasureText(textBox4.Text, textBox4.Font);
             textBox4.Size = new Size(size.Width + 10, size.Height + 10);
             textBox4.BringToFront();
         }
         private void Button5_Click(object sender, EventArgs e)
         {

             TextBox textBox5 = new TextBox();

             this.Controls.Add(textBox5);
             textBox5.Location = new Point(100, 90);
             textBox5.Multiline = true;

             string information = "                           Arsenal Football Club:\r\n" +
                 "Nickname: The Gunners\r\n" +
                 "Founded: 1886\r\n" +
                 "Stadium: Emirates Stadium, located in Islington, London, England.\r\n" +
                 "Manager (as of January 2023): Mikel Arteta\r\n" +
                 "Major Honors:      English Premier League Titles\r\n" +
                 "FA Cup Titles            UEFA Cup Winners' Cup (historical)\r\n" +
                 "Historical Achievements:\r\n" +
                 "Arsenal is one of the most successful clubs in English football history.\r\n" +
                 "Invincibles: In the 2003-2004 season, Arsenal went unbeaten in the Premier League\r\n" +
                 " securing the title without losing a single game.\r\n" +
                 "FA Cup Success: Arsenal has a strong history in the FA Cup, winning the competition multiple times.\r\n" +
                 "Notable Players:\r\n" +
                 "Arsenal has had legendary players:\r\n" +
                 " Thierry Henry\r\n" +
                 " Tony Adams\r\n" +
                 " Dennis Bergkamp\r\n  Patrick Vieira.";



             textBox5.Text = information;

             Font font = new Font("Tahoma", 10.0f, FontStyle.Regular);
             textBox5.Font = font;

             Size size = TextRenderer.MeasureText(textBox5.Text, textBox5.Font);
             textBox5.Size = new Size(size.Width + 10, size.Height + 10);
             textBox5.BringToFront();
         }

         private void exit_Click(object sender, EventArgs e)
         {
             Application.Exit();
         }*/
        private void Button1_Click(object sender, EventArgs e)
        {
            string information = "Manchester United Football Club:\r\n" +
                                 "The greatest club in England\r\n" +
                                 "Nickname: The Red Devils\r\n" +
                                 "Founded: 1878 as Newton Heath LYR Football Club; renamed Manchester United in 1902.\r\n" +
                                 "Stadium: Old Trafford, located in Greater Manchester, England.\r\n" +
                                 "Major Honors:   English Premier League Titles\r\n" +
                                 "FA Cup Titles   UEFA Champions League Titles\r\n" +
                                 "Notable Achievements:\r\n" +
                                 "Manchester United is one of the most successful and popular football clubs globally.\r\n" +
                                 "The club has a rich history of success domestically and internationally.\r\n" +
                                 "Notable periods of success under managers like Sir Matt Busby and Sir Alex Ferguson.\r\n" +
                                 "Achieved a historic treble in the 1998-1999 season (Premier League, FA Cup, UEFA Champions League).\r\n" +
                                 "Rivalries:\r\n" +
                                 "Intense rivalries with clubs like Manchester City (Manchester Derby) and Liverpool (North West Derby).\r\n" +
                                 "Famous Players:\r\n" +
                                 "Manchester United has been home to numerous legendary players\r\n " +
                                 "George Best\r\n" +
                                 "Sir Bobby Charlton\r\n" +
                                 "Eric Cantona\r\n" +
                                 "Ryan Giggs\r\n" +
                                 "Paul Scholes\r\n" +
                                 "Cristiano Ronaldo";

            MessageBox.Show(information, "Manchester United Information");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string information = "Liverpool Football Club:\r\n" +
                                  "Nickname: The Reds\r\n" +
                                  "Founded: 1892\r\n" +
                                  "Stadium: Anfield, located in Liverpool, England.\r\n" +
                                  "Manager (as of January 2023): Jürgen Klopp\r\n" +
                                  "Major Honors: English First Division/Premier League Titles\r\n" +
                                  "FA Cup Titles    UEFA Champions League Titles\r\n" +
                                  "Notable Achievements:\r\n" +
                                  "Liverpool has a rich history and is one of the most successful clubs in English and European football.\r\n" +
                                  "The club has experienced periods of dominance, particularly in the 1970s and 1980s.\r\n" +
                                  "Achieved a historic treble in the 1976-1977 season (First Division, European Cup, League Cup).\r\n" +
                                  "Rivalries:\r\n" +
                                  "Intense rivalries with Everton (Merseyside Derby) and Manchester United.\r\n" +
                                  "Famous Players:\r\n" +
                                  "Liverpool has been home to numerous legendary players, including Kenny Dalglish\r\n" +
                                  "Steven Gerrard, Ian Rush, Robbie Fowler, and many others";

            MessageBox.Show(information, "Liverpool Information");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string information = "Manchester City Football Club:\r\n" +
                                "Nickname: The Citizens\r\n" +
                                "Founded: 1880 as St. Mark's (West Gorton); became Manchester City in 1894.\r\n" +
                                "Stadium: Etihad Stadium, located in Manchester, England.\r\n" +
                                "Manager (as of January 2023): Pep Guardiola\r\n" +
                                "Major Honors:     English Premier League Titles\r\n" +
                                "FA Cup Titles    EFL Cup (League Cup) Titles       UEFA Cup Winners' Cup (historical)\r\n" +
                                "Recent Achievements:\r\n" +
                                "Manchester City has been highly successful in recent years, particularly under the management of Pep Guardiola.\r\n" +
                                "Achieved domestic dominance with multiple Premier League titles.\r\n" +
                                "European Success:\r\n" +
                                "Manchester City has become a consistent contender in the UEFA Champions League, reaching the final in the 2020-2021 season.\r\n" +
                                "Notable Players:\r\n" +
                                "The club has attracted top talent, including players like Sergio Agüero, David Silva, Kevin De Bruyne, and Raheem Sterling.";

            MessageBox.Show(information, "Manchester City Information");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string information = "Chelsea Football Club:\r\n" +
                                "Nickname: The Blues\r\n" +
                                "Founded: 1905\r\n" +
                                "Stadium: Stamford Bridge, located in London, England.\r\n" +
                                "Major Honors:      English Premier League Titles\r\n" +
                                "Recent Achievements:\r\n" +
                                "Chelsea has been a competitive force in English and European football, achieving success domestically and internationally.\r\n" +
                                "Won the UEFA Champions League in the 2011-2012 and 2020-2021 seasons.\r\n" +
                                "Consistent presence in the top tier of English football.\r\n" +
                                "Notable Players:\r\n" +
                                "Chelsea has had a roster of notable players over the years, including Frank Lampard, Didier Drogba, John Terry, and others.\r\n" +
                                "Youth Development:\r\n" +
                                "Known for its youth development system, producing talented players who have become key contributors to the first team.\r\n" +
                                "Owner: Roman Abramovich";

            MessageBox.Show(information, "Chelsea Information");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string information = "Arsenal Football Club:\r\n" +
                "Nickname: The Gunners\r\n" +
                "Founded: 1886\r\n" +
                "Stadium: Emirates Stadium, located in Islington, London, England.\r\n" +
                "Manager (as of January 2023): Mikel Arteta\r\n" +
                "Major Honors:      English Premier League Titles\r\n" +
                "FA Cup Titles            UEFA Cup Winners' Cup (historical)\r\n" +
                "Historical Achievements:\r\n" +
                "Arsenal is one of the most successful clubs in English football history.\r\n" +
                "Invincibles: In the 2003-2004 season, Arsenal went unbeaten in the Premier League\r\n" +
                " securing the title without losing a single game.\r\n" +
                "FA Cup Success: Arsenal has a strong history in the FA Cup, winning the competition multiple times.\r\n" +
                "Notable Players:\r\n" +
                "Arsenal has had legendary players:\r\n" +
                " Thierry Henry\r\n" +
                " Tony Adams\r";
    }
    } }

    

