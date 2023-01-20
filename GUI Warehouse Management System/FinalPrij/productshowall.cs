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
    public partial class productshowall : UserControl
    {
        public productshowall()
        {
            InitializeComponent();
        }



        private void Productshowall_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Button1_Click(object sender, EventArgs e)
        {
                entryProd entry = new entryProd();
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-48H1RIB\\TEW_SQLEXPRESS;Initial Catalog=DataStore;Persist Security Info=True;User ID=sa;Password=123");
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from Table_1", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                
                con.Close();
          
        }
    }
}
