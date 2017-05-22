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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void accountantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }

        private void securityInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
        }

        private void studentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
        }

        private void teacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
        }

        private void labAssistantInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.SteelBlue;
            this.Text = "WELCOME";
            this.menuStrip1.BackColor = Color.SteelBlue;
            this.menuStrip1.ForeColor = Color.White;
            this.teacherInfoToolStripMenuItem.BackColor = Color.SteelBlue;
            this.labAssistantInfoToolStripMenuItem.BackColor = Color.SteelBlue;
            this.studentInfoToolStripMenuItem.BackColor = Color.SteelBlue;
            this.securityInfoToolStripMenuItem.BackColor = Color.SteelBlue;
            this.accountantToolStripMenuItem.BackColor = Color.SteelBlue;
            this.accountantToolStripMenuItem.ForeColor = Color.White;
            this.securityInfoToolStripMenuItem.ForeColor = Color.White;
            this.studentInfoToolStripMenuItem.ForeColor = Color.White;
            this.labAssistantInfoToolStripMenuItem.ForeColor = Color.White;
            this.teacherInfoToolStripMenuItem.ForeColor = Color.White;
            
        }
    }
}
