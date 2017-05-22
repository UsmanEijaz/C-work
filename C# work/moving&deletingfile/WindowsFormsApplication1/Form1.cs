using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] i = new string[] { "C:\\", "D:\\" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        
        {
            this.groupBox4.Text = "Delete File";
            comboBox4.Items.AddRange(i);
            this.button4.Text = "Delete";
            this.label11.Text = "sub dir";
            this.button3.Text = "Create";
            this.groupBox3.Text = "Create File";
            this.groupBox1.Text = "Copy File";
            this.groupBox2.Text = "Move File";
            this.label1.Text = "File Location";
            this.label2.Text = "File Name";
            this.label3.Text = "Destination Location";
            this.label4.Text = "Destination Name";
            this.button1.Text = "copy";
            this.label5.Text = "File Location";
            this.label6.Text = "File Name";
            this.label7.Text = "Destination Location";
            this.label8.Text = "Destination Name";
            this.label9.Text = "Directory Name";
            this.label10.Text = "File Name";
            this.button2.Text = "Move";
            comboBox1.Items.AddRange(i);
            comboBox2.Items.AddRange(i);
            comboBox3.Items.AddRange(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = comboBox1.Text + textBox1.Text;
            string d = textBox2.Text + textBox3.Text;
            try
            {
                File.Copy(s, d);
                MessageBox.Show("copied");
            }
            catch (Exception ex)
            {
                MessageBox.Show("sorry" + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox3.Text = this.textBox1.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = comboBox2.Text + textBox4.Text;
            string d = textBox5.Text + textBox6.Text;
            try
            {
                File.Move(s, d);
                MessageBox.Show("copied");
            }
            catch (Exception ex)
            {
                MessageBox.Show("sorry" + ex);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.textBox6.Text = this.textBox4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string d = textBox8.Text;
            string s = comboBox3.Text + textBox7.Text;
            try
            {


                DirectoryInfo dir = new DirectoryInfo(s);
                dir.Create();
                dir.CreateSubdirectory(d);
                MessageBox.Show("create sucess");

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string d = comboBox4.Text + textBox9.Text;
            try
            {
                if (File.Exists(d))
                {
                    File.Delete(d);
                    MessageBox.Show("Delete");
                }
                else
                { MessageBox.Show("doesnot exist"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }
    }
}
