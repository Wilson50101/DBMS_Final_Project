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
    public partial class product : Form
    {
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";

        public product()
        {
            InitializeComponent();
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "INSERT INTO product(productID,productName,price,orderID,Iquantity,venderID,Pquantity)VALUES(N'" +
                    Txt_productID.Text.Replace("'", "''") + "',N'" +
                    Txt_productName.Text.Replace("'", "''") + "'," +
                    int.Parse(Txt_price.Text)+",";
                
                //防呆:當TextBox沒有輸入字串視為INSERT 該欄位的VALUES=NULL
                if (Txt_orderID.Text == "")
                    cmd.CommandText += "NULL,";
                else
                    cmd.CommandText += "N'" + Txt_orderID.Text.Replace("'", "''") + "',";

                //防呆:當TextBox沒有輸入字串視為INSERT 該欄位的VALUES=NULL
                if (Txt_Iquantity.Text == "")
                    cmd.CommandText += "NULL,";
                else
                    cmd.CommandText += int.Parse(Txt_Iquantity.Text) + ",";

                //防呆:當TextBox沒有輸入字串視為INSERT 該欄位的VALUES=NULL
                if (Txt_venderID.Text == "")
                    cmd.CommandText += "NULL,";
                else
                    cmd.CommandText += "N'" + Txt_venderID.Text.Replace("'", "''") + "',";

                //防呆:當TextBox沒有輸入字串視為INSERT 該欄位的VALUES=NULL
                if (Txt_Pquantity.Text == "")
                    cmd.CommandText += "NULL)";
                else
                    cmd.CommandText += int.Parse(Txt_Pquantity.Text) + ")";

                cmd.ExecuteNonQuery();
                db.Close();
                product_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void product_Load(object sender, EventArgs e)
        {

            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM product", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_product.DataSource = ds.Tables[0];

            if (!cbo_attribute.Items.Contains("productID"))
                cbo_attribute.Items.Add("productID");
            if (!cbo_attribute.Items.Contains("productName"))
                cbo_attribute.Items.Add("productName");
            if (!cbo_attribute.Items.Contains("price"))
                cbo_attribute.Items.Add("price");
            if (!cbo_attribute.Items.Contains("orderID"))
                cbo_attribute.Items.Add("orderID");
            if (!cbo_attribute.Items.Contains("Iquantity"))
                cbo_attribute.Items.Add("Iquantity");
            if (!cbo_attribute.Items.Contains("venderID"))
                cbo_attribute.Items.Add("venderID");
            if (!cbo_attribute.Items.Contains("Pquantity"))
                cbo_attribute.Items.Add("Pquantity");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "DELETE FROM product WHERE productID=N'" + Txt_productID.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                product_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "UPDATE product SET " +
                    "productName=N'" + Txt_productName.Text.Replace("'", "''") + "'," +
                    "price=" + int.Parse(Txt_price.Text) + ",";

                cmd.CommandText += "orderID=";
                //防呆:當TextBox沒有輸入字串視為INSERT 該欄位的VALUES=NULL
                if (Txt_orderID.Text == "")
                    cmd.CommandText += "NULL,";
                else
                    cmd.CommandText += "N'" + Txt_orderID.Text.Replace("'", "''") + "',";

                cmd.CommandText += "Iquantity=";
                //防呆:當TextBox沒有輸入字串視為INSERT 該欄位的VALUES=NULL
                if (Txt_Iquantity.Text == "")
                    cmd.CommandText += "NULL,";
                else
                    cmd.CommandText += int.Parse(Txt_Iquantity.Text) + ",";

                cmd.CommandText += "venderID=";
                //防呆:當TextBox沒有輸入字串視為INSERT 該欄位的VALUES=NULL
                if (Txt_venderID.Text == "")
                    cmd.CommandText += "NULL,";
                else
                    cmd.CommandText += "N'" + Txt_venderID.Text.Replace("'", "''") + "',";

                cmd.CommandText += "Pquantity=";
                //防呆:當TextBox沒有輸入字串視為INSERT 該欄位的VALUES=NULL
                if (Txt_Pquantity.Text == "")
                    cmd.CommandText += "NULL";
                else
                    cmd.CommandText += int.Parse(Txt_Pquantity.Text);

                cmd.CommandText += " WHERE productID=N'" + Txt_productID.Text.Replace("'", "''") + "'";

                cmd.ExecuteNonQuery();
                db.Close();
                product_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;

            string operation = "SELECT * FROM product WHERE " + cbo_attribute.Text;
            switch (cbo_attribute.Text)
            {
                case "productID":
                    operation += "=N'" + Txt_condition.Text.Substring(1).Replace("'", "''") + "'";
                    break;
                case "productName":
                    operation += "=N'" + Txt_condition.Text.Substring(1).Replace("'", "''") + "'";
                    break;
                case "price":
                    operation += Txt_condition.Text;
                    break;
                case "orderID":
                    operation += "=N'" + Txt_condition.Text.Substring(1).Replace("'", "''") + "'";
                    break;
                case "Iquantity":
                    operation += Txt_condition.Text;
                    break;
                case "venderID":
                    operation += "=N'" + Txt_condition.Text.Substring(1).Replace("'", "''") + "'";
                    break;
                case "Pquantity":
                    operation += Txt_condition.Text;
                    break;
            }
            SqlDataAdapter da = new SqlDataAdapter(operation, db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_product.DataSource = ds.Tables[0];
            Txt_condition.Text = "=,>,<,>=,<= 要打在這";
        }
    }
}
