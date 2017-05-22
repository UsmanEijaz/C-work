using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.textBox1.Visible = false;
            this.button5.Text = "Backup";
            this.button5.BackColor = Color.SteelBlue;
            this.button5.ForeColor = Color.White; 
            this.BackColor = Color.SteelBlue;
            this.label1.ForeColor = Color.White;
            this.label2.ForeColor = Color.White;
            this.label3.ForeColor = Color.White;
            this.label4.ForeColor = Color.White;
            this.label5.ForeColor = Color.White;
            this.label6.ForeColor = Color.White;
            this.label7.ForeColor = Color.White;
            this.button1.ForeColor = Color.White;
            this.button2.ForeColor = Color.White;
            this.button3.ForeColor = Color.White;
            this.groupBox1.BackColor = Color.SteelBlue;
            this.groupBox1.ForeColor = Color.White;
            this.ForeColor = Color.White;
            this.button3.BackColor = Color.SteelBlue;
            this.button2.BackColor = Color.SteelBlue;
            this.button1.BackColor = Color.SteelBlue;
            this.dataGridView1.Visible = false;
            this.Text = "STUDENT INFO";
            this.groupBox1.Text = "Welcome To Student Info";
            this.label1.Text = "ID";
            this.label2.Text = "INSERT_ID";
            this.label3.Text = "NAME";
            this.label4.Text = "CLASS";
            this.label5.Text = "ROLL NO";
            this.label6.Text = "STATE";
            this.label7.Text = "SECTION";
            this.button1.Text = "INSERT";
            this.button2.Text = "DELETE";
            this.button3.Text = "VIEW ALL";
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("select S_ID from Student", f3.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["S_ID"].ToString());
            }
            f3.con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student where S_ID='" + comboBox1.Text + "'", f3.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["S_Name"].ToString();
                textBox3.Text = dr["S_Class"].ToString();
                textBox4.Text = dr["S_Rollno"].ToString();
                textBox5.Text = dr["S_State"].ToString();
                textBox6.Text = dr["S_Section"].ToString();
            }
            f3.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("insert into Student(S_Name,S_Class,S_Rollno,S_State,S_Section) values(@S_ID,@S_Name,@S_Class,@S_Rollno,@S_State,@S_Section)", f3.con);
           // cmd.Parameters.AddWithValue("@S_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@S_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@S_Class", textBox3.Text);
            cmd.Parameters.AddWithValue("@S_Rollno", textBox4.Text);
            cmd.Parameters.AddWithValue("@S_State", textBox5.Text);
            cmd.Parameters.AddWithValue("@S_Section", textBox6.Text);
            
            MessageBox.Show("Insertion Succeeded", "information");
            f3.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("delete S_ID from Student where S_ID='" + comboBox1.Text + "'", f3.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deletion succeeded", "information");
            f3.con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            Form3 f3 = new Form3();
            SqlDataAdapter da = new SqlDataAdapter("select * from Student", f3.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("update Student set S_Name=@S_Name,S_Class=@S_Class,S_Rollno=@S_Rollno,S_State=@S_State,S_Section=@S_Section where S_ID='" + comboBox1.Text + "'", f3.con);
            cmd.Parameters.AddWithValue("@S_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@S_Class", textBox3.Text);
            cmd.Parameters.AddWithValue("@S_Rollno", textBox4.Text);
            cmd.Parameters.AddWithValue("@S_Section", textBox6.Text);
            cmd.Parameters.AddWithValue("@S_State", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update succeed", "information");
            f3.con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
