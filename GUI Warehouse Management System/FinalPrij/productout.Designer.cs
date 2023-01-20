namespace FinalPrij
{
    partial class productout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_out_msg = new System.Windows.Forms.Label();
            this.textBox_out_id = new System.Windows.Forms.TextBox();
            this.label_out_id = new System.Windows.Forms.Label();
            this.button_out1 = new System.Windows.Forms.Button();
            this.label_out_price = new System.Windows.Forms.Label();
            this.label_out_quantity1 = new System.Windows.Forms.Label();
            this.label_out_company = new System.Windows.Forms.Label();
            this.label_out_name = new System.Windows.Forms.Label();
            this.textBox_out_price = new System.Windows.Forms.TextBox();
            this.textBox_out_quantity1 = new System.Windows.Forms.TextBox();
            this.textBox_out_company = new System.Windows.Forms.TextBox();
            this.textBox_out_name = new System.Windows.Forms.TextBox();
            this.label_out_quantity2 = new System.Windows.Forms.Label();
            this.textBox_out_quantity2 = new System.Windows.Forms.TextBox();
            this.label_out_msg3 = new System.Windows.Forms.Label();
            this.button_out2 = new System.Windows.Forms.Button();
            this.label_out_msg4 = new System.Windows.Forms.Label();
            this.label_out_msg1 = new System.Windows.Forms.Label();
            this.label_out_msg2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label_out_msg
            // 
            this.label_out_msg.AutoSize = true;
            this.label_out_msg.ForeColor = System.Drawing.Color.Indigo;
            this.label_out_msg.Location = new System.Drawing.Point(35, 44);
            this.label_out_msg.Name = "label_out_msg";
            this.label_out_msg.Size = new System.Drawing.Size(175, 13);
            this.label_out_msg.TabIndex = 62;
            this.label_out_msg.Text = "Enter The Product ID To Take Out ";
            // 
            // textBox_out_id
            // 
            this.textBox_out_id.BackColor = System.Drawing.Color.White;
            this.textBox_out_id.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_out_id.Location = new System.Drawing.Point(199, 68);
            this.textBox_out_id.Name = "textBox_out_id";
            this.textBox_out_id.Size = new System.Drawing.Size(148, 20);
            this.textBox_out_id.TabIndex = 73;
            this.toolTip1.SetToolTip(this.textBox_out_id, "Enter Product ID to take out Product");
            this.textBox_out_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_out_id_KeyPress);
            // 
            // label_out_id
            // 
            this.label_out_id.AutoSize = true;
            this.label_out_id.BackColor = System.Drawing.Color.White;
            this.label_out_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_out_id.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_out_id.ForeColor = System.Drawing.Color.Indigo;
            this.label_out_id.Location = new System.Drawing.Point(34, 68);
            this.label_out_id.Name = "label_out_id";
            this.label_out_id.Size = new System.Drawing.Size(146, 23);
            this.label_out_id.TabIndex = 60;
            this.label_out_id.Text = "Product ID       :";
            this.label_out_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_out1
            // 
            this.button_out1.BackColor = System.Drawing.Color.Indigo;
            this.button_out1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_out1.Font = new System.Drawing.Font("hooge 05_53", 10F);
            this.button_out1.ForeColor = System.Drawing.Color.White;
            this.button_out1.Location = new System.Drawing.Point(236, 117);
            this.button_out1.Name = "button_out1";
            this.button_out1.Size = new System.Drawing.Size(75, 25);
            this.button_out1.TabIndex = 74;
            this.button_out1.Text = "Enter";
            this.button_out1.UseVisualStyleBackColor = false;
            this.button_out1.Click += new System.EventHandler(this.Button_out_Click);
            // 
            // label_out_price
            // 
            this.label_out_price.AutoSize = true;
            this.label_out_price.BackColor = System.Drawing.Color.White;
            this.label_out_price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_out_price.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_out_price.ForeColor = System.Drawing.Color.Indigo;
            this.label_out_price.Location = new System.Drawing.Point(34, 287);
            this.label_out_price.Name = "label_out_price";
            this.label_out_price.Size = new System.Drawing.Size(141, 23);
            this.label_out_price.TabIndex = 81;
            this.label_out_price.Text = "Product Price  :";
            this.label_out_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_out_price.Visible = false;
            // 
            // label_out_quantity1
            // 
            this.label_out_quantity1.AutoSize = true;
            this.label_out_quantity1.BackColor = System.Drawing.Color.White;
            this.label_out_quantity1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_out_quantity1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_out_quantity1.ForeColor = System.Drawing.Color.Indigo;
            this.label_out_quantity1.Location = new System.Drawing.Point(34, 247);
            this.label_out_quantity1.Name = "label_out_quantity1";
            this.label_out_quantity1.Size = new System.Drawing.Size(177, 23);
            this.label_out_quantity1.TabIndex = 80;
            this.label_out_quantity1.Text = "Product Quantity  :";
            this.label_out_quantity1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_out_quantity1.Visible = false;
            // 
            // label_out_company
            // 
            this.label_out_company.AutoSize = true;
            this.label_out_company.BackColor = System.Drawing.Color.White;
            this.label_out_company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_out_company.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_out_company.ForeColor = System.Drawing.Color.Indigo;
            this.label_out_company.Location = new System.Drawing.Point(34, 207);
            this.label_out_company.Name = "label_out_company";
            this.label_out_company.Size = new System.Drawing.Size(185, 23);
            this.label_out_company.TabIndex = 79;
            this.label_out_company.Text = "Product Company  :";
            this.label_out_company.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_out_company.Visible = false;
            // 
            // label_out_name
            // 
            this.label_out_name.AutoSize = true;
            this.label_out_name.BackColor = System.Drawing.Color.White;
            this.label_out_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_out_name.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_out_name.ForeColor = System.Drawing.Color.Indigo;
            this.label_out_name.Location = new System.Drawing.Point(34, 167);
            this.label_out_name.Name = "label_out_name";
            this.label_out_name.Size = new System.Drawing.Size(151, 23);
            this.label_out_name.TabIndex = 78;
            this.label_out_name.Text = "Product Name  :";
            this.label_out_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_out_name.Visible = false;
            // 
            // textBox_out_price
            // 
            this.textBox_out_price.BackColor = System.Drawing.Color.White;
            this.textBox_out_price.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_out_price.Location = new System.Drawing.Point(214, 287);
            this.textBox_out_price.Name = "textBox_out_price";
            this.textBox_out_price.ReadOnly = true;
            this.textBox_out_price.Size = new System.Drawing.Size(148, 20);
            this.textBox_out_price.TabIndex = 78;
            this.textBox_out_price.Visible = false;
            // 
            // textBox_out_quantity1
            // 
            this.textBox_out_quantity1.BackColor = System.Drawing.Color.White;
            this.textBox_out_quantity1.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_out_quantity1.Location = new System.Drawing.Point(214, 248);
            this.textBox_out_quantity1.Name = "textBox_out_quantity1";
            this.textBox_out_quantity1.ReadOnly = true;
            this.textBox_out_quantity1.Size = new System.Drawing.Size(148, 20);
            this.textBox_out_quantity1.TabIndex = 77;
            this.textBox_out_quantity1.Visible = false;
            // 
            // textBox_out_company
            // 
            this.textBox_out_company.BackColor = System.Drawing.Color.White;
            this.textBox_out_company.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_out_company.Location = new System.Drawing.Point(214, 208);
            this.textBox_out_company.Name = "textBox_out_company";
            this.textBox_out_company.ReadOnly = true;
            this.textBox_out_company.Size = new System.Drawing.Size(148, 20);
            this.textBox_out_company.TabIndex = 76;
            this.textBox_out_company.Visible = false;
            // 
            // textBox_out_name
            // 
            this.textBox_out_name.BackColor = System.Drawing.Color.White;
            this.textBox_out_name.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_out_name.Location = new System.Drawing.Point(214, 168);
            this.textBox_out_name.Name = "textBox_out_name";
            this.textBox_out_name.ReadOnly = true;
            this.textBox_out_name.Size = new System.Drawing.Size(148, 20);
            this.textBox_out_name.TabIndex = 75;
            this.textBox_out_name.Visible = false;
            // 
            // label_out_quantity2
            // 
            this.label_out_quantity2.AutoSize = true;
            this.label_out_quantity2.BackColor = System.Drawing.Color.White;
            this.label_out_quantity2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_out_quantity2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_out_quantity2.ForeColor = System.Drawing.Color.Indigo;
            this.label_out_quantity2.Location = new System.Drawing.Point(34, 326);
            this.label_out_quantity2.Name = "label_out_quantity2";
            this.label_out_quantity2.Size = new System.Drawing.Size(234, 23);
            this.label_out_quantity2.TabIndex = 81;
            this.label_out_quantity2.Text = "Take out Product out of  :";
            this.label_out_quantity2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_out_quantity2.Visible = false;
            // 
            // textBox_out_quantity2
            // 
            this.textBox_out_quantity2.BackColor = System.Drawing.Color.White;
            this.textBox_out_quantity2.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_out_quantity2.Location = new System.Drawing.Point(272, 326);
            this.textBox_out_quantity2.Name = "textBox_out_quantity2";
            this.textBox_out_quantity2.Size = new System.Drawing.Size(90, 20);
            this.textBox_out_quantity2.TabIndex = 79;
            this.toolTip1.SetToolTip(this.textBox_out_quantity2, "Product Quantity should be less than or equal to stored quantity");
            this.textBox_out_quantity2.Visible = false;
            this.textBox_out_quantity2.TextChanged += new System.EventHandler(this.TextBox_out_quantity2_TextChanged);
            this.textBox_out_quantity2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_out_id_KeyPress);
            // 
            // label_out_msg3
            // 
            this.label_out_msg3.AutoSize = true;
            this.label_out_msg3.ForeColor = System.Drawing.Color.Indigo;
            this.label_out_msg3.Location = new System.Drawing.Point(219, 408);
            this.label_out_msg3.Name = "label_out_msg3";
            this.label_out_msg3.Size = new System.Drawing.Size(180, 13);
            this.label_out_msg3.TabIndex = 82;
            this.label_out_msg3.Text = "Product is taken out successfully...!!!";
            this.label_out_msg3.Visible = false;
            // 
            // button_out2
            // 
            this.button_out2.BackColor = System.Drawing.Color.Indigo;
            this.button_out2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_out2.Font = new System.Drawing.Font("hooge 05_53", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_out2.ForeColor = System.Drawing.Color.White;
            this.button_out2.Location = new System.Drawing.Point(272, 371);
            this.button_out2.Name = "button_out2";
            this.button_out2.Size = new System.Drawing.Size(75, 25);
            this.button_out2.TabIndex = 90;
            this.button_out2.Text = "Enter";
            this.toolTip1.SetToolTip(this.button_out2, "This will take out the entered quantity");
            this.button_out2.UseVisualStyleBackColor = false;
            this.button_out2.Visible = false;
            this.button_out2.Click += new System.EventHandler(this.Button_out2_Click);
            // 
            // label_out_msg4
            // 
            this.label_out_msg4.AutoSize = true;
            this.label_out_msg4.ForeColor = System.Drawing.Color.Indigo;
            this.label_out_msg4.Location = new System.Drawing.Point(228, 408);
            this.label_out_msg4.Name = "label_out_msg4";
            this.label_out_msg4.Size = new System.Drawing.Size(163, 13);
            this.label_out_msg4.TabIndex = 82;
            this.label_out_msg4.Text = "Such quantity is not available...!!!";
            this.label_out_msg4.Visible = false;
            // 
            // label_out_msg1
            // 
            this.label_out_msg1.AutoSize = true;
            this.label_out_msg1.ForeColor = System.Drawing.Color.Indigo;
            this.label_out_msg1.Location = new System.Drawing.Point(207, 145);
            this.label_out_msg1.Name = "label_out_msg1";
            this.label_out_msg1.Size = new System.Drawing.Size(133, 13);
            this.label_out_msg1.TabIndex = 62;
            this.label_out_msg1.Text = "Product ID is matched...!!! ";
            this.label_out_msg1.Visible = false;
            // 
            // label_out_msg2
            // 
            this.label_out_msg2.AutoSize = true;
            this.label_out_msg2.ForeColor = System.Drawing.Color.Indigo;
            this.label_out_msg2.Location = new System.Drawing.Point(196, 145);
            this.label_out_msg2.Name = "label_out_msg2";
            this.label_out_msg2.Size = new System.Drawing.Size(155, 13);
            this.label_out_msg2.TabIndex = 62;
            this.label_out_msg2.Text = "Product ID does not match...!!! ";
            this.label_out_msg2.Visible = false;
            // 
            // productout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_out2);
            this.Controls.Add(this.label_out_msg4);
            this.Controls.Add(this.label_out_msg3);
            this.Controls.Add(this.label_out_quantity2);
            this.Controls.Add(this.label_out_price);
            this.Controls.Add(this.label_out_quantity1);
            this.Controls.Add(this.label_out_company);
            this.Controls.Add(this.label_out_name);
            this.Controls.Add(this.textBox_out_price);
            this.Controls.Add(this.textBox_out_quantity2);
            this.Controls.Add(this.textBox_out_quantity1);
            this.Controls.Add(this.textBox_out_company);
            this.Controls.Add(this.textBox_out_name);
            this.Controls.Add(this.button_out1);
            this.Controls.Add(this.label_out_msg1);
            this.Controls.Add(this.label_out_msg);
            this.Controls.Add(this.textBox_out_id);
            this.Controls.Add(this.label_out_id);
            this.Controls.Add(this.label_out_msg2);
            this.Name = "productout";
            this.Size = new System.Drawing.Size(586, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_out_msg;
        private System.Windows.Forms.TextBox textBox_out_id;
        internal System.Windows.Forms.Label label_out_id;
        private System.Windows.Forms.Button button_out1;
        internal System.Windows.Forms.Label label_out_price;
        internal System.Windows.Forms.Label label_out_quantity1;
        internal System.Windows.Forms.Label label_out_company;
        internal System.Windows.Forms.Label label_out_name;
        private System.Windows.Forms.TextBox textBox_out_price;
        private System.Windows.Forms.TextBox textBox_out_quantity1;
        private System.Windows.Forms.TextBox textBox_out_company;
        private System.Windows.Forms.TextBox textBox_out_name;
        internal System.Windows.Forms.Label label_out_quantity2;
        private System.Windows.Forms.TextBox textBox_out_quantity2;
        private System.Windows.Forms.Label label_out_msg3;
        private System.Windows.Forms.Button button_out2;
        private System.Windows.Forms.Label label_out_msg4;
        private System.Windows.Forms.Label label_out_msg1;
        private System.Windows.Forms.Label label_out_msg2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
