namespace DBMS_Final_Project
{
    partial class orders
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
            this.cbo_attribute = new System.Windows.Forms.ComboBox();
            this.Txt_condition = new System.Windows.Forms.TextBox();
            this.Lbl_select_operation = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.DGV_orders = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.Txt_deliverDate = new System.Windows.Forms.TextBox();
            this.Txt_fare = new System.Windows.Forms.TextBox();
            this.Txt_orderID = new System.Windows.Forms.TextBox();
            this.Lbl_deliverDate = new System.Windows.Forms.Label();
            this.Lbl_fare = new System.Windows.Forms.Label();
            this.Lbl_orderID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbo_attribute);
            this.panel1.Controls.Add(this.Txt_condition);
            this.panel1.Controls.Add(this.Lbl_select_operation);
            this.panel1.Controls.Add(this.btn_select);
            this.panel1.Location = new System.Drawing.Point(12, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 52);
            this.panel1.TabIndex = 40;
            // 
            // cbo_attribute
            // 
            this.cbo_attribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_attribute.FormattingEnabled = true;
            this.cbo_attribute.Location = new System.Drawing.Point(120, 17);
            this.cbo_attribute.Name = "cbo_attribute";
            this.cbo_attribute.Size = new System.Drawing.Size(85, 20);
            this.cbo_attribute.TabIndex = 28;
            // 
            // Txt_condition
            // 
            this.Txt_condition.Location = new System.Drawing.Point(211, 16);
            this.Txt_condition.Name = "Txt_condition";
            this.Txt_condition.Size = new System.Drawing.Size(137, 22);
            this.Txt_condition.TabIndex = 27;
            this.Txt_condition.Text = "=還是>,<,>=,<=要打在這";
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
            this.btn_select.Location = new System.Drawing.Point(354, 14);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 24;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // DGV_orders
            // 
            this.DGV_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_orders.Location = new System.Drawing.Point(12, 193);
            this.DGV_orders.Name = "DGV_orders";
            this.DGV_orders.RowTemplate.Height = 24;
            this.DGV_orders.Size = new System.Drawing.Size(429, 150);
            this.DGV_orders.TabIndex = 39;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(377, 78);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 38;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(377, 49);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 37;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(377, 16);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 36;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // Txt_deliverDate
            // 
            this.Txt_deliverDate.Location = new System.Drawing.Point(177, 79);
            this.Txt_deliverDate.Name = "Txt_deliverDate";
            this.Txt_deliverDate.Size = new System.Drawing.Size(184, 22);
            this.Txt_deliverDate.TabIndex = 34;
            // 
            // Txt_fare
            // 
            this.Txt_fare.Location = new System.Drawing.Point(177, 49);
            this.Txt_fare.Name = "Txt_fare";
            this.Txt_fare.Size = new System.Drawing.Size(184, 22);
            this.Txt_fare.TabIndex = 33;
            // 
            // Txt_orderID
            // 
            this.Txt_orderID.Location = new System.Drawing.Point(177, 16);
            this.Txt_orderID.Name = "Txt_orderID";
            this.Txt_orderID.Size = new System.Drawing.Size(184, 22);
            this.Txt_orderID.TabIndex = 32;
            // 
            // Lbl_deliverDate
            // 
            this.Lbl_deliverDate.AutoSize = true;
            this.Lbl_deliverDate.Location = new System.Drawing.Point(10, 82);
            this.Lbl_deliverDate.Name = "Lbl_deliverDate";
            this.Lbl_deliverDate.Size = new System.Drawing.Size(166, 12);
            this.Lbl_deliverDate.TabIndex = 30;
            this.Lbl_deliverDate.Text = "deliverDate(e.g. YYYY/MM/DD) :";
            // 
            // Lbl_fare
            // 
            this.Lbl_fare.AutoSize = true;
            this.Lbl_fare.Location = new System.Drawing.Point(11, 54);
            this.Lbl_fare.Name = "Lbl_fare";
            this.Lbl_fare.Size = new System.Drawing.Size(69, 12);
            this.Lbl_fare.TabIndex = 29;
            this.Lbl_fare.Text = "fare(integer) :";
            // 
            // Lbl_orderID
            // 
            this.Lbl_orderID.AutoSize = true;
            this.Lbl_orderID.Location = new System.Drawing.Point(12, 26);
            this.Lbl_orderID.Name = "Lbl_orderID";
            this.Lbl_orderID.Size = new System.Drawing.Size(88, 12);
            this.Lbl_orderID.TabIndex = 28;
            this.Lbl_orderID.Text = "orderID(e.g. o1) :";
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_orders);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.Txt_deliverDate);
            this.Controls.Add(this.Txt_fare);
            this.Controls.Add(this.Txt_orderID);
            this.Controls.Add(this.Lbl_deliverDate);
            this.Controls.Add(this.Lbl_fare);
            this.Controls.Add(this.Lbl_orderID);
            this.Name = "orders";
            this.Text = "orders";
            this.Load += new System.EventHandler(this.orders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_condition;
        private System.Windows.Forms.ComboBox cbo_attribute;
        private System.Windows.Forms.Label Lbl_select_operation;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView DGV_orders;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox Txt_deliverDate;
        private System.Windows.Forms.TextBox Txt_fare;
        private System.Windows.Forms.TextBox Txt_orderID;
        private System.Windows.Forms.Label Lbl_deliverDate;
        private System.Windows.Forms.Label Lbl_fare;
        private System.Windows.Forms.Label Lbl_orderID;
    }
}