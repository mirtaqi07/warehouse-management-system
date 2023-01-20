namespace FinalPrij
{
    partial class productsearch
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
            this.label_search_msg = new System.Windows.Forms.Label();
            this.textBox_search_id = new System.Windows.Forms.TextBox();
            this.label_search_id = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.label_search_price = new System.Windows.Forms.Label();
            this.label_search_quantity = new System.Windows.Forms.Label();
            this.label_search_company = new System.Windows.Forms.Label();
            this.label_search_name = new System.Windows.Forms.Label();
            this.textBox_search_price = new System.Windows.Forms.TextBox();
            this.textBox_search_quantity = new System.Windows.Forms.TextBox();
            this.textBox_search_company = new System.Windows.Forms.TextBox();
            this.textBox_search_name = new System.Windows.Forms.TextBox();
            this.label_search_msg1 = new System.Windows.Forms.Label();
            this.label_search_msg2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label_search_msg
            // 
            this.label_search_msg.AutoSize = true;
            this.label_search_msg.ForeColor = System.Drawing.Color.Indigo;
            this.label_search_msg.Location = new System.Drawing.Point(35, 44);
            this.label_search_msg.Name = "label_search_msg";
            this.label_search_msg.Size = new System.Drawing.Size(161, 13);
            this.label_search_msg.TabIndex = 62;
            this.label_search_msg.Text = "Enter The Product ID To Search";
            // 
            // textBox_search_id
            // 
            this.textBox_search_id.BackColor = System.Drawing.Color.White;
            this.textBox_search_id.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_search_id.Location = new System.Drawing.Point(199, 68);
            this.textBox_search_id.Name = "textBox_search_id";
            this.textBox_search_id.Size = new System.Drawing.Size(148, 20);
            this.textBox_search_id.TabIndex = 61;
            this.toolTip1.SetToolTip(this.textBox_search_id, "Enter Product ID which is stored");
            this.textBox_search_id.TextChanged += new System.EventHandler(this.TextBox_search_id_TextChanged);
            this.textBox_search_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_search_id_KeyPress);
            // 
            // label_search_id
            // 
            this.label_search_id.AutoSize = true;
            this.label_search_id.BackColor = System.Drawing.Color.White;
            this.label_search_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_search_id.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search_id.ForeColor = System.Drawing.Color.Indigo;
            this.label_search_id.Location = new System.Drawing.Point(34, 68);
            this.label_search_id.Name = "label_search_id";
            this.label_search_id.Size = new System.Drawing.Size(146, 23);
            this.label_search_id.TabIndex = 60;
            this.label_search_id.Text = "Product ID       :";
            this.label_search_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Indigo;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("hooge 05_53", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(234, 119);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(78, 25);
            this.button_search.TabIndex = 63;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // label_search_price
            // 
            this.label_search_price.AutoSize = true;
            this.label_search_price.BackColor = System.Drawing.Color.White;
            this.label_search_price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_search_price.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search_price.ForeColor = System.Drawing.Color.Indigo;
            this.label_search_price.Location = new System.Drawing.Point(34, 292);
            this.label_search_price.Name = "label_search_price";
            this.label_search_price.Size = new System.Drawing.Size(141, 23);
            this.label_search_price.TabIndex = 73;
            this.label_search_price.Text = "Product Price  :";
            this.label_search_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_search_price.Visible = false;
            // 
            // label_search_quantity
            // 
            this.label_search_quantity.AutoSize = true;
            this.label_search_quantity.BackColor = System.Drawing.Color.White;
            this.label_search_quantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_search_quantity.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search_quantity.ForeColor = System.Drawing.Color.Indigo;
            this.label_search_quantity.Location = new System.Drawing.Point(34, 252);
            this.label_search_quantity.Name = "label_search_quantity";
            this.label_search_quantity.Size = new System.Drawing.Size(177, 23);
            this.label_search_quantity.TabIndex = 72;
            this.label_search_quantity.Text = "Product Quantity  :";
            this.label_search_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_search_quantity.Visible = false;
            // 
            // label_search_company
            // 
            this.label_search_company.AutoSize = true;
            this.label_search_company.BackColor = System.Drawing.Color.White;
            this.label_search_company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_search_company.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search_company.ForeColor = System.Drawing.Color.Indigo;
            this.label_search_company.Location = new System.Drawing.Point(34, 212);
            this.label_search_company.Name = "label_search_company";
            this.label_search_company.Size = new System.Drawing.Size(185, 23);
            this.label_search_company.TabIndex = 71;
            this.label_search_company.Text = "Product Company  :";
            this.label_search_company.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_search_company.Visible = false;
            // 
            // label_search_name
            // 
            this.label_search_name.AutoSize = true;
            this.label_search_name.BackColor = System.Drawing.Color.White;
            this.label_search_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_search_name.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search_name.ForeColor = System.Drawing.Color.Indigo;
            this.label_search_name.Location = new System.Drawing.Point(34, 172);
            this.label_search_name.Name = "label_search_name";
            this.label_search_name.Size = new System.Drawing.Size(151, 23);
            this.label_search_name.TabIndex = 70;
            this.label_search_name.Text = "Product Name  :";
            this.label_search_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_search_name.Visible = false;
            this.label_search_name.Click += new System.EventHandler(this.Label_search_name_Click);
            // 
            // textBox_search_price
            // 
            this.textBox_search_price.BackColor = System.Drawing.Color.White;
            this.textBox_search_price.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_search_price.Location = new System.Drawing.Point(199, 292);
            this.textBox_search_price.Name = "textBox_search_price";
            this.textBox_search_price.ReadOnly = true;
            this.textBox_search_price.Size = new System.Drawing.Size(148, 20);
            this.textBox_search_price.TabIndex = 69;
            this.textBox_search_price.Visible = false;
            // 
            // textBox_search_quantity
            // 
            this.textBox_search_quantity.BackColor = System.Drawing.Color.White;
            this.textBox_search_quantity.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_search_quantity.Location = new System.Drawing.Point(199, 253);
            this.textBox_search_quantity.Name = "textBox_search_quantity";
            this.textBox_search_quantity.ReadOnly = true;
            this.textBox_search_quantity.Size = new System.Drawing.Size(148, 20);
            this.textBox_search_quantity.TabIndex = 68;
            this.textBox_search_quantity.Visible = false;
            // 
            // textBox_search_company
            // 
            this.textBox_search_company.BackColor = System.Drawing.Color.White;
            this.textBox_search_company.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_search_company.Location = new System.Drawing.Point(199, 213);
            this.textBox_search_company.Name = "textBox_search_company";
            this.textBox_search_company.ReadOnly = true;
            this.textBox_search_company.Size = new System.Drawing.Size(148, 20);
            this.textBox_search_company.TabIndex = 67;
            this.textBox_search_company.Visible = false;
            // 
            // textBox_search_name
            // 
            this.textBox_search_name.BackColor = System.Drawing.Color.White;
            this.textBox_search_name.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_search_name.Location = new System.Drawing.Point(199, 173);
            this.textBox_search_name.Name = "textBox_search_name";
            this.textBox_search_name.ReadOnly = true;
            this.textBox_search_name.Size = new System.Drawing.Size(148, 20);
            this.textBox_search_name.TabIndex = 66;
            this.textBox_search_name.Visible = false;
            // 
            // label_search_msg1
            // 
            this.label_search_msg1.AutoSize = true;
            this.label_search_msg1.ForeColor = System.Drawing.Color.Indigo;
            this.label_search_msg1.Location = new System.Drawing.Point(208, 147);
            this.label_search_msg1.Name = "label_search_msg1";
            this.label_search_msg1.Size = new System.Drawing.Size(130, 13);
            this.label_search_msg1.TabIndex = 62;
            this.label_search_msg1.Text = "Product ID is matched...!!!";
            this.label_search_msg1.Visible = false;
            this.label_search_msg1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label_search_msg2
            // 
            this.label_search_msg2.AutoSize = true;
            this.label_search_msg2.ForeColor = System.Drawing.Color.Indigo;
            this.label_search_msg2.Location = new System.Drawing.Point(199, 147);
            this.label_search_msg2.Name = "label_search_msg2";
            this.label_search_msg2.Size = new System.Drawing.Size(148, 13);
            this.label_search_msg2.TabIndex = 62;
            this.label_search_msg2.Text = "Product ID is not matched...!!!";
            this.label_search_msg2.Visible = false;
            this.label_search_msg2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // productsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_search_price);
            this.Controls.Add(this.label_search_quantity);
            this.Controls.Add(this.label_search_company);
            this.Controls.Add(this.label_search_name);
            this.Controls.Add(this.textBox_search_price);
            this.Controls.Add(this.textBox_search_quantity);
            this.Controls.Add(this.textBox_search_company);
            this.Controls.Add(this.textBox_search_name);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_search_msg1);
            this.Controls.Add(this.label_search_msg);
            this.Controls.Add(this.textBox_search_id);
            this.Controls.Add(this.label_search_id);
            this.Controls.Add(this.label_search_msg2);
            this.Name = "productsearch";
            this.Size = new System.Drawing.Size(586, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_search_msg;
        private System.Windows.Forms.TextBox textBox_search_id;
        internal System.Windows.Forms.Label label_search_id;
        private System.Windows.Forms.Button button_search;
        internal System.Windows.Forms.Label label_search_price;
        internal System.Windows.Forms.Label label_search_quantity;
        internal System.Windows.Forms.Label label_search_company;
        internal System.Windows.Forms.Label label_search_name;
        private System.Windows.Forms.TextBox textBox_search_price;
        private System.Windows.Forms.TextBox textBox_search_quantity;
        private System.Windows.Forms.TextBox textBox_search_company;
        private System.Windows.Forms.TextBox textBox_search_name;
        private System.Windows.Forms.Label label_search_msg1;
        private System.Windows.Forms.Label label_search_msg2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
