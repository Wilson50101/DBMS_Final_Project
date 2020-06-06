using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DBMS_Final_Project
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            SqlDataAdapter ap = new SqlDataAdapter("Select * FROM employee", db);
            DataSet ds = new DataSet();
            ap.Fill(ds, "employee");
            DGV_showTables.DataSource = ds.Tables["employee"];
            db.Close();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            SqlDataAdapter ap = new SqlDataAdapter("Select * FROM product", db);
            DataSet ds = new DataSet();
            ap.Fill(ds, "product");
            
            //加這一行是為了防止從order或是vender跳回來product資料表時第一行顯示的不是productID的錯誤
            DGV_showTables.DataSource = null;
            DGV_showTables.DataSource = ds.Tables["product"];
            db.Close();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
           
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            SqlDataAdapter ap = new SqlDataAdapter("Select * FROM customer", db);
            DataSet ds = new DataSet();
            ap.Fill(ds, "customer");
            DGV_showTables.DataSource = ds.Tables["customer"];
            db.Close();
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            SqlDataAdapter ap = new SqlDataAdapter("Select * FROM vender", db);
            DataSet ds = new DataSet();
            ap.Fill(ds, "vender");
            DGV_showTables.DataSource = ds.Tables["vender"];
            db.Close();
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            SqlDataAdapter ap = new SqlDataAdapter("Select * FROM purchase", db);
            DataSet ds = new DataSet();
            ap.Fill(ds, "purchase");
            DGV_showTables.DataSource = ds.Tables["purchase"];
            db.Close();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            SqlDataAdapter ap = new SqlDataAdapter("Select * FROM orders", db);
            DataSet ds = new DataSet();
            ap.Fill(ds, "orders");
            DGV_showTables.DataSource = ds.Tables["orders"];
            db.Close();
        }

        private void btn_IDUcustomer_Click(object sender, EventArgs e)
        {
            customer cust = new customer();
            cust.Show();
        }

        private void btn_IDUemployee_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.Show();
        }
    }
}
