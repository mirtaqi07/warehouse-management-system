using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPrij
{
    public partial class mainform1 : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public mainform1()
        {
            InitializeComponent();

            button_show.Click += new EventHandler(productshowall2.Button1_Click);


        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            paneltop.Height = button_delete.Height;
            paneltop.Top = button_delete.Top;
            productdelete1.BringToFront();

            
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            paneltop.Height = button_add.Height;
            paneltop.Top = button_add.Top;
            productadd1.BringToFront();
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            paneltop.Height = button_update.Height;
            paneltop.Top = button_update.Top;
            productupdate1.BringToFront();
        }

        private void Button_show_Click(object sender, EventArgs e)
        {
            paneltop.Height = button_show.Height;
            paneltop.Top = button_show.Top;
            productshowall2.BringToFront();


        }
        private void Button_search_Click(object sender, EventArgs e)
        {
            paneltop.Height = button_search.Height;
            paneltop.Top = button_search.Top;
            productsearch1.BringToFront();
        }

        private void Button_out_Click(object sender, EventArgs e)
        {
            paneltop.Height = button_out.Height;
            paneltop.Top = button_out.Top;
            productout1.BringToFront();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_right_out_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label_add_id_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_add_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void TextBox_add_id_TextChanged_1(object sender, EventArgs e)
        {
           
        }
       
        private void Panel_right_add_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Label_logo1_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void Productadd1_Load(object sender, EventArgs e)
        {

        }

        private void Mainform1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Mainform1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void Mainform1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }

        private void Panel_top_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point P = PointToScreen(e.Location);
                Location = new Point(P.X - this.startPoint.X, P.Y - this.startPoint.Y);
            }
        }
    }
}
