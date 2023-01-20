namespace FinalPrij
{
    partial class productadd
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
            this.label_add_price = new System.Windows.Forms.Label();
            this.label_add_quantity = new System.Windows.Forms.Label();
            this.label_add_company = new System.Windows.Forms.Label();
            this.label_add_name = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.textBox_company = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_add_id = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_add_msg1 = new System.Windows.Forms.Label();
            this.label_add_msg2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label_add_price
            // 
            this.label_add_price.AutoSize = true;
            this.label_add_price.BackColor = System.Drawing.Color.White;
            this.label_add_price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_add_price.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_price.ForeColor = System.Drawing.Color.Indigo;
            this.label_add_price.Location = new System.Drawing.Point(35, 204);
            this.label_add_price.Name = "label_add_price";
            this.label_add_price.Size = new System.Drawing.Size(141, 23);
            this.label_add_price.TabIndex = 49;
            this.label_add_price.Text = "Product Price  :";
            this.label_add_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_add_quantity
            // 
            this.label_add_quantity.AutoSize = true;
            this.label_add_quantity.BackColor = System.Drawing.Color.White;
            this.label_add_quantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_add_quantity.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_quantity.ForeColor = System.Drawing.Color.Indigo;
            this.label_add_quantity.Location = new System.Drawing.Point(35, 164);
            this.label_add_quantity.Name = "label_add_quantity";
            this.label_add_quantity.Size = new System.Drawing.Size(177, 23);
            this.label_add_quantity.TabIndex = 48;
            this.label_add_quantity.Text = "Product Quantity  :";
            this.label_add_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_add_company
            // 
            this.label_add_company.AutoSize = true;
            this.label_add_company.BackColor = System.Drawing.Color.White;
            this.label_add_company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_add_company.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_company.ForeColor = System.Drawing.Color.Indigo;
            this.label_add_company.Location = new System.Drawing.Point(35, 124);
            this.label_add_company.Name = "label_add_company";
            this.label_add_company.Size = new System.Drawing.Size(185, 23);
            this.label_add_company.TabIndex = 47;
            this.label_add_company.Text = "Product Company  :";
            this.label_add_company.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_add_name
            // 
            this.label_add_name.AutoSize = true;
            this.label_add_name.BackColor = System.Drawing.Color.White;
            this.label_add_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_add_name.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_name.ForeColor = System.Drawing.Color.Indigo;
            this.label_add_name.Location = new System.Drawing.Point(35, 84);
            this.label_add_name.Name = "label_add_name";
            this.label_add_name.Size = new System.Drawing.Size(151, 23);
            this.label_add_name.TabIndex = 46;
            this.label_add_name.Text = "Product Name  :";
            this.label_add_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.Color.White;
            this.textBox_price.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_price.Location = new System.Drawing.Point(215, 204);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(148, 20);
            this.textBox_price.TabIndex = 45;
            this.toolTip1.SetToolTip(this.textBox_price, "Price Should be in Digits");
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_id_KeyPress);
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.BackColor = System.Drawing.Color.White;
            this.textBox_quantity.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_quantity.Location = new System.Drawing.Point(215, 165);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(148, 20);
            this.textBox_quantity.TabIndex = 44;
            this.toolTip1.SetToolTip(this.textBox_quantity, "Quantity should be in Digits");
            this.textBox_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_id_KeyPress);
            // 
            // textBox_company
            // 
            this.textBox_company.BackColor = System.Drawing.Color.White;
            this.textBox_company.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_company.Location = new System.Drawing.Point(215, 125);
            this.textBox_company.Name = "textBox_company";
            this.textBox_company.Size = new System.Drawing.Size(148, 20);
            this.textBox_company.TabIndex = 43;
            this.toolTip1.SetToolTip(this.textBox_company, "Like : Care");
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.White;
            this.textBox_name.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_name.Location = new System.Drawing.Point(215, 85);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(148, 20);
            this.textBox_name.TabIndex = 42;
            this.toolTip1.SetToolTip(this.textBox_name, "Like : Soap");
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.White;
            this.textBox_id.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_id.Location = new System.Drawing.Point(215, 45);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(148, 20);
            this.textBox_id.TabIndex = 41;
            this.toolTip1.SetToolTip(this.textBox_id, "Only Digits are accepted");
            this.textBox_id.Click += new System.EventHandler(this.TextBox_id_Click);
            this.textBox_id.TextChanged += new System.EventHandler(this.TextBox_id_TextChanged);
            this.textBox_id.Enter += new System.EventHandler(this.TextBox_id_Enter);
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_id_KeyPress);
            this.textBox_id.Leave += new System.EventHandler(this.TextBox_id_Leave);
            // 
            // label_add_id
            // 
            this.label_add_id.AutoSize = true;
            this.label_add_id.BackColor = System.Drawing.Color.White;
            this.label_add_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_add_id.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_id.ForeColor = System.Drawing.Color.Indigo;
            this.label_add_id.Location = new System.Drawing.Point(35, 44);
            this.label_add_id.Name = "label_add_id";
            this.label_add_id.Size = new System.Drawing.Size(121, 23);
            this.label_add_id.TabIndex = 40;
            this.label_add_id.Text = "Product ID  :";
            this.label_add_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Indigo;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("hooge 05_53", 10F);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(252, 255);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 25);
            this.button_add.TabIndex = 50;
            this.button_add.Text = "Enter";
            this.toolTip1.SetToolTip(this.button_add, "Save Your Product");
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // label_add_msg1
            // 
            this.label_add_msg1.AutoSize = true;
            this.label_add_msg1.ForeColor = System.Drawing.Color.Indigo;
            this.label_add_msg1.Location = new System.Drawing.Point(207, 298);
            this.label_add_msg1.Name = "label_add_msg1";
            this.label_add_msg1.Size = new System.Drawing.Size(165, 13);
            this.label_add_msg1.TabIndex = 54;
            this.label_add_msg1.Text = "Product is added successfully...!!!";
            this.label_add_msg1.Visible = false;
            // 
            // label_add_msg2
            // 
            this.label_add_msg2.AutoSize = true;
            this.label_add_msg2.ForeColor = System.Drawing.Color.Indigo;
            this.label_add_msg2.Location = new System.Drawing.Point(247, 298);
            this.label_add_msg2.Name = "label_add_msg2";
            this.label_add_msg2.Size = new System.Drawing.Size(84, 13);
            this.label_add_msg2.TabIndex = 54;
            this.label_add_msg2.Text = "Fill all the blanks";
            this.label_add_msg2.Visible = false;
            // 
            // productadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_add_msg2);
            this.Controls.Add(this.label_add_msg1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_add_price);
            this.Controls.Add(this.label_add_quantity);
            this.Controls.Add(this.label_add_company);
            this.Controls.Add(this.label_add_name);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.textBox_company);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_add_id);
            this.Name = "productadd";
            this.Size = new System.Drawing.Size(586, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label_add_price;
        internal System.Windows.Forms.Label label_add_quantity;
        internal System.Windows.Forms.Label label_add_company;
        internal System.Windows.Forms.Label label_add_name;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.TextBox textBox_company;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        internal System.Windows.Forms.Label label_add_id;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_add_msg1;
        private System.Windows.Forms.Label label_add_msg2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
