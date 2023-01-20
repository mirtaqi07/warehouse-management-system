using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalPrij
{
    public partial class productout : UserControl
    {
        entryProd entry = new entryProd();
       
        public productout()
        {
            InitializeComponent();
            
        }

        private void TextBox_out_quantity2_TextChanged(object sender, EventArgs e)
        {
            
                       
        }
        private void task1(object sender, EventArgs e)
        {
            label_out_msg1.Hide();
        }
        private void task2(object sender, EventArgs e)
        {
            label_out_msg2.Hide();
        }
        private void task3(object sender, EventArgs e)
        {
            label_out_msg3.Hide();
        }
        private void task4(object sender, EventArgs e)
        {
            label_out_msg4.Hide();
        }
        private void Button_out_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-48H1RIB\\TEW_SQLEXPRESS;Initial Catalog=DataStore;Persist Security Info=True;User ID=sa;Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select [Product Name], [Product Company], [Product Quantity], [Product Price] from Table_1 where [Product ID]='" + textBox_out_id.Text + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.HasRows)
            {
                
                Timer time = new Timer();
                time.Interval = (3000);
                time.Tick += new EventHandler(task2);
                time.Start();

                
                while (da.Read())
                {
                    textBox_out_name.Text = da.GetValue(0).ToString();
                    textBox_out_company.Text = da.GetValue(1).ToString();
                    textBox_out_quantity1.Text = da.GetValue(2).ToString();
                    textBox_out_price.Text = da.GetValue(3).ToString();

                }
                label_out_msg1.Show();
                Timer time1 = new Timer();
                time1.Interval = (3000);
                time1.Tick += new EventHandler(task1);
                time1.Start();

                label_out_name.Show();
                label_out_company.Show();
                label_out_quantity1.Show();
                label_out_price.Show();
                label_out_quantity2.Show();
                textBox_out_name.Show();
                textBox_out_company.Show();
                textBox_out_quantity1.Show();
                textBox_out_price.Show();
                textBox_out_quantity2.Show();
                button_out2.Show();
                con.Close();
            }
            else
            {
                label_out_msg2.Show();
                Timer time = new Timer();
                time.Interval = (3000);
                time.Tick += new EventHandler(task2);
                time.Start();

                label_out_name.Hide();
                label_out_company.Hide();
                label_out_quantity1.Hide();
                label_out_price.Hide();
                label_out_quantity2.Hide();
                textBox_out_name.Hide();
                textBox_out_company.Hide();
                textBox_out_quantity1.Hide();
                textBox_out_price.Hide();
                textBox_out_quantity2.Hide();
                button_out2.Hide();
            }
            da.Close();

        }

        private void Button_out2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-48H1RIB\\TEW_SQLEXPRESS;Initial Catalog=DataStore;Persist Security Info=True;User ID=sa;Password=123");
            conn.Open();
            SqlCommand comd = new SqlCommand("Select [Product Name], [Product Company], [Product Quantity], [Product Price] from Table_1 where [Product ID]='" + textBox_out_id.Text + "'", conn);
            comd.ExecuteNonQuery();
            SqlDataReader da = comd.ExecuteReader();
            if (da.HasRows && textBox_out_quantity2.Text != "" && int.Parse(textBox_out_quantity1.Text) >= int.Parse(textBox_out_quantity2.Text) )
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-48H1RIB\\TEW_SQLEXPRESS;Initial Catalog=DataStore;Persist Security Info=True;User ID=sa;Password=123");
                con.Open();
                entry.left_quantity = int.Parse(textBox_out_quantity1.Text) - int.Parse(textBox_out_quantity2.Text);
                SqlCommand cmd = new SqlCommand("Update Table_1 set [Product Name] = '" + textBox_out_name.Text + "', [Product Company] = '" + textBox_out_company.Text + "', [Product Quantity] = '" + entry.left_quantity + "', [Product Price] = '" + textBox_out_price.Text + "' where [Product ID]='" + textBox_out_id.Text + "' ", con);
                cmd.ExecuteNonQuery();

                while (da.Read())
                {
                    label_out_msg3.Show();
                    Timer time = new Timer();
                    time.Interval = (3000);
                    time.Tick += new EventHandler(task3);
                    time.Start();

                    textBox_out_id.Text = "";
                    textBox_out_name.Text = "";
                    textBox_out_company.Text = "";
                    textBox_out_quantity1.Text = "";
                    textBox_out_price.Text = "";
                    textBox_out_quantity2.Text = "";
                }
                con.Close();
                da.Close();
            }
            else
            {
                label_out_msg4.Show();
                Timer time = new Timer();
                time.Interval = (3000);
                time.Tick += new EventHandler(task4);
                time.Start();
            }
            
        }

        private void TextBox_out_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }    
}   
