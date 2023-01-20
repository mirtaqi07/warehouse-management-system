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
    
    public partial class productadd : UserControl
    {

        bool c = true;
        public productadd()
        {
            InitializeComponent();

        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            entryProd entry = new entryProd();

            

             entry.prod_id = textBox_id.Text;
             entry.prod_name= textBox_name.Text;
             entry.company = textBox_company.Text;
             entry.quantity = textBox_quantity.Text;
             entry.unit_price = textBox_price.Text;

/*
            entry.equaladd = entry.prod_id;
            entry.equaladd = entry.prod_name;
            entry.equaladd = entry.company;
            entry.equaladd = entry.quantity;
            entry.equaladd = entry.unit_price;
*/
            

            if (textBox_id.Text != "" && textBox_name.Text != "" && textBox_company.Text != "" && textBox_quantity.Text != "" && textBox_price.Text != "" )
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-48H1RIB\\TEW_SQLEXPRESS;Initial Catalog=DataStore;Persist Security Info=True;User ID=sa;Password=123");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Table_1 values ('" + entry.prod_id + "', '" + entry.prod_name + "', '" + entry.company + "', '" + entry.quantity + "', '" + entry.unit_price + "') ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                label_add_msg1.Show();
                Timer time = new Timer();
                time.Interval = (3000);
                time.Tick += new EventHandler(task1);
                time.Start();

                textBox_id.Text = "";
                textBox_name.Text = "";
                textBox_company.Text = "";
                textBox_quantity.Text = "";
                textBox_price.Text = "";

            }
            else
            {
                label_add_msg2.Show();
                Timer time = new Timer();
                time.Interval = (3000);
                time.Tick += new EventHandler(task2);
                time.Start();
               
            }
            
        }


        private void task1(object sender, EventArgs e)
        {
            label_add_msg1.Hide();
        }
        private void task2(object sender, EventArgs e)
        {
            label_add_msg2.Hide();
        }
        
        private void TextBox_id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox_id_Click(object sender, EventArgs e)
        {


        }
        private void TextBox_id_Enter(object sender, EventArgs e)
        {
             
        }

        private void TextBox_id_Leave(object sender, EventArgs e)
        {

        }
    }
}
