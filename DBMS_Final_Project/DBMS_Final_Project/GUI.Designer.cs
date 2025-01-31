﻿namespace DBMS_Final_Project
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
            this.btn_IDUcustomer = new System.Windows.Forms.Button();
            this.btn_IDUorder = new System.Windows.Forms.Button();
            this.btn_IDUvender = new System.Windows.Forms.Button();
            this.btn_IDUemployee = new System.Windows.Forms.Button();
            this.btn_IDUproduct = new System.Windows.Forms.Button();
            this.btn_IDUpurchase = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_BtnMode = new System.Windows.Forms.Label();
            this.pnl_query_mode = new System.Windows.Forms.Panel();
            this.Lbl_query_mode = new System.Windows.Forms.Label();
            this.Txt_query = new System.Windows.Forms.TextBox();
            this.btn_query = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_showTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_query_mode.SuspendLayout();
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
            this.btn_order.Text = "orders";
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
            this.Lbl_selectTabletoshow.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_selectTabletoshow.Location = new System.Drawing.Point(28, 8);
            this.Lbl_selectTabletoshow.Name = "Lbl_selectTabletoshow";
            this.Lbl_selectTabletoshow.Size = new System.Drawing.Size(127, 28);
            this.Lbl_selectTabletoshow.TabIndex = 8;
            this.Lbl_selectTabletoshow.Text = "Show Table";
            // 
            // btn_IDUcustomer
            // 
            this.btn_IDUcustomer.Location = new System.Drawing.Point(17, 54);
            this.btn_IDUcustomer.Name = "btn_IDUcustomer";
            this.btn_IDUcustomer.Size = new System.Drawing.Size(75, 23);
            this.btn_IDUcustomer.TabIndex = 9;
            this.btn_IDUcustomer.Text = "customer";
            this.btn_IDUcustomer.UseVisualStyleBackColor = true;
            this.btn_IDUcustomer.Click += new System.EventHandler(this.btn_IDUcustomer_Click);
            // 
            // btn_IDUorder
            // 
            this.btn_IDUorder.Location = new System.Drawing.Point(17, 83);
            this.btn_IDUorder.Name = "btn_IDUorder";
            this.btn_IDUorder.Size = new System.Drawing.Size(75, 23);
            this.btn_IDUorder.TabIndex = 10;
            this.btn_IDUorder.Text = "orders";
            this.btn_IDUorder.UseVisualStyleBackColor = true;
            this.btn_IDUorder.Click += new System.EventHandler(this.btn_IDUorder_Click);
            // 
            // btn_IDUvender
            // 
            this.btn_IDUvender.Location = new System.Drawing.Point(17, 112);
            this.btn_IDUvender.Name = "btn_IDUvender";
            this.btn_IDUvender.Size = new System.Drawing.Size(75, 23);
            this.btn_IDUvender.TabIndex = 11;
            this.btn_IDUvender.Text = "vender";
            this.btn_IDUvender.UseVisualStyleBackColor = true;
            this.btn_IDUvender.Click += new System.EventHandler(this.btn_IDUvender_Click);
            // 
            // btn_IDUemployee
            // 
            this.btn_IDUemployee.Location = new System.Drawing.Point(108, 54);
            this.btn_IDUemployee.Name = "btn_IDUemployee";
            this.btn_IDUemployee.Size = new System.Drawing.Size(75, 23);
            this.btn_IDUemployee.TabIndex = 12;
            this.btn_IDUemployee.Text = "employee";
            this.btn_IDUemployee.UseVisualStyleBackColor = true;
            this.btn_IDUemployee.Click += new System.EventHandler(this.btn_IDUemployee_Click);
            // 
            // btn_IDUproduct
            // 
            this.btn_IDUproduct.Location = new System.Drawing.Point(108, 83);
            this.btn_IDUproduct.Name = "btn_IDUproduct";
            this.btn_IDUproduct.Size = new System.Drawing.Size(75, 23);
            this.btn_IDUproduct.TabIndex = 13;
            this.btn_IDUproduct.Text = "product";
            this.btn_IDUproduct.UseVisualStyleBackColor = true;
            this.btn_IDUproduct.Click += new System.EventHandler(this.btn_IDUproduct_Click);
            // 
            // btn_IDUpurchase
            // 
            this.btn_IDUpurchase.Location = new System.Drawing.Point(108, 112);
            this.btn_IDUpurchase.Name = "btn_IDUpurchase";
            this.btn_IDUpurchase.Size = new System.Drawing.Size(75, 23);
            this.btn_IDUpurchase.TabIndex = 14;
            this.btn_IDUpurchase.Text = "purchase";
            this.btn_IDUpurchase.UseVisualStyleBackColor = true;
            this.btn_IDUpurchase.Click += new System.EventHandler(this.btn_IDUpurchase_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Lbl_BtnMode);
            this.panel3.Controls.Add(this.btn_IDUemployee);
            this.panel3.Controls.Add(this.btn_IDUpurchase);
            this.panel3.Controls.Add(this.btn_IDUcustomer);
            this.panel3.Controls.Add(this.btn_IDUvender);
            this.panel3.Controls.Add(this.btn_IDUproduct);
            this.panel3.Controls.Add(this.btn_IDUorder);
            this.panel3.Location = new System.Drawing.Point(12, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 147);
            this.panel3.TabIndex = 15;
            // 
            // Lbl_BtnMode
            // 
            this.Lbl_BtnMode.AutoSize = true;
            this.Lbl_BtnMode.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BtnMode.Location = new System.Drawing.Point(28, 14);
            this.Lbl_BtnMode.Name = "Lbl_BtnMode";
            this.Lbl_BtnMode.Size = new System.Drawing.Size(142, 28);
            this.Lbl_BtnMode.TabIndex = 15;
            this.Lbl_BtnMode.Text = "Button Mode";
            // 
            // pnl_query_mode
            // 
            this.pnl_query_mode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_query_mode.Controls.Add(this.btn_query);
            this.pnl_query_mode.Controls.Add(this.Txt_query);
            this.pnl_query_mode.Controls.Add(this.Lbl_query_mode);
            this.pnl_query_mode.Location = new System.Drawing.Point(219, 177);
            this.pnl_query_mode.Name = "pnl_query_mode";
            this.pnl_query_mode.Size = new System.Drawing.Size(362, 147);
            this.pnl_query_mode.TabIndex = 16;
            // 
            // Lbl_query_mode
            // 
            this.Lbl_query_mode.AutoSize = true;
            this.Lbl_query_mode.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_query_mode.Location = new System.Drawing.Point(14, 14);
            this.Lbl_query_mode.Name = "Lbl_query_mode";
            this.Lbl_query_mode.Size = new System.Drawing.Size(135, 28);
            this.Lbl_query_mode.TabIndex = 15;
            this.Lbl_query_mode.Text = "Query Mode";
            // 
            // Txt_query
            // 
            this.Txt_query.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_query.Location = new System.Drawing.Point(19, 54);
            this.Txt_query.Name = "Txt_query";
            this.Txt_query.Size = new System.Drawing.Size(328, 22);
            this.Txt_query.TabIndex = 28;
            this.Txt_query.Text = "請於此輸入SQL指令,結果會顯示於上方DataGridView";
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(19, 83);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 16;
            this.btn_query.Text = "query";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 342);
            this.Controls.Add(this.pnl_query_mode);
            this.Controls.Add(this.panel3);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_query_mode.ResumeLayout(false);
            this.pnl_query_mode.PerformLayout();
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
        private System.Windows.Forms.Button btn_IDUcustomer;
        private System.Windows.Forms.Button btn_IDUorder;
        private System.Windows.Forms.Button btn_IDUvender;
        private System.Windows.Forms.Button btn_IDUemployee;
        private System.Windows.Forms.Button btn_IDUproduct;
        private System.Windows.Forms.Button btn_IDUpurchase;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_BtnMode;
        private System.Windows.Forms.Panel pnl_query_mode;
        private System.Windows.Forms.Label Lbl_query_mode;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.TextBox Txt_query;
    }
}

