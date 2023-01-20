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
using System.Data.SqlClient;

namespace FinalPrij
{
    public partial class productupdate : UserControl
    {

        public productupdate()
        {
            InitializeComponent();

        }
      
        private void Button_update2_Click(object sender, EventArgs e)
        {
            entryProd entry = new entryProd();
            entry.equaladd = textBox_upd_name.Text;
            entry.equaladd = textBox_upd_company.Text;
            entry.equaladd = textBox_upd_quantity.Text;
            entry.equaladd = textBox_upd_price.Text;

            
            
            if (entry.equaladd != "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-48H1RIB\\TEW_SQLEXPRESS;Initial Catalog=DataStore;Persist Security Info=True;User ID=sa;Password=123");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Table_1 set [Product Name] = '" + textBox_upd_name.Text + "', [Product Company] = '" + textBox_upd_company.Text + "', [Product Quantity] = '" + textBox_upd_quantity.Text + "', [Product Price] = '" + textBox_upd_price.Text + "' where [Product ID]='" + textBox_upd_id.Text + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();


                label_upd_msg4.Show();
                Timer time = new Timer();
                time.Interval = (3000);
                time.Tick += new EventHandler(task3);
                time.Start();

                textBox_upd_id.Text = "";
                textBox_upd_name.Text = "";
                textBox_upd_company.Text = "";
                textBox_upd_quantity.Text = "";
                textBox_upd_price.Text = "";



            }
            else
            {

                label_upd_msg5.Show();
                Timer time = new Timer();
                time.Interval = (3000);
                time.Tick += new EventHandler(task4);
                time.Start();
               
            }
        }

        private void Label_upd_msg2_Click(object sender, EventArgs e)
        {

        }

        private void task1(object sender, EventArgs e)
        {
            label_upd_msg2.Hide();
        }
        private void task2(object sender, EventArgs e)
        {
            label_upd_msg3.Hide();
        }
        private void task3(object sender, EventArgs e)
        {
            label_upd_msg4.Hide();
        }
        private void task4(object sender, EventArgs e)
        {
            label_upd_msg5.Hide();
        }
       

        private void TextBox_upd_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_update1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-48H1RIB\\TEW_SQLEXPRESS;Initial Catalog=DataStore;Persist Security Info=True;User ID=sa;Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select [Product Name], [Product Company], [Product Quantity], [Product Price] from Table_1 where [Product ID]='" + textBox_upd_id.Text + "'", con);
            SqlDataReader da = cmd.ExecuteReader();

            if (da.HasRows)
            {
                while(da.Read())
                {
                    label_upd_msg2.Show();
                    Timer time = new Timer();
                    time.Interval = (3000);
                    time.Tick += new EventHandler(task1);
                    time.Start();

                    label_upd_name.Show();
                    label_upd_company.Show();
                    label_upd_quantity.Show();
                    label_upd_price.Show();
                    textBox_upd_name.Show();
                    textBox_upd_company.Show();
                    textBox_upd_quantity.Show();
                    textBox_upd_price.Show();
                    button_update2.Show();

                    textBox_upd_name.Text = da.GetValue(0).ToString();
                    textBox_upd_company.Text = da.GetValue(1).ToString();
                    textBox_upd_quantity.Text = da.GetValue(2).ToString();
                    textBox_upd_price.Text = da.GetValue(3).ToString();
                }
                con.Close();
            }
            else
            {
                label_upd_msg3.Show();
                Timer time = new Timer();
                time.Interval = (3000);
                time.Tick += new EventHandler(task2);
                time.Start();

                textBox_upd_name.Text = "";
                textBox_upd_company.Text = "";
                textBox_upd_quantity.Text = "";
                textBox_upd_price.Text = "";

                label_upd_name.Hide();
                label_upd_company.Hide();
                label_upd_quantity.Hide();
                label_upd_price.Hide();
                textBox_upd_name.Hide();
                textBox_upd_company.Hide();
                textBox_upd_quantity.Hide();
                textBox_upd_price.Hide();
                button_update2.Hide(); 
            }
        }

        private void Productupdate_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_upd_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }

}
