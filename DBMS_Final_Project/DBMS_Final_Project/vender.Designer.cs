namespace DBMS_Final_Project
{
    partial class vender
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_condition = new System.Windows.Forms.TextBox();
            this.Lbl_equal = new System.Windows.Forms.Label();
            this.cbo_attribute = new System.Windows.Forms.ComboBox();
            this.Lbl_select_operation = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.DGV_vender = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.Txt_venderPhone = new System.Windows.Forms.TextBox();
            this.Txt_venderName = new System.Windows.Forms.TextBox();
            this.Txt_venderID = new System.Windows.Forms.TextBox();
            this.Lbl_venderPhone = new System.Windows.Forms.Label();
            this.Lbl_venderName = new System.Windows.Forms.Label();
            this.Lbl_venderID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_vender)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Txt_condition);
            this.panel1.Controls.Add(this.Lbl_equal);
            this.panel1.Controls.Add(this.cbo_attribute);
            this.panel1.Controls.Add(this.Lbl_select_operation);
            this.panel1.Controls.Add(this.btn_select);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 52);
            this.panel1.TabIndex = 37;
            // 
            // Txt_condition
            // 
            this.Txt_condition.Location = new System.Drawing.Point(228, 16);
            this.Txt_condition.Name = "Txt_condition";
            this.Txt_condition.Size = new System.Drawing.Size(100, 22);
            this.Txt_condition.TabIndex = 27;
            // 
            // Lbl_equal
            // 
            this.Lbl_equal.AutoSize = true;
            this.Lbl_equal.Location = new System.Drawing.Point(211, 21);
            this.Lbl_equal.Name = "Lbl_equal";
            this.Lbl_equal.Size = new System.Drawing.Size(11, 12);
            this.Lbl_equal.TabIndex = 29;
            this.Lbl_equal.Text = "=";
            // 
            // cbo_attribute
            // 
            this.cbo_attribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_attribute.FormattingEnabled = true;
            this.cbo_attribute.Location = new System.Drawing.Point(120, 18);
            this.cbo_attribute.Name = "cbo_attribute";
            this.cbo_attribute.Size = new System.Drawing.Size(85, 20);
            this.cbo_attribute.TabIndex = 28;
            // 
            // Lbl_select_operation
            // 
            this.Lbl_select_operation.AutoSize = true;
            this.Lbl_select_operation.Location = new System.Drawing.Point(14, 22);
            this.Lbl_select_operation.Name = "Lbl_select_operation";
            this.Lbl_select_operation.Size = new System.Drawing.Size(100, 12);
            this.Lbl_select_operation.TabIndex = 25;
            this.Lbl_select_operation.Text = "SELECT * WHERE";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(334, 14);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 24;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // DGV_vender
            // 
            this.DGV_vender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_vender.Location = new System.Drawing.Point(12, 160);
            this.DGV_vender.Name = "DGV_vender";
            this.DGV_vender.RowTemplate.Height = 24;
            this.DGV_vender.Size = new System.Drawing.Size(427, 150);
            this.DGV_vender.TabIndex = 36;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(364, 73);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 35;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(364, 44);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(364, 15);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 33;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // Txt_venderPhone
            // 
            this.Txt_venderPhone.Location = new System.Drawing.Point(159, 73);
            this.Txt_venderPhone.Name = "Txt_venderPhone";
            this.Txt_venderPhone.Size = new System.Drawing.Size(199, 22);
            this.Txt_venderPhone.TabIndex = 32;
            // 
            // Txt_venderName
            // 
            this.Txt_venderName.Location = new System.Drawing.Point(159, 45);
            this.Txt_venderName.Name = "Txt_venderName";
            this.Txt_venderName.Size = new System.Drawing.Size(199, 22);
            this.Txt_venderName.TabIndex = 31;
            // 
            // Txt_venderID
            // 
            this.Txt_venderID.Location = new System.Drawing.Point(159, 17);
            this.Txt_venderID.Name = "Txt_venderID";
            this.Txt_venderID.Size = new System.Drawing.Size(199, 22);
            this.Txt_venderID.TabIndex = 30;
            // 
            // Lbl_venderPhone
            // 
            this.Lbl_venderPhone.AutoSize = true;
            this.Lbl_venderPhone.Location = new System.Drawing.Point(10, 76);
            this.Lbl_venderPhone.Name = "Lbl_venderPhone";
            this.Lbl_venderPhone.Size = new System.Drawing.Size(135, 12);
            this.Lbl_venderPhone.TabIndex = 29;
            this.Lbl_venderPhone.Text = "供應商電話 venderPhone :";
            // 
            // Lbl_venderName
            // 
            this.Lbl_venderName.AutoSize = true;
            this.Lbl_venderName.Location = new System.Drawing.Point(11, 48);
            this.Lbl_venderName.Name = "Lbl_venderName";
            this.Lbl_venderName.Size = new System.Drawing.Size(121, 12);
            this.Lbl_venderName.TabIndex = 28;
            this.Lbl_venderName.Text = "供應商名 venderName :";
            // 
            // Lbl_venderID
            // 
            this.Lbl_venderID.AutoSize = true;
            this.Lbl_venderID.Location = new System.Drawing.Point(12, 20);
            this.Lbl_venderID.Name = "Lbl_venderID";
            this.Lbl_venderID.Size = new System.Drawing.Size(121, 12);
            this.Lbl_venderID.TabIndex = 27;
            this.Lbl_venderID.Text = "供應商編號 venderID  :";
            // 
            // vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_vender);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.Txt_venderPhone);
            this.Controls.Add(this.Txt_venderName);
            this.Controls.Add(this.Txt_venderID);
            this.Controls.Add(this.Lbl_venderPhone);
            this.Controls.Add(this.Lbl_venderName);
            this.Controls.Add(this.Lbl_venderID);
            this.Name = "vender";
            this.Text = "vender";
            this.Load += new System.EventHandler(this.vender_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_vender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_condition;
        private System.Windows.Forms.Label Lbl_equal;
        private System.Windows.Forms.ComboBox cbo_attribute;
        private System.Windows.Forms.Label Lbl_select_operation;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView DGV_vender;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox Txt_venderPhone;
        private System.Windows.Forms.TextBox Txt_venderName;
        private System.Windows.Forms.TextBox Txt_venderID;
        private System.Windows.Forms.Label Lbl_venderPhone;
        private System.Windows.Forms.Label Lbl_venderName;
        private System.Windows.Forms.Label Lbl_venderID;
    }
}