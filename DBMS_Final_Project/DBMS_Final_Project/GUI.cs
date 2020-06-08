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
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
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

        private void btn_IDUvender_Click(object sender, EventArgs e)
        {
            vender ven= new vender();
            ven.Show();
        }

        private void btn_IDUorder_Click(object sender, EventArgs e)
        {
            orders order = new orders();
            order.Show();
        }

        private void btn_IDUproduct_Click(object sender, EventArgs e)
        {
            product pd = new product();
            pd.Show();
        }

        private void btn_IDUpurchase_Click(object sender, EventArgs e)
        {
            purchase pc = new purchase();
            pc.Show();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string[] query = Txt_query.Text.Split(' ');
            if (query[0] == "INSERT" || query[0] == "DELETE" || query[0] == "UPDATE")
                exenonquery(sender,e,Txt_query.Text);

            else
                exequery(sender, e, Txt_query.Text);

        }
        private void exenonquery(object sender, EventArgs e,string op)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = op;
                cmd.ExecuteNonQuery();
                db.Close();

                //show在上方datagridview的處理
                string[] sentences = op.Split(' ');
                //通過對SQL指令的字串處理抓出到底要show哪個table
                string table = "";
                if (sentences[0] == "INSERT")
                {
                    //INSERT INTO 資料表名稱(欄位,欄位....)-->所以取第三個元素但是還要在處理
                    int position = sentences[2].IndexOf("(");
                    table = sentences[2].Substring(0, position);
                }
                else if (sentences[0] == "DELETE") 
                    table = sentences[2];// DELETE FROM 資料表名稱 -->所以取第三個元素

                else//sentences[0] == "UPDATE"   
                    table = sentences[1];//UPDATE 資料表名稱-->所以取第二個元素

                //通過switch來決定show出來對應之table
                switch (table)
                {
                        case "customer":
                            btn_customer_Click(sender, e);
                            break;

                        case "orders":
                            btn_order_Click(sender, e);
                            break;

                        case "vender":
                            btn_vender_Click(sender, e);
                            break;

                        case "employee":
                            btn_employee_Click(sender, e);
                            break;

                        case "purchase":
                            btn_purchase_Click(sender, e);
                            break;

                        case "product":
                            btn_product_Click(sender, e);
                            break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void exequery(object sender, EventArgs e, string op)
        {
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            SqlDataAdapter da = new SqlDataAdapter(op, db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_showTables.DataSource = ds.Tables[0];
            db.Close();
        }
    }
}
