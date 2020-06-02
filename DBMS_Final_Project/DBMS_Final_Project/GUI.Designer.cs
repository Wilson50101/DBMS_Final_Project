namespace DBMS_Final_Project
{
    partial class GUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database1DataSet = new DBMS_Final_Project.Database1DataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new DBMS_Final_Project.Database1DataSetTableAdapters.customerTableAdapter();
            this.DGV_showTables = new System.Windows.Forms.DataGridView();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_vender = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_selectTabletoshow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_showTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.database1DataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // DGV_showTables
            // 
            this.DGV_showTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_showTables.Location = new System.Drawing.Point(169, 12);
            this.DGV_showTables.Name = "DGV_showTables";
            this.DGV_showTables.RowTemplate.Height = 24;
            this.DGV_showTables.Size = new System.Drawing.Size(385, 130);
            this.DGV_showTables.TabIndex = 0;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.database1DataSet;
            // 
            // btn_customer
            // 
            this.btn_customer.Location = new System.Drawing.Point(3, 39);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(75, 23);
            this.btn_customer.TabIndex = 1;
            this.btn_customer.Text = "customer";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.Location = new System.Drawing.Point(88, 39);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(75, 23);
            this.btn_employee.TabIndex = 2;
            this.btn_employee.Text = "employee";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(3, 77);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 3;
            this.btn_order.Text = "order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(88, 77);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(75, 23);
            this.btn_product.TabIndex = 4;
            this.btn_product.Text = "product";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_vender
            // 
            this.btn_vender.Location = new System.Drawing.Point(3, 119);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(75, 23);
            this.btn_vender.TabIndex = 5;
            this.btn_vender.Text = "vender";
            this.btn_vender.UseVisualStyleBackColor = true;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(88, 119);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(75, 23);
            this.btn_purchase.TabIndex = 6;
            this.btn_purchase.Text = "purchase";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Lbl_selectTabletoshow);
            this.panel1.Controls.Add(this.btn_customer);
            this.panel1.Controls.Add(this.DGV_showTables);
            this.panel1.Controls.Add(this.btn_purchase);
            this.panel1.Controls.Add(this.btn_employee);
            this.panel1.Controls.Add(this.btn_vender);
            this.panel1.Controls.Add(this.btn_order);
            this.panel1.Controls.Add(this.btn_product);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 159);
            this.panel1.TabIndex = 7;
            // 
            // Lbl_selectTabletoshow
            // 
            this.Lbl_selectTabletoshow.AutoSize = true;
            this.Lbl_selectTabletoshow.Location = new System.Drawing.Point(31, 12);
            this.Lbl_selectTabletoshow.Name = "Lbl_selectTabletoshow";
            this.Lbl_selectTabletoshow.Size = new System.Drawing.Size(113, 12);
            this.Lbl_selectTabletoshow.TabIndex = 8;
            this.Lbl_selectTabletoshow.Text = "選擇欲呈現的資料表";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.panel1);
            this.Name = "GUI";
            this.Text = "DataBaseGUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_showTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Database1DataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridView DGV_showTables;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_selectTabletoshow;
    }
}

