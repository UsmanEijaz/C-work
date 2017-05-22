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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.textBox1.Visible = false;
            this.button5.Text = "Backup";
            this.button5.ForeColor = Color.White;
            this.button5.BackColor = Color.SteelBlue;
            this.BackColor = Color.SteelBlue;
            this.button4.Text = "Update";
            this.ForeColor = Color.White;
            this.button4.BackColor = Color.SteelBlue;
            this.button4.ForeColor = Color.White;
            this.button1.ForeColor = Color.White;
            this.button2.ForeColor = Color.White;
            this.button3.ForeColor = Color.White;
            this.button1.BackColor = Color.SteelBlue;
            this.button2.BackColor = Color.SteelBlue;
            this.button3.BackColor = Color.SteelBlue;
            this.label1.ForeColor = Color.White;
            this.label2.ForeColor = Color.White;
            this.label3.ForeColor = Color.White;
            this.label4.ForeColor = Color.White;
            this.label5.ForeColor = Color.White;
            this.label6.ForeColor = Color.White;
            this.label7.ForeColor = Color.White;
            this.groupBox1.BackColor = Color.SteelBlue;
            this.groupBox1.ForeColor = Color.White;
            this.label7.Text = "INSERT_ID";
            this.dataGridView1.Visible = false;
            this.groupBox1.Text = "Welcome to Accountant";
            this.ForeColor = Color.White;
            this.Text = "ACCOUNTANT";
            this.label1.Text = "ID";
            this.label2.Text = "NAME";
            this.label3.Text = "NIC";
            this.label4.Text = "PHONE";
            this.label5.Text = "SALARY";
            this.label6.Text = "STATE";
            this.button1.Text = "Insert";
            this.button2.Text = "Delete";
            this.button3.Text = "View all";
            con.Open();
            SqlCommand cmd = new SqlCommand("select A_ID from Accountant", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["A_ID"].ToString());
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Accountant where A_ID='" + comboBox1.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["A_Name"].ToString();
                textBox3.Text = dr["A_Nic"].ToString();
                textBox4.Text = dr["A_Phone"].ToString();
                textBox5.Text = dr["A_Salary"].ToString();
                textBox6.Text = dr["A_State"].ToString();
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete A_ID from Accountant where A_ID='" + comboBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deletion succeeded","information");
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Accountant(A_Name,A_Nic,A_Phone,A_Salary,A_State) values(@A_Name,@A_Phone,@A_Nic,@A_Salary,@A_State)", con);
            //cmd.Parameters.AddWithValue("@A_ID",Convert.ToInt32( textBox1.Text));
            cmd.Parameters.AddWithValue("@A_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@A_Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@A_Nic", textBox4.Text);
            cmd.Parameters.AddWithValue("@A_Salary", textBox5.Text);
            cmd.Parameters.AddWithValue("@A_State", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertion Succeeded","information");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            SqlDataAdapter dr = new SqlDataAdapter("select * from Accountant", con);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Accountant set A_Name=@A_Name,A_Nic=@A_Nic,A_Phone=@A_Phone,A_Salary=@A_Salary,A_State=@A_State where A_ID='" + comboBox1.Text+ "'", con);
            cmd.Parameters.AddWithValue("@A_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@A_Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@A_Nic", textBox4.Text);
            cmd.Parameters.AddWithValue("@A_Salary", textBox5.Text);
            cmd.Parameters.AddWithValue("@A_State", textBox6.Text);
             cmd.ExecuteNonQuery();
            MessageBox.Show("update succeed", "information");
            con.Close();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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