namespace DBMS_Final_Project
{
    partial class product
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
            this.DGV_product = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.Txt_price = new System.Windows.Forms.TextBox();
            this.Txt_productName = new System.Windows.Forms.TextBox();
            this.Txt_productID = new System.Windows.Forms.TextBox();
            this.Lbl_price = new System.Windows.Forms.Label();
            this.Lbl_productName = new System.Windows.Forms.Label();
            this.Lbl_productID = new System.Windows.Forms.Label();
            this.Lbl_include = new System.Windows.Forms.Label();
            this.Lbl_Iquantity = new System.Windows.Forms.Label();
            this.pnl_include_realtion = new System.Windows.Forms.Panel();
            this.Txt_Iquantity = new System.Windows.Forms.TextBox();
            this.Txt_orderID = new System.Windows.Forms.TextBox();
            this.Lbl_Include_relation = new System.Windows.Forms.Label();
            this.pnl_provide_relation = new System.Windows.Forms.Panel();
            this.Txt_Pquantity = new System.Windows.Forms.TextBox();
            this.Txt_venderID = new System.Windows.Forms.TextBox();
            this.Lbl_provide_relation = new System.Windows.Forms.Label();
            this.Lbl_venderID = new System.Windows.Forms.Label();
            this.Lbl_Pquantity = new System.Windows.Forms.Label();
            this.Lbl_IDU = new System.Windows.Forms.Label();
            this.Pnl_IDU = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_product = new System.Windows.Forms.Label();
            this.Pnl_select = new System.Windows.Forms.Panel();
            this.Lbl_select = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_product)).BeginInit();
            this.pnl_include_realtion.SuspendLayout();
            this.pnl_provide_relation.SuspendLayout();
            this.Pnl_IDU.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Pnl_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbo_attribute);
            this.panel1.Controls.Add(this.Txt_condition);
            this.panel1.Controls.Add(this.Lbl_select_operation);
            this.panel1.Controls.Add(this.btn_select);
            this.panel1.Location = new System.Drawing.Point(15, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 52);
            this.panel1.TabIndex = 51;
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
            this.Txt_condition.Text = "=,>,<,>=,<=要打在這";
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
            // DGV_product
            // 
            this.DGV_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_product.Location = new System.Drawing.Point(445, 165);
            this.DGV_product.Name = "DGV_product";
            this.DGV_product.RowTemplate.Height = 24;
            this.DGV_product.Size = new System.Drawing.Size(470, 277);
            this.DGV_product.TabIndex = 50;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(324, 149);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 49;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(324, 104);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 48;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(324, 59);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 47;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // Txt_price
            // 
            this.Txt_price.Location = new System.Drawing.Point(174, 97);
            this.Txt_price.Name = "Txt_price";
            this.Txt_price.Size = new System.Drawing.Size(81, 22);
            this.Txt_price.TabIndex = 46;
            // 
            // Txt_productName
            // 
            this.Txt_productName.Location = new System.Drawing.Point(174, 69);
            this.Txt_productName.Name = "Txt_productName";
            this.Txt_productName.Size = new System.Drawing.Size(81, 22);
            this.Txt_productName.TabIndex = 45;
            // 
            // Txt_productID
            // 
            this.Txt_productID.Location = new System.Drawing.Point(174, 41);
            this.Txt_productID.Name = "Txt_productID";
            this.Txt_productID.Size = new System.Drawing.Size(81, 22);
            this.Txt_productID.TabIndex = 44;
            // 
            // Lbl_price
            // 
            this.Lbl_price.AutoSize = true;
            this.Lbl_price.Location = new System.Drawing.Point(5, 100);
            this.Lbl_price.Name = "Lbl_price";
            this.Lbl_price.Size = new System.Drawing.Size(74, 12);
            this.Lbl_price.TabIndex = 43;
            this.Lbl_price.Text = "price(integer) :";
            this.Lbl_price.Click += new System.EventHandler(this.Lbl_price_Click);
            // 
            // Lbl_productName
            // 
            this.Lbl_productName.AutoSize = true;
            this.Lbl_productName.Location = new System.Drawing.Point(5, 72);
            this.Lbl_productName.Name = "Lbl_productName";
            this.Lbl_productName.Size = new System.Drawing.Size(144, 12);
            this.Lbl_productName.TabIndex = 42;
            this.Lbl_productName.Text = "productName(e.g. product1) :";
            // 
            // Lbl_productID
            // 
            this.Lbl_productID.AutoSize = true;
            this.Lbl_productID.Location = new System.Drawing.Point(5, 44);
            this.Lbl_productID.Name = "Lbl_productID";
            this.Lbl_productID.Size = new System.Drawing.Size(99, 12);
            this.Lbl_productID.TabIndex = 41;
            this.Lbl_productID.Text = "productID(e.g. p1) :";
            // 
            // Lbl_include
            // 
            this.Lbl_include.AutoSize = true;
            this.Lbl_include.Location = new System.Drawing.Point(5, 47);
            this.Lbl_include.Name = "Lbl_include";
            this.Lbl_include.Size = new System.Drawing.Size(245, 12);
            this.Lbl_include.TabIndex = 52;
            this.Lbl_include.Text = "是否被包含在哪個訂單 ?  其orderID ? (e.g. o1) :";
            this.Lbl_include.Click += new System.EventHandler(this.Lbl_include_Click);
            // 
            // Lbl_Iquantity
            // 
            this.Lbl_Iquantity.AutoSize = true;
            this.Lbl_Iquantity.Location = new System.Drawing.Point(5, 74);
            this.Lbl_Iquantity.Name = "Lbl_Iquantity";
            this.Lbl_Iquantity.Size = new System.Drawing.Size(273, 12);
            this.Lbl_Iquantity.TabIndex = 53;
            this.Lbl_Iquantity.Text = "該order包含多少數量的此物品 = Iquantity ? (integer) :";
            // 
            // pnl_include_realtion
            // 
            this.pnl_include_realtion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_include_realtion.Controls.Add(this.Txt_Iquantity);
            this.pnl_include_realtion.Controls.Add(this.Txt_orderID);
            this.pnl_include_realtion.Controls.Add(this.Lbl_Include_relation);
            this.pnl_include_realtion.Controls.Add(this.Lbl_include);
            this.pnl_include_realtion.Controls.Add(this.Lbl_Iquantity);
            this.pnl_include_realtion.Location = new System.Drawing.Point(6, 197);
            this.pnl_include_realtion.Name = "pnl_include_realtion";
            this.pnl_include_realtion.Size = new System.Drawing.Size(393, 103);
            this.pnl_include_realtion.TabIndex = 56;
            // 
            // Txt_Iquantity
            // 
            this.Txt_Iquantity.Location = new System.Drawing.Point(297, 71);
            this.Txt_Iquantity.Name = "Txt_Iquantity";
            this.Txt_Iquantity.Size = new System.Drawing.Size(79, 22);
            this.Txt_Iquantity.TabIndex = 57;
            // 
            // Txt_orderID
            // 
            this.Txt_orderID.Location = new System.Drawing.Point(297, 43);
            this.Txt_orderID.Name = "Txt_orderID";
            this.Txt_orderID.Size = new System.Drawing.Size(79, 22);
            this.Txt_orderID.TabIndex = 57;
            // 
            // Lbl_Include_relation
            // 
            this.Lbl_Include_relation.AutoSize = true;
            this.Lbl_Include_relation.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Include_relation.Location = new System.Drawing.Point(3, 2);
            this.Lbl_Include_relation.Name = "Lbl_Include_relation";
            this.Lbl_Include_relation.Size = new System.Drawing.Size(155, 24);
            this.Lbl_Include_relation.TabIndex = 54;
            this.Lbl_Include_relation.Text = "Include Relation";
            // 
            // pnl_provide_relation
            // 
            this.pnl_provide_relation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_provide_relation.Controls.Add(this.Txt_Pquantity);
            this.pnl_provide_relation.Controls.Add(this.Txt_venderID);
            this.pnl_provide_relation.Controls.Add(this.Lbl_provide_relation);
            this.pnl_provide_relation.Controls.Add(this.Lbl_venderID);
            this.pnl_provide_relation.Controls.Add(this.Lbl_Pquantity);
            this.pnl_provide_relation.Location = new System.Drawing.Point(6, 306);
            this.pnl_provide_relation.Name = "pnl_provide_relation";
            this.pnl_provide_relation.Size = new System.Drawing.Size(393, 103);
            this.pnl_provide_relation.TabIndex = 58;
            // 
            // Txt_Pquantity
            // 
            this.Txt_Pquantity.Location = new System.Drawing.Point(297, 71);
            this.Txt_Pquantity.Name = "Txt_Pquantity";
            this.Txt_Pquantity.Size = new System.Drawing.Size(79, 22);
            this.Txt_Pquantity.TabIndex = 57;
            // 
            // Txt_venderID
            // 
            this.Txt_venderID.Location = new System.Drawing.Point(297, 43);
            this.Txt_venderID.Name = "Txt_venderID";
            this.Txt_venderID.Size = new System.Drawing.Size(79, 22);
            this.Txt_venderID.TabIndex = 57;
            // 
            // Lbl_provide_relation
            // 
            this.Lbl_provide_relation.AutoSize = true;
            this.Lbl_provide_relation.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_provide_relation.Location = new System.Drawing.Point(3, 2);
            this.Lbl_provide_relation.Name = "Lbl_provide_relation";
            this.Lbl_provide_relation.Size = new System.Drawing.Size(160, 24);
            this.Lbl_provide_relation.TabIndex = 54;
            this.Lbl_provide_relation.Text = "Provide Relation";
            // 
            // Lbl_venderID
            // 
            this.Lbl_venderID.AutoSize = true;
            this.Lbl_venderID.Location = new System.Drawing.Point(5, 47);
            this.Lbl_venderID.Name = "Lbl_venderID";
            this.Lbl_venderID.Size = new System.Drawing.Size(154, 12);
            this.Lbl_venderID.TabIndex = 52;
            this.Lbl_venderID.Text = "供應商之venderID ? (e.g. v1) :";
            // 
            // Lbl_Pquantity
            // 
            this.Lbl_Pquantity.AutoSize = true;
            this.Lbl_Pquantity.Location = new System.Drawing.Point(5, 74);
            this.Lbl_Pquantity.Name = "Lbl_Pquantity";
            this.Lbl_Pquantity.Size = new System.Drawing.Size(191, 12);
            this.Lbl_Pquantity.TabIndex = 53;
            this.Lbl_Pquantity.Text = "供應商提供之數量Pquantity(integer) :";
            // 
            // Lbl_IDU
            // 
            this.Lbl_IDU.AutoSize = true;
            this.Lbl_IDU.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDU.Location = new System.Drawing.Point(8, 16);
            this.Lbl_IDU.Name = "Lbl_IDU";
            this.Lbl_IDU.Size = new System.Drawing.Size(215, 24);
            this.Lbl_IDU.TabIndex = 59;
            this.Lbl_IDU.Text = "Insert / Delete / Update";
            // 
            // Pnl_IDU
            // 
            this.Pnl_IDU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pnl_IDU.Controls.Add(this.panel2);
            this.Pnl_IDU.Controls.Add(this.Lbl_IDU);
            this.Pnl_IDU.Controls.Add(this.pnl_provide_relation);
            this.Pnl_IDU.Controls.Add(this.btn_update);
            this.Pnl_IDU.Controls.Add(this.pnl_include_realtion);
            this.Pnl_IDU.Controls.Add(this.btn_delete);
            this.Pnl_IDU.Controls.Add(this.btn_Insert);
            this.Pnl_IDU.Location = new System.Drawing.Point(12, 31);
            this.Pnl_IDU.Name = "Pnl_IDU";
            this.Pnl_IDU.Size = new System.Drawing.Size(410, 416);
            this.Pnl_IDU.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Lbl_product);
            this.panel2.Controls.Add(this.Lbl_productID);
            this.panel2.Controls.Add(this.Lbl_productName);
            this.panel2.Controls.Add(this.Lbl_price);
            this.panel2.Controls.Add(this.Txt_productID);
            this.panel2.Controls.Add(this.Txt_productName);
            this.panel2.Controls.Add(this.Txt_price);
            this.panel2.Location = new System.Drawing.Point(6, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 126);
            this.panel2.TabIndex = 61;
            // 
            // Lbl_product
            // 
            this.Lbl_product.AutoSize = true;
            this.Lbl_product.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_product.Location = new System.Drawing.Point(3, 10);
            this.Lbl_product.Name = "Lbl_product";
            this.Lbl_product.Size = new System.Drawing.Size(141, 24);
            this.Lbl_product.TabIndex = 60;
            this.Lbl_product.Text = "Basic attribute";
            // 
            // Pnl_select
            // 
            this.Pnl_select.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pnl_select.Controls.Add(this.Lbl_select);
            this.Pnl_select.Controls.Add(this.panel1);
            this.Pnl_select.Location = new System.Drawing.Point(445, 31);
            this.Pnl_select.Name = "Pnl_select";
            this.Pnl_select.Size = new System.Drawing.Size(470, 116);
            this.Pnl_select.TabIndex = 61;
            // 
            // Lbl_select
            // 
            this.Lbl_select.AutoSize = true;
            this.Lbl_select.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_select.Location = new System.Drawing.Point(11, 7);
            this.Lbl_select.Name = "Lbl_select";
            this.Lbl_select.Size = new System.Drawing.Size(340, 24);
            this.Lbl_select.TabIndex = 60;
            this.Lbl_select.Text = "SELECT FROM WHERE Operation";
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 472);
            this.Controls.Add(this.Pnl_select);
            this.Controls.Add(this.Pnl_IDU);
            this.Controls.Add(this.DGV_product);
            this.Name = "product";
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_product)).EndInit();
            this.pnl_include_realtion.ResumeLayout(false);
            this.pnl_include_realtion.PerformLayout();
            this.pnl_provide_relation.ResumeLayout(false);
            this.pnl_provide_relation.PerformLayout();
            this.Pnl_IDU.ResumeLayout(false);
            this.Pnl_IDU.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Pnl_select.ResumeLayout(false);
            this.Pnl_select.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_attribute;
        private System.Windows.Forms.TextBox Txt_condition;
        private System.Windows.Forms.Label Lbl_select_operation;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView DGV_product;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox Txt_price;
        private System.Windows.Forms.TextBox Txt_productName;
        private System.Windows.Forms.TextBox Txt_productID;
        private System.Windows.Forms.Label Lbl_price;
        private System.Windows.Forms.Label Lbl_productName;
        private System.Windows.Forms.Label Lbl_productID;
        private System.Windows.Forms.Label Lbl_include;
        private System.Windows.Forms.Label Lbl_Iquantity;
        private System.Windows.Forms.Panel pnl_include_realtion;
        private System.Windows.Forms.Label Lbl_Include_relation;
        private System.Windows.Forms.TextBox Txt_Iquantity;
        private System.Windows.Forms.TextBox Txt_orderID;
        private System.Windows.Forms.Panel pnl_provide_relation;
        private System.Windows.Forms.TextBox Txt_Pquantity;
        private System.Windows.Forms.TextBox Txt_venderID;
        private System.Windows.Forms.Label Lbl_provide_relation;
        private System.Windows.Forms.Label Lbl_venderID;
        private System.Windows.Forms.Label Lbl_Pquantity;
        private System.Windows.Forms.Label Lbl_IDU;
        private System.Windows.Forms.Panel Pnl_IDU;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_product;
        private System.Windows.Forms.Panel Pnl_select;
        private System.Windows.Forms.Label Lbl_select;
    }
}