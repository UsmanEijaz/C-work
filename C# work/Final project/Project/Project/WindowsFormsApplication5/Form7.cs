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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.textBox1.Visible = false;
            this.button5.Text = "Backup";
            this.button5.BackColor = Color.SteelBlue;
            this.button5.ForeColor = Color.White;
            this.button4.Text = "Update";
            this.button4.BackColor = Color.SteelBlue;
            this.button4.ForeColor = Color.White;
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
            this.Text = "LAB ASSISTANT INFO";
            this.groupBox1.Text = "Welcome To Lab Assistant Info";
            this.label1.Text = "ID";
            this.label2.Text = "INSERT_ID";
            this.label3.Text = "NAME";
            this.label4.Text = "NIC";
            this.label5.Text = "PHONE";
            this.label6.Text = "SALARY";
            this.label7.Text = "STATE";
            this.button1.Text = "INSERT";
            this.button2.Text = "DELETE";
            this.button3.Text = "VIEW ALL";
            Form3 f3 = new Form3();
            f3.con.Open();
          SqlCommand cmd = new SqlCommand("select L_ID from Lab_Assistant", f3.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["L_ID"].ToString());
            }
            f3.con.Close();
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            Form3 f3 = new Form3();
            SqlDataAdapter da = new SqlDataAdapter("select * from Lab_Assistant", f3.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("select * from Lab_Assistant where L_ID='" + comboBox1.Text + "'", f3.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["L_Name"].ToString();
                textBox3.Text = dr["L_Nic"].ToString();
                textBox4.Text = dr["L_Phone"].ToString();
                textBox5.Text = dr["L_Salary"].ToString();
                textBox6.Text = dr["L_State"].ToString();
            }
            f3.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
           SqlCommand cmd = new SqlCommand("insert into Lab_Assistant(L_Name,L_Nic,L_Phone,L_Salary,L_State) values(@L_ID,@L_Name,@L_Nic,@L_Subject,@L_Salary,@L_State)", f3.con);
           // cmd.Parameters.AddWithValue("@L_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@L_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@L_Nic", textBox3.Text);
            cmd.Parameters.AddWithValue("@L_Phone", textBox4.Text);
            cmd.Parameters.AddWithValue("@L_Salary", textBox5.Text);
            cmd.Parameters.AddWithValue("@L_State", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertion Succeeded", "information");
            f3.con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("delete L_ID from Lab_Assistant where L_ID='" + comboBox1.Text + "'", f3.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deletion succeeded", "information");
            f3.con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("update Lab_Assistant set L_Name=@L_Name,L_Nic=@L_Nic,L_Phone=@L_Phone,L_Salary=@L_Salary,L_State=@L_State where L_ID='" + comboBox1.Text + "'", f3.con);
            cmd.Parameters.AddWithValue("@L_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@L_Nic", textBox3.Text);
            cmd.Parameters.AddWithValue("@L_Phone", textBox4.Text);
            cmd.Parameters.AddWithValue("@L_Salary", textBox5.Text);
            cmd.Parameters.AddWithValue("@L_State", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update succeed", "information");
            f3.con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
