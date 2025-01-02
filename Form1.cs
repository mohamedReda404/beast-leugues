using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit.;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {

        Label label1 = new Label();
        Label label4 = new Label();
        Label lab1= new Label();
        Label label_1 = new Label();
        TextBox textBox1 = new TextBox();
        Button button2 = new Button();
        Label label2 = new Label();
        LinkLabel linkLabel2 = new LinkLabel();
        LinkLabel linkLabel1 = new LinkLabel();
        TextBox textBox2 = new TextBox(); 
        Label label3 = new Label();
        Panel panel1 = new Panel();
        Panel panel2 = new Panel();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
       
            // Form1
            // 
            Controls.Add(button2);
            AutoSize = true;
            this.Size=new Size(500, 500);    
           // this.Controls.Add(label_2);
         //   BackColor = Color.FromArgb(52, 53, 65);
            Text = "Welcome";
            ShowInTaskbar = false;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            //label_2
            //lab1
            lab1.Text = "Best leagues";
            lab1.Location=new Point(200, 20);
            //Controls.Add(lab1);
            lab1.BackColor = Color.FromArgb(0, Color.White);
            lab1.Font = new Font("", 14, FontStyle.Bold);
            lab1.ForeColor = Color.White;
            lab1.Size = new Size(100,20);
            // label_2.Text = "Best leagues in the world";

          
            //label 4
            label4.AutoSize = true;
            label4.Font = new Font("", 20, FontStyle.Italic);
            label4.ForeColor = Color.White;
           label4.BackColor = Color.FromArgb(0, Color.White);
            label4.Location = new Point(350, 70);
            label4.Text = "Best leagues";
            Controls.Add(label4);
            //   button1
            // button1.BackColor = Color.FromArgb(52, 53, 65);
            label_1.Location = new Point(730, 0);
            label_1.BackColor = Color.FromArgb(0, Color.Black);
            label_1.Size = new Size(66, 57);
            label_1.Click += button1_Click;
            label_1.ForeColor = Color.White;
            label_1.Font = new Font("", 15, FontStyle.Bold);
            label_1.Text = " Exit";
            Controls.Add(label_1);
            // linkLabel1

       
            //button2
            button2.Font = new Font("", 8, FontStyle.Bold);
            button2.Click += new EventHandler(button2_Click);
            button2.Location = new Point(130, 180);
            button2.BackColor = Color.White;
            button2.Size = new Size(50, 30);
            button2.Text = "login";
           // button2.BackColor = Color.FromArgb(0, Color.White);
            Controls.Add(button2);
            //textbox1
            textBox1.Location = new Point(100, 110);
            textBox1.Font = new Font("", 10, FontStyle.Bold);
           // textBox1.BackColor = Color.FromArgb(100, Color.White);
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(180, 2);
            Controls.Add(textBox1);
            // label2
            label2.AutoSize = true;
            label2.Location = new Point(27, 110);
            label2.Font = new Font("", 9, FontStyle.Bold);
     
            label2.Text = "Password";
            label2.ForeColor = Color.White;
            label2.BackColor = Color.FromArgb(0, Color.White);
            Controls.Add(label2);
            //textbox2
            textBox2.Location = new Point(100, 60);
            textBox2.Font = new Font("", 10, FontStyle.Bold);
           // textBox2.BackColor = Color.FromArgb(100, Color.White);
            textBox2.Size = new Size(180, 2);
            Controls.Add(textBox2);
            // label3
            label3.AutoSize = true;
            label3.Location = new Point(20, 60);
            label3.Font = new Font("", 9, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Text = "User Name";
            label3.BackColor = Color.FromArgb(0, Color.White);
            Controls.Add(label3);
            // panel1
            //  panel1.BackColor = Color.FromArgb(52, 53, 65);
            panel1.BackColor = Color.FromArgb(80, Color.Black);

           // panel1.Controls.Add(this.linkLabel2);
           // panel1.Controls.Add(this.linkLabel1);
            panel1.Controls.Add(this.button2);
            panel1.Controls.Add(this.textBox2);
            panel1.Controls.Add(this.label3);
            panel1.Controls.Add(this.textBox1);
            panel1.Controls.Add(this.label2);
            panel1.Location = new Point(280, 130);
            panel1.Size = new Size(290, 270);
            Controls.Add(panel1);
            //  panel2
            //panel2.BackColor = Color.FromArgb(52, 53, 65);
            panel2.BackColor = Color.FromArgb(0, Color.Black);
            label_1.BackColor = Color.FromArgb(0, Color.Black);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label_1);
            panel2.Location = new Point(100, 440);
            panel2.Size = new Size(800, 40);
            Controls.Add(panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            leagues_form fo_1= new leagues_form();
            // Validate the input in textBox1 and textBox2
            if (IsValidEmail(textBox2.Text) && IsValidNumeric(textBox1.Text))
            {
                // connect with another form!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
               // MessageBox.Show("Successfully!" );
                fo_1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password" +
      ". Please try again.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            // Check if the email ends with "@CR7.com"
            return email.EndsWith("@404.com", StringComparison.OrdinalIgnoreCase);
        }

        private bool IsValidNumeric(string input)
        {
            // Check if the input contains only numeric characters
            return int.TryParse(input, out _);
        }



    }
}
    

