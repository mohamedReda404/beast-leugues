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
    public partial class Bundesliga : Form
    {
     
        PictureBox picturebox1 = new PictureBox();
        PictureBox picturebox2 = new PictureBox();
        
        public Bundesliga()
        {
            InitializeComponent();
            this.Load += Form1_Load_1;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Text = "Bundesliga";
            

         
               // */
            // pictureBox1
            PictureBox pictureBox1 = new PictureBox();
            this.Controls.Add(pictureBox1);

            pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.bayern_removebg_preview;
            //  picturebox1.BackColor = Color.FromArgb(0, Color.White);
            pictureBox1.BackColor = Color.FromArgb(0, Color.White);
            pictureBox1.Location = new Point(480, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Button1_Click;
            //
            // pictureBox2
            PictureBox pictureBox2 = new PictureBox();
            this.Controls.Add(pictureBox2);

            pictureBox2.Image = global::WindowsFormsApp8.Properties.Resources.brosia_removebg_preview;
            pictureBox2.BackColor = Color.FromArgb(0, Color.White);
            pictureBox2.Location = new Point(100, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Button2_Click;
            //
            // pictureBox3

            PictureBox pictureBox3 = new PictureBox();
            this.Controls.Add(pictureBox3);

        }


            private void Button1_Click(object sender, EventArgs e)
            {
                string information = "Bayern München:\r\n" +
                                    "Nickname: Die Roten (The Reds)\r\n" +
                                    "Founded: February 27, 1900\r\n" +
                                    "Location: Munich, Bavaria, Germany\r\n" +
                                    "Stadium: Allianz Arena\r\n" +
                                    "Honors:\r\n" +
                                    "Bundesliga (German top-flight football league) titles:\r\n" +
                                    "DFB-Pokal (German Cup) titles Multiple\r\n" +
                                    "UEFA Champions League titles\r\n" +
                                    "Bayern Munich is renowned for its rich history\r\n" +
                                    " successful footballing tradition, and a strong fan base. The club has produced and attracted \r\n" +
                                    "many legendary players over the years. If you have any specific questions or need more recent information\r\n" +
                                    " feel free to ask!";

                MessageBox.Show(information, "Bayern München Information");
            }

            private void Button2_Click(object sender, EventArgs e)
            {
                string information = "Borussia Dortmund:\r\n" +
                    "Nickname: Die Schwarzgelben (The Black and Yellows)\r\n" +
                    "Founded: December 19, 1909\r\n" +
                    "Location: Dortmund, North Rhine-Westphalia, Germany\r\n" +
                    "Stadium: Signal Iduna Park (formerly known as Westfalenstadion)\r\n" +
                    "Manager (as of my knowledge cutoff in January 2022): Marco Rose \r\n" +
                    "Honors:\r\n" +
                    "Bundesliga (German top-flight football league) titles\r\n" +
                    "DFB-Pokal (German Cup)\r\n" +
                    "UEFA Champions League: Winner in 1996-97";

                MessageBox.Show(information, "Borussia Dortmund Information");
            }

            private void Button3_Click(object sender, EventArgs e)
            {
                string information = "Hamburg:\r\n" +
                    "Nickname: Die Rothosen (The Red Shorts)\r\n" +
                    "Founded: 29 September 1887\r\n" +
                    "Location: Hamburg, Germany\r\n" +
                    "Stadium: Volksparkstadion\r\n" +
                    "Honors:\r\n" +
                    "Bundesliga (German top-flight football league) but the last one was in the 1982-83 season\r\n" +
                    "have played in every season of the Bundesliga since its foundation in 1963 until their relegation in 2018.\r\n" +
                    "Hamburger SV has a rich history and was one of the dominant forces in German football\r\n" +
                    " particularly in the late 1970s and early 1980s\r\n" +
                    " The club, however, faced some challenging times in the later years, including relegation from the Bundesliga.";

                MessageBox.Show(information, "Hamburg Information");
            }

            /*  private void exit_Click(object sender, EventArgs e)
           /*   {
                  Application.Exit();
              }*/
        }
    } 




    

