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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.textBox1.Visible = false;
            this.button5.Text = "Backup";
            this.button5.BackColor = Color.SteelBlue;
            this.button5.ForeColor = Color.White;
            this.button4.Text = "Upadate";
            this.button4.ForeColor = Color.White;
            this.button4.BackColor = Color.SteelBlue;
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
            this.Text = "TEACHER INFO";
            this.label1.Text = "ID";
            this.label2.Text = "INSERT_ID";
            this.label3.Text="NAME";
            this.label4.Text = "NIC";
            this.label5.Text = "SUBJECT";
            this.label6.Text = "SALARY";
            this.label7.Text = "STATE";
            this.groupBox1.Text = "WELCOME TO TEACHER INFO";
            this.dataGridView1.Visible = false;
            this.button1.Text = "INSERT";
            this.button2.Text = "DELETE";
            this.button3.Text = "VIEW ALL";
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("select T_ID from Teacher", f3.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["T_ID"].ToString());
            }
            f3.con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            Form3 f3 = new Form3();
            SqlDataAdapter dr = new SqlDataAdapter("select * from Teacher", f3.con);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("select * from Teacher where T_ID='" + comboBox1.Text + "'", f3.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["T_Name"].ToString();
                textBox3.Text = dr["T_Nic"].ToString();
                textBox4.Text = dr["T_Subject"].ToString();
                textBox5.Text = dr["T_Salary"].ToString();
                textBox6.Text = dr["T_State"].ToString();
            }
            f3.con.Close();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
          SqlCommand cmd = new SqlCommand("insert into Teacher(T_Name,T_Nic,T_Subject,T_Salary,T_State) values(@T_Name,@T_Nic,@T_Subject,@T_Salary,@T_State)", f3.con);
           // cmd.Parameters.AddWithValue("@T_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@T_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@T_Nic", textBox3.Text);
            cmd.Parameters.AddWithValue("@T_Subject", textBox4.Text);
            cmd.Parameters.AddWithValue("@T_Salary", textBox5.Text);
            cmd.Parameters.AddWithValue("@T_State", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertion Succeeded", "information");
            f3.con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("delete T_ID from Teacher where T_ID='" + comboBox1.Text + "'", f3.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deletion succeeded", "information");
            f3.con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("update Teacher set T_Name=@T_Name,T_Nic=@T_Nic,T_Subject=@T_Subject,T_Salary=@T_Salary,T_State=@T_State where T_ID='" + comboBox1.Text + "'", f3.con);
            cmd.Parameters.AddWithValue("@T_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@T_Nic", textBox3.Text);
            cmd.Parameters.AddWithValue("@T_Subject", textBox4.Text);
            cmd.Parameters.AddWithValue("@T_Salary", textBox5.Text);
            cmd.Parameters.AddWithValue("@T_State", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update succeed", "information");
            f3.con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
