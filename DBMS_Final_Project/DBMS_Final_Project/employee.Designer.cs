namespace DBMS_Final_Project
{
    partial class employee
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
            this.DGV_employee = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.Txt_EmpPhone = new System.Windows.Forms.TextBox();
            this.Txt_EmpName = new System.Windows.Forms.TextBox();
            this.Txt_EmpID = new System.Windows.Forms.TextBox();
            this.Lbl_EmpPhone = new System.Windows.Forms.Label();
            this.Lbl_EmpName = new System.Windows.Forms.Label();
            this.Lbl_EmpID = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.Lbl_select_operation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_attribute = new System.Windows.Forms.ComboBox();
            this.Lbl_equal = new System.Windows.Forms.Label();
            this.Txt_condition = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_employee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_employee
            // 
            this.DGV_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_employee.Location = new System.Drawing.Point(12, 164);
            this.DGV_employee.Name = "DGV_employee";
            this.DGV_employee.RowTemplate.Height = 24;
            this.DGV_employee.Size = new System.Drawing.Size(427, 150);
            this.DGV_employee.TabIndex = 23;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(364, 77);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(364, 48);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(364, 19);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 20;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // Txt_EmpPhone
            // 
            this.Txt_EmpPhone.Location = new System.Drawing.Point(159, 77);
            this.Txt_EmpPhone.Name = "Txt_EmpPhone";
            this.Txt_EmpPhone.Size = new System.Drawing.Size(199, 22);
            this.Txt_EmpPhone.TabIndex = 18;
            // 
            // Txt_EmpName
            // 
            this.Txt_EmpName.Location = new System.Drawing.Point(159, 49);
            this.Txt_EmpName.Name = "Txt_EmpName";
            this.Txt_EmpName.Size = new System.Drawing.Size(199, 22);
            this.Txt_EmpName.TabIndex = 17;
            // 
            // Txt_EmpID
            // 
            this.Txt_EmpID.Location = new System.Drawing.Point(159, 21);
            this.Txt_EmpID.Name = "Txt_EmpID";
            this.Txt_EmpID.Size = new System.Drawing.Size(199, 22);
            this.Txt_EmpID.TabIndex = 16;
            // 
            // Lbl_EmpPhone
            // 
            this.Lbl_EmpPhone.AutoSize = true;
            this.Lbl_EmpPhone.Location = new System.Drawing.Point(10, 80);
            this.Lbl_EmpPhone.Name = "Lbl_EmpPhone";
            this.Lbl_EmpPhone.Size = new System.Drawing.Size(137, 12);
            this.Lbl_EmpPhone.TabIndex = 14;
            this.Lbl_EmpPhone.Text = "EmpPhone(e.g. e1111111) :";
            // 
            // Lbl_EmpName
            // 
            this.Lbl_EmpName.AutoSize = true;
            this.Lbl_EmpName.Location = new System.Drawing.Point(11, 52);
            this.Lbl_EmpName.Name = "Lbl_EmpName";
            this.Lbl_EmpName.Size = new System.Drawing.Size(139, 12);
            this.Lbl_EmpName.TabIndex = 13;
            this.Lbl_EmpName.Text = "EmpName(e.g. employee1) :";
            // 
            // Lbl_EmpID
            // 
            this.Lbl_EmpID.AutoSize = true;
            this.Lbl_EmpID.Location = new System.Drawing.Point(12, 24);
            this.Lbl_EmpID.Name = "Lbl_EmpID";
            this.Lbl_EmpID.Size = new System.Drawing.Size(84, 12);
            this.Lbl_EmpID.TabIndex = 12;
            this.Lbl_EmpID.Text = "EmpID(e.g. e1) :";
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
            // Lbl_select_operation
            // 
            this.Lbl_select_operation.AutoSize = true;
            this.Lbl_select_operation.Location = new System.Drawing.Point(14, 22);
            this.Lbl_select_operation.Name = "Lbl_select_operation";
            this.Lbl_select_operation.Size = new System.Drawing.Size(100, 12);
            this.Lbl_select_operation.TabIndex = 25;
            this.Lbl_select_operation.Text = "SELECT * WHERE";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Txt_condition);
            this.panel1.Controls.Add(this.Lbl_equal);
            this.panel1.Controls.Add(this.cbo_attribute);
            this.panel1.Controls.Add(this.Lbl_select_operation);
            this.panel1.Controls.Add(this.btn_select);
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 52);
            this.panel1.TabIndex = 26;
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
            // Lbl_equal
            // 
            this.Lbl_equal.AutoSize = true;
            this.Lbl_equal.Location = new System.Drawing.Point(211, 21);
            this.Lbl_equal.Name = "Lbl_equal";
            this.Lbl_equal.Size = new System.Drawing.Size(11, 12);
            this.Lbl_equal.TabIndex = 29;
            this.Lbl_equal.Text = "=";
            // 
            // Txt_condition
            // 
            this.Txt_condition.Location = new System.Drawing.Point(228, 16);
            this.Txt_condition.Name = "Txt_condition";
            this.Txt_condition.Size = new System.Drawing.Size(100, 22);
            this.Txt_condition.TabIndex = 27;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_employee);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.Txt_EmpPhone);
            this.Controls.Add(this.Txt_EmpName);
            this.Controls.Add(this.Txt_EmpID);
            this.Controls.Add(this.Lbl_EmpPhone);
            this.Controls.Add(this.Lbl_EmpName);
            this.Controls.Add(this.Lbl_EmpID);
            this.Name = "employee";
            this.Text = "employee";
            this.Load += new System.EventHandler(this.employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_employee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_employee;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox Txt_EmpPhone;
        private System.Windows.Forms.TextBox Txt_EmpName;
        private System.Windows.Forms.TextBox Txt_EmpID;
        private System.Windows.Forms.Label Lbl_EmpPhone;
        private System.Windows.Forms.Label Lbl_EmpName;
        private System.Windows.Forms.Label Lbl_EmpID;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label Lbl_select_operation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_condition;
        private System.Windows.Forms.Label Lbl_equal;
        private System.Windows.Forms.ComboBox cbo_attribute;
    }
}