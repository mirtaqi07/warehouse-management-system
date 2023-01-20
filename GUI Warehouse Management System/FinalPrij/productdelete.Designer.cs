namespace FinalPrij
{
    partial class productdelete
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
            this.label_del_msg1 = new System.Windows.Forms.Label();
            this.textBox_del_id = new System.Windows.Forms.TextBox();
            this.label_del_id = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_del_msg3 = new System.Windows.Forms.Label();
            this.label_del_msg2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label_del_msg1
            // 
            this.label_del_msg1.AutoSize = true;
            this.label_del_msg1.ForeColor = System.Drawing.Color.Indigo;
            this.label_del_msg1.Location = new System.Drawing.Point(35, 44);
            this.label_del_msg1.Name = "label_del_msg1";
            this.label_del_msg1.Size = new System.Drawing.Size(158, 13);
            this.label_del_msg1.TabIndex = 56;
            this.label_del_msg1.Text = "Enter The Product ID To Delete";
            // 
            // textBox_del_id
            // 
            this.textBox_del_id.BackColor = System.Drawing.Color.White;
            this.textBox_del_id.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_del_id.Location = new System.Drawing.Point(199, 68);
            this.textBox_del_id.Name = "textBox_del_id";
            this.textBox_del_id.Size = new System.Drawing.Size(148, 20);
            this.textBox_del_id.TabIndex = 55;
            this.toolTip1.SetToolTip(this.textBox_del_id, "Entered Product ID");
            this.textBox_del_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_del_id_KeyPress);
            // 
            // label_del_id
            // 
            this.label_del_id.AutoSize = true;
            this.label_del_id.BackColor = System.Drawing.Color.White;
            this.label_del_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_del_id.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_del_id.ForeColor = System.Drawing.Color.Indigo;
            this.label_del_id.Location = new System.Drawing.Point(34, 68);
            this.label_del_id.Name = "label_del_id";
            this.label_del_id.Size = new System.Drawing.Size(146, 23);
            this.label_del_id.TabIndex = 54;
            this.label_del_id.Text = "Product ID       :";
            this.label_del_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Indigo;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("hooge 05_53", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(234, 119);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(78, 25);
            this.button_delete.TabIndex = 57;
            this.button_delete.Text = "Delete";
            this.toolTip1.SetToolTip(this.button_delete, "Delete information related with this Prouduct ID");
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // label_del_msg3
            // 
            this.label_del_msg3.AutoSize = true;
            this.label_del_msg3.ForeColor = System.Drawing.Color.Indigo;
            this.label_del_msg3.Location = new System.Drawing.Point(196, 156);
            this.label_del_msg3.Name = "label_del_msg3";
            this.label_del_msg3.Size = new System.Drawing.Size(150, 13);
            this.label_del_msg3.TabIndex = 56;
            this.label_del_msg3.Text = "Product Id does not match...!!!";
            this.label_del_msg3.Visible = false;
            // 
            // label_del_msg2
            // 
            this.label_del_msg2.AutoSize = true;
            this.label_del_msg2.ForeColor = System.Drawing.Color.Indigo;
            this.label_del_msg2.Location = new System.Drawing.Point(188, 156);
            this.label_del_msg2.Name = "label_del_msg2";
            this.label_del_msg2.Size = new System.Drawing.Size(170, 13);
            this.label_del_msg2.TabIndex = 58;
            this.label_del_msg2.Text = "Product is deleted successfully...!!!";
            this.label_del_msg2.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup_1);
            // 
            // productdelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label_del_msg3);
            this.Controls.Add(this.label_del_msg1);
            this.Controls.Add(this.textBox_del_id);
            this.Controls.Add(this.label_del_id);
            this.Controls.Add(this.label_del_msg2);
            this.Name = "productdelete";
            this.Size = new System.Drawing.Size(586, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_del_msg1;
        private System.Windows.Forms.TextBox textBox_del_id;
        internal System.Windows.Forms.Label label_del_id;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_del_msg3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label_del_msg2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
