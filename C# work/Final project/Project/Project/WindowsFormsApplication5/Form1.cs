using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication5
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.groupBox1.Text = "";
            
            this.label1.ForeColor = Color.White;
            this.BackColor = Color.SteelBlue;
            this.label2.ForeColor = Color.White;
            this.label3.ForeColor = Color.White;
            this.Text = "WELCOME";
            this.progressBar1.Visible = false;
            this.label3.Text = "PACIFIC GRAMMER SCHOOL";
            this.label1.Text = "NAME:";
            this.label2.Text = "PASSWORD:";
            this.button1.Text = "";
            this.button2.Text = "";
            this.Text = "WELCOME";
            this.textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AcceptButton = this.button1;
            if (this.textBox1.Text == "usman" && this.textBox2.Text == "khan")
            {
                this.progressBar1.Visible = true;
                this.timer1.Start();
            }
            else
            {
                MessageBox.Show("Please enter the correct password or name");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CancelButton = this.button2;
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.progressBar1.Increment(1);
            if (this.progressBar1.Value == 50)
            {
                this.Hide();
                f2.Show();

            }
        }
    }
}
