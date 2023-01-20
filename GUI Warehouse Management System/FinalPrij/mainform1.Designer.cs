namespace FinalPrij
{
    partial class mainform1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.button_out = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label_logo2 = new System.Windows.Forms.Label();
            this.label_logo1 = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productadd1 = new FinalPrij.productadd();
            this.productupdate1 = new FinalPrij.productupdate();
            this.productdelete1 = new FinalPrij.productdelete();
            this.productsearch1 = new FinalPrij.productsearch();
            this.productout1 = new FinalPrij.productout();
            this.productshowall2 = new FinalPrij.productshowall();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Indigo;
            this.panelSideMenu.Controls.Add(this.paneltop);
            this.panelSideMenu.Controls.Add(this.button_out);
            this.panelSideMenu.Controls.Add(this.button_show);
            this.panelSideMenu.Controls.Add(this.button_search);
            this.panelSideMenu.Controls.Add(this.button_delete);
            this.panelSideMenu.Controls.Add(this.button_update);
            this.panelSideMenu.Controls.Add(this.button_add);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(213, 555);
            this.panelSideMenu.TabIndex = 0;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.White;
            this.paneltop.Location = new System.Drawing.Point(0, 124);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(11, 45);
            this.paneltop.TabIndex = 0;
            this.paneltop.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // button_out
            // 
            this.button_out.AutoSize = true;
            this.button_out.BackColor = System.Drawing.Color.Indigo;
            this.button_out.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_out.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button_out.FlatAppearance.BorderSize = 0;
            this.button_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_out.ForeColor = System.Drawing.Color.White;
            this.button_out.Location = new System.Drawing.Point(0, 349);
            this.button_out.Name = "button_out";
            this.button_out.Size = new System.Drawing.Size(213, 45);
            this.button_out.TabIndex = 6;
            this.button_out.Text = "Out Product";
            this.button_out.UseVisualStyleBackColor = false;
            this.button_out.Click += new System.EventHandler(this.Button_out_Click);
            // 
            // button_show
            // 
            this.button_show.AutoSize = true;
            this.button_show.BackColor = System.Drawing.Color.Indigo;
            this.button_show.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_show.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button_show.FlatAppearance.BorderSize = 0;
            this.button_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show.ForeColor = System.Drawing.Color.White;
            this.button_show.Location = new System.Drawing.Point(0, 304);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(213, 45);
            this.button_show.TabIndex = 5;
            this.button_show.Text = "Show All Data";
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Click += new System.EventHandler(this.Button_show_Click);
            // 
            // button_search
            // 
            this.button_search.AutoSize = true;
            this.button_search.BackColor = System.Drawing.Color.Indigo;
            this.button_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_search.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(0, 259);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(213, 45);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Search Product";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // button_delete
            // 
            this.button_delete.AutoSize = true;
            this.button_delete.BackColor = System.Drawing.Color.Indigo;
            this.button_delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(0, 214);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(213, 45);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete Product";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.AutoSize = true;
            this.button_update.BackColor = System.Drawing.Color.Indigo;
            this.button_update.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_update.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(0, 169);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(213, 45);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update Product";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // button_add
            // 
            this.button_add.AutoSize = true;
            this.button_add.BackColor = System.Drawing.Color.Indigo;
            this.button_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(0, 124);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(213, 45);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add Product";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.AutoScroll = true;
            this.panelLogo.BackColor = System.Drawing.Color.Indigo;
            this.panelLogo.Controls.Add(this.label_logo2);
            this.panelLogo.Controls.Add(this.label_logo1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(213, 124);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLogo_Paint);
            // 
            // label_logo2
            // 
            this.label_logo2.AutoSize = true;
            this.label_logo2.Font = new System.Drawing.Font("hooge 05_53", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logo2.ForeColor = System.Drawing.Color.White;
            this.label_logo2.Location = new System.Drawing.Point(12, 67);
            this.label_logo2.Name = "label_logo2";
            this.label_logo2.Size = new System.Drawing.Size(190, 30);
            this.label_logo2.TabIndex = 2;
            this.label_logo2.Text = "Warehouse";
            this.label_logo2.Click += new System.EventHandler(this.Label_logo1_Click);
            // 
            // label_logo1
            // 
            this.label_logo1.AutoSize = true;
            this.label_logo1.Font = new System.Drawing.Font("hooge 05_53", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logo1.ForeColor = System.Drawing.Color.White;
            this.label_logo1.Location = new System.Drawing.Point(12, 31);
            this.label_logo1.Name = "label_logo1";
            this.label_logo1.Size = new System.Drawing.Size(140, 30);
            this.label_logo1.TabIndex = 2;
            this.label_logo1.Text = "Mashari";
            this.label_logo1.Click += new System.EventHandler(this.Label_logo1_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Indigo;
            this.panel_top.Controls.Add(this.pictureBox3);
            this.panel_top.Controls.Add(this.pictureBox1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(213, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(587, 28);
            this.panel_top.TabIndex = 1;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_top_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_top_MouseMove);
            this.panel_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_top_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(515, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(550, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // productadd1
            // 
            this.productadd1.BackColor = System.Drawing.Color.White;
            this.productadd1.Location = new System.Drawing.Point(214, 28);
            this.productadd1.Margin = new System.Windows.Forms.Padding(4);
            this.productadd1.Name = "productadd1";
            this.productadd1.Size = new System.Drawing.Size(588, 523);
            this.productadd1.TabIndex = 7;
            // 
            // productupdate1
            // 
            this.productupdate1.BackColor = System.Drawing.Color.White;
            this.productupdate1.Location = new System.Drawing.Point(214, 28);
            this.productupdate1.Margin = new System.Windows.Forms.Padding(4);
            this.productupdate1.Name = "productupdate1";
            this.productupdate1.Size = new System.Drawing.Size(588, 523);
            this.productupdate1.TabIndex = 6;
            // 
            // productdelete1
            // 
            this.productdelete1.BackColor = System.Drawing.Color.White;
            this.productdelete1.Location = new System.Drawing.Point(214, 28);
            this.productdelete1.Margin = new System.Windows.Forms.Padding(4);
            this.productdelete1.Name = "productdelete1";
            this.productdelete1.Size = new System.Drawing.Size(588, 523);
            this.productdelete1.TabIndex = 5;
            // 
            // productsearch1
            // 
            this.productsearch1.BackColor = System.Drawing.Color.White;
            this.productsearch1.Location = new System.Drawing.Point(214, 28);
            this.productsearch1.Margin = new System.Windows.Forms.Padding(4);
            this.productsearch1.Name = "productsearch1";
            this.productsearch1.Size = new System.Drawing.Size(588, 523);
            this.productsearch1.TabIndex = 4;
            // 
            // productout1
            // 
            this.productout1.BackColor = System.Drawing.Color.White;
            this.productout1.Location = new System.Drawing.Point(214, 28);
            this.productout1.Margin = new System.Windows.Forms.Padding(4);
            this.productout1.Name = "productout1";
            this.productout1.Size = new System.Drawing.Size(588, 523);
            this.productout1.TabIndex = 2;
            // 
            // productshowall2
            // 
            this.productshowall2.BackColor = System.Drawing.Color.White;
            this.productshowall2.Location = new System.Drawing.Point(214, 28);
            this.productshowall2.Margin = new System.Windows.Forms.Padding(4);
            this.productshowall2.Name = "productshowall2";
            this.productshowall2.Size = new System.Drawing.Size(588, 523);
            this.productshowall2.TabIndex = 8;
            // 
            // mainform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.productadd1);
            this.Controls.Add(this.productupdate1);
            this.Controls.Add(this.productdelete1);
            this.Controls.Add(this.productsearch1);
            this.Controls.Add(this.productout1);
            this.Controls.Add(this.productshowall2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "mainform1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mashari Warehouse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mainform1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mainform1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mainform1_MouseUp);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button button_out;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label label_logo1;
        private System.Windows.Forms.Label label_logo2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private productout productout1;
        private productsearch productsearch1;
        private productdelete productdelete1;
        private productupdate productupdate1;
        private productadd productadd1;
        private productshowall productshowall2;
    }
}

