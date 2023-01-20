using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace FinalPrij
{
    public partial class productsearch : UserControl
    {
        entryProd entry = new entryProd();
        public productsearch()
        {
            InitializeComponent();
            
        }

        private void Label_search_name_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-48H1RIB\\TEW_SQLEXPRESS;Initial Catalog=DataStore;Persist Security Info=True;User ID=sa;Password=123");
            con.Open();
            SqlCommand comd = new SqlCommand("Select [Product Name], [Product Company], [Product Quantity], [Product Price] from Table_1 where [Product ID]='" + textBox_search_id.Text + "'", con);
            SqlDataReader da = comd.ExecuteReader();

            if (da.HasRows)
            {
                SqlCommand cmd = new SqlCommand("Select [Product Name], [Product Company], [Product Quantity], [Product Price] from Table_1 where [Product ID]='" + textBox_search_id.Text + "'", con);
            
                
                while (da.Read())
                {
                    label_search_msg1.Show();
                    Timer time = new Timer();
                    time.Interval = (3000);
                    time.Tick += new EventHandler(task1);
                    time.Start();

                    label_search_name.Show();
                    label_search_company.Show();
                    label_search_quantity.Show();
                    label_search_price.Show();
                    textBox_search_name.Show();
                    textBox_search_company.Show();
                    textBox_search_quantity.Show();
                    textBox_search_price.Show();

                    textBox_search_name.Text = da.GetValue(0).ToString();
                    textBox_search_company.Text = da.GetValue(1).ToString();
                    textBox_search_quantity.Text = da.GetValue(2).ToString();
                    textBox_search_price.Text = da.GetValue(3).ToString();
                }
                con.Close();
                
            }

            else
            {
                label_search_msg2.Show();
                Timer time = new Timer();
                time.Interval = (3000);
                time.Tick += new EventHandler(task2);
                time.Start();

                textBox_search_name.Text = "";
                textBox_search_company.Text = "";
                textBox_search_quantity.Text = "";
                textBox_search_price.Text = "";

                label_search_name.Hide();
                label_search_company.Hide();
                label_search_quantity.Hide();
                label_search_price.Hide();
                textBox_search_name.Hide();
                textBox_search_company.Hide();
                textBox_search_quantity.Hide();
                textBox_search_price.Hide();
            }
                da.Close();
            
        }
        private void task1(object sender, EventArgs e)
        {
            label_search_msg1.Hide();
        }
        private void task2(object sender, EventArgs e)
        {
            label_search_msg2.Hide();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_search_id_TextChanged(object sender, EventArgs e)
        {
            //entry.search = textBox_search_id.Text;
            /*
            textBox_search_name.Text = entry.prod_id;
            textBox_search_company.Text = entry.company;
            textBox_search_quantity.Text = entry.quantity;
            textBox_search_price.Text = entry.unit_price;
            */

            
        }

        private void TextBox_search_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
