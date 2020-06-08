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
    public partial class purchase : Form
    {
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";

        public purchase()
        {
            InitializeComponent();
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
                cmd.CommandText = "DELETE FROM purchase WHERE custID=N'" + Txt_custID.Text.Replace("'", "''") + "'AND orderID=N'"+ Txt_orderID.Text.Replace("'", "''")+"'";
                cmd.ExecuteNonQuery();
                db.Close();
                purchase_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void purchase_Load(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM purchase", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_orders.DataSource = ds.Tables[0];

            if (!cbo_attribute.Items.Contains("custID"))
                cbo_attribute.Items.Add("custID");
            if (!cbo_attribute.Items.Contains("EmpID"))
                cbo_attribute.Items.Add("EmpID");
            if (!cbo_attribute.Items.Contains("orderID"))
                cbo_attribute.Items.Add("orderID");
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
                cmd.CommandText = "INSERT INTO purchase(custID,EmpID,orderID)VALUES(" +
                    "N'" + Txt_custID.Text.Replace("'", "''") + "'," +
                    "N'" + Txt_EmpID.Text.Replace("'", "''") + "'," +
                    "N'" + Txt_orderID.Text.Replace("'", "''") + "')";
                cmd.ExecuteNonQuery();
                db.Close();
                purchase_Load(sender, e);
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
                cmd.CommandText = "UPDATE purchase SET EmpID=" +
                    "N'" + Txt_EmpID.Text.Replace("'", "''") +  "' WHERE custID="+
                    "N'" + Txt_custID.Text.Replace("'", "''")+"'AND orderID=" +
                    "N'" + Txt_orderID.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                purchase_Load(sender, e);
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

            string operation = "SELECT * FROM purchase WHERE " + cbo_attribute.Text + "=N'" + Txt_condition.Text+"'";

            SqlDataAdapter da = new SqlDataAdapter(operation, db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_orders.DataSource = ds.Tables[0];
        }

        
    }
}
