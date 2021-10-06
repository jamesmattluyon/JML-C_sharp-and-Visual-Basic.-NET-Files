using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JewelryShop.Cashier
{
   
    public partial class Cashier : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-VU0VULUU\SQLEXPRESS;Initial Catalog=JEWELRY_SHOP;Integrated Security=True");
        public Cashier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand(); 
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Cashier](cashierName, contactNo) values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("Data inserted success");
        }
    }
}
