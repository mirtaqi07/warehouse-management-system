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
    public partial class productdelete : UserControl
    {
        entryProd entry = new entryProd();
        public productdelete()
        {
            InitializeComponent();
        }


        private void Button_add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-48H1RIB\\TEW_SQLEXPRESS;Initial Catalog=DataStore;Persist Security Info=True;User ID=sa;Password=123");
            conn.Open();
            SqlCommand comd = new SqlCommand("Select [Product Name], [Product Company], [Product Quantity], [Product Price] from Table_1 where [Product ID]='" + textBox_del_id.Text + "'", conn);
            comd.ExecuteNonQuery();
            SqlDataReader da = comd.ExecuteReader();

            if (da.HasRows)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-48H1RIB\\TEW_SQLEXPRESS;Initial Catalog=DataStore;Persist Security Info=True;User ID=sa;Password=123");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Table_1 where [Product ID]='" + textBox_del_id.Text + "'" , con);
                cmd.ExecuteNonQuery();

                while (da.Read())
                {
                    label_del_msg2.Show();
                    Timer time = new Timer();
                    time.Interval = (3000);
                    time.Tick += new EventHandler(task1);
                    time.Start();
                }
                con.Close();
                da.Close();
            }
            else
            {
                label_del_msg3.Show();
                Timer time = new Timer();
                time.Interval = (3000);
                time.Tick += new EventHandler(task2);
                time.Start();
            }
          
        }
    
        private void task1(object sender, EventArgs e)
        {
            label_del_msg2.Hide();
        }
        private void task2(object sender, EventArgs e)
        {
            label_del_msg3.Hide();
        }

        private void TextBox_del_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ToolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }
    }
}
