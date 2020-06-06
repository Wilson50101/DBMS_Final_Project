namespace DBMS_Final_Project
{
    partial class customer
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
            this.Lbl_custID = new System.Windows.Forms.Label();
            this.Lbl_custName = new System.Windows.Forms.Label();
            this.Lbl_custPhone = new System.Windows.Forms.Label();
            this.Lbl_custAddr = new System.Windows.Forms.Label();
            this.Txt_custID = new System.Windows.Forms.TextBox();
            this.Txt_custName = new System.Windows.Forms.TextBox();
            this.Txt_custPhone = new System.Windows.Forms.TextBox();
            this.Txt_custAddr = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.DGV_customer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_custID
            // 
            this.Lbl_custID.AutoSize = true;
            this.Lbl_custID.Location = new System.Drawing.Point(12, 18);
            this.Lbl_custID.Name = "Lbl_custID";
            this.Lbl_custID.Size = new System.Drawing.Size(80, 12);
            this.Lbl_custID.TabIndex = 0;
            this.Lbl_custID.Text = "custID(e.g. c1) :";
            // 
            // Lbl_custName
            // 
            this.Lbl_custName.AutoSize = true;
            this.Lbl_custName.Location = new System.Drawing.Point(11, 46);
            this.Lbl_custName.Name = "Lbl_custName";
            this.Lbl_custName.Size = new System.Drawing.Size(132, 12);
            this.Lbl_custName.TabIndex = 1;
            this.Lbl_custName.Text = "custName(e.g. customer1) :";
            // 
            // Lbl_custPhone
            // 
            this.Lbl_custPhone.AutoSize = true;
            this.Lbl_custPhone.Location = new System.Drawing.Point(10, 74);
            this.Lbl_custPhone.Name = "Lbl_custPhone";
            this.Lbl_custPhone.Size = new System.Drawing.Size(133, 12);
            this.Lbl_custPhone.TabIndex = 2;
            this.Lbl_custPhone.Text = "custPhone(e.g. c1111111) :";
            // 
            // Lbl_custAddr
            // 
            this.Lbl_custAddr.AutoSize = true;
            this.Lbl_custAddr.Location = new System.Drawing.Point(11, 102);
            this.Lbl_custAddr.Name = "Lbl_custAddr";
            this.Lbl_custAddr.Size = new System.Drawing.Size(103, 12);
            this.Lbl_custAddr.TabIndex = 3;
            this.Lbl_custAddr.Text = "custAddr(e.g. cA1) : ";
            // 
            // Txt_custID
            // 
            this.Txt_custID.Location = new System.Drawing.Point(159, 15);
            this.Txt_custID.Name = "Txt_custID";
            this.Txt_custID.Size = new System.Drawing.Size(100, 22);
            this.Txt_custID.TabIndex = 4;
            // 
            // Txt_custName
            // 
            this.Txt_custName.Location = new System.Drawing.Point(159, 43);
            this.Txt_custName.Name = "Txt_custName";
            this.Txt_custName.Size = new System.Drawing.Size(100, 22);
            this.Txt_custName.TabIndex = 5;
            // 
            // Txt_custPhone
            // 
            this.Txt_custPhone.Location = new System.Drawing.Point(159, 71);
            this.Txt_custPhone.Name = "Txt_custPhone";
            this.Txt_custPhone.Size = new System.Drawing.Size(100, 22);
            this.Txt_custPhone.TabIndex = 6;
            // 
            // Txt_custAddr
            // 
            this.Txt_custAddr.Location = new System.Drawing.Point(159, 99);
            this.Txt_custAddr.Name = "Txt_custAddr";
            this.Txt_custAddr.Size = new System.Drawing.Size(100, 22);
            this.Txt_custAddr.TabIndex = 7;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(289, 15);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 8;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(289, 46);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(289, 75);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // DGV_customer
            // 
            this.DGV_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_customer.Location = new System.Drawing.Point(12, 132);
            this.DGV_customer.Name = "DGV_customer";
            this.DGV_customer.RowTemplate.Height = 24;
            this.DGV_customer.Size = new System.Drawing.Size(381, 150);
            this.DGV_customer.TabIndex = 11;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 294);
            this.Controls.Add(this.DGV_customer);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.Txt_custAddr);
            this.Controls.Add(this.Txt_custPhone);
            this.Controls.Add(this.Txt_custName);
            this.Controls.Add(this.Txt_custID);
            this.Controls.Add(this.Lbl_custAddr);
            this.Controls.Add(this.Lbl_custPhone);
            this.Controls.Add(this.Lbl_custName);
            this.Controls.Add(this.Lbl_custID);
            this.Name = "customer";
            this.Text = " ";
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_custID;
        private System.Windows.Forms.Label Lbl_custName;
        private System.Windows.Forms.Label Lbl_custPhone;
        private System.Windows.Forms.Label Lbl_custAddr;
        private System.Windows.Forms.TextBox Txt_custID;
        private System.Windows.Forms.TextBox Txt_custName;
        private System.Windows.Forms.TextBox Txt_custPhone;
        private System.Windows.Forms.TextBox Txt_custAddr;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView DGV_customer;
    }
}