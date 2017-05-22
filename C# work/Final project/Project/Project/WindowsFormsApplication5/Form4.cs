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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.textBox1.Visible = false;
            this.button5.Text = "Backup";
            this.button5.BackColor = Color.SteelBlue;
            this.button5.ForeColor = Color.White;
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
            this.groupBox1.BackColor=Color.SteelBlue;
            this.groupBox1.ForeColor=Color.White;
            this.ForeColor = Color.White;
            this.button3.BackColor = Color.SteelBlue;
            this.button2.BackColor = Color.SteelBlue;
            this.button1.BackColor = Color.SteelBlue;
            this.Text = "SECURITY GUARD INFO";
            this.button1.Text = "INSERT";
            this.button2.Text = "DELETE";
            this.button3.Text = "VIEW ALL";
            this.label1.Text = "ID";
            this.label2.Text = "INSERT_ID";
            this.label3.Text = "NAME";
            this.label4.Text = "NIC";
            this.label5.Text = "PHONE";
            this.label6.Text = "SALARY";
            this.label7.Text = "STATE";
            this.groupBox1.Text = "Welcome To Security Guard Info";
            this.dataGridView1.Visible = false;
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("select S_ID from Securpity",f3.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["S_ID"].ToString());
            }
            f3.con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            Form3 f3 = new Form3();
            SqlDataAdapter da = new SqlDataAdapter("select * from Securpity", f3.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("insert into Securpity(S_Name,S_Nic,S_Phone,S_Salary,S_State) values(@S_ID,@S_Name,@S_Phone,@S_Nic,@S_Salary,@S_State)", f3.con);
            //cmd.Parameters.AddWithValue("@S_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@S_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@S_Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@S_Nic", textBox4.Text);
            cmd.Parameters.AddWithValue("@S_Salary", textBox5.Text);
            cmd.Parameters.AddWithValue("@S_State", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertion Succeeded", "information");
            f3.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("delete S_ID from Securpity where S_ID='" + comboBox1.Text + "'", f3.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deletion succeeded", "information");
            f3.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("select * from Securpity where S_ID='" + comboBox1.Text + "'", f3.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["S_Name"].ToString();
                textBox3.Text = dr["S_Nic"].ToString();
                textBox4.Text = dr["S_Phone"].ToString();
                textBox5.Text = dr["S_Salary"].ToString();
                textBox6.Text = dr["S_State"].ToString();
            }
            f3.con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.con.Open();
            SqlCommand cmd = new SqlCommand("update Securpity set S_Name=@S_Name,S_Nic=@S_Nic,S_Phone=@S_Phone,S_Salary=@S_Salary,S_State=@S_State where S_ID='" + comboBox1.Text + "'", f3.con);
            cmd.Parameters.AddWithValue("@S_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@S_Nic", textBox3.Text);
            cmd.Parameters.AddWithValue("@S_Phone", textBox4.Text);
            cmd.Parameters.AddWithValue("@S_Salary", textBox5.Text);
            cmd.Parameters.AddWithValue("@S_State", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update succeed", "information");
            f3.con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
