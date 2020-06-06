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
    public partial class customer : Form
    {
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";
        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM customer", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_customer.DataSource = ds.Tables[0];

            if (!cbo_attribute.Items.Contains("custID"))
                cbo_attribute.Items.Add("custID");
            if (!cbo_attribute.Items.Contains("custName"))
                cbo_attribute.Items.Add("custName");
            if (!cbo_attribute.Items.Contains("custPhone"))
                cbo_attribute.Items.Add("custPhone");
            if (!cbo_attribute.Items.Contains("custAddr"))
                cbo_attribute.Items.Add("custAddr");
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
                cmd.CommandText="INSERT INTO customer(custID,custName,custPhone,custAddr)VALUES(N'"+Txt_custID.Text.Replace("'","''")+"',N'"+
                    Txt_custName.Text.Replace("'", "''") + "',N'" +
                    Txt_custPhone.Text.Replace("'", "''") + "',N'" +
                    Txt_custAddr.Text.Replace("'", "''")+"')";
                cmd.ExecuteNonQuery();
                db.Close();
                customer_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                cmd.CommandText = "DELETE FROM customer WHERE custID=N'" + Txt_custID.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                customer_Load(sender, e);
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
                cmd.CommandText = "UPDATE customer SET custName=N'"+ Txt_custName.Text.Replace("'", "''") + "',"+ "custPhone=N'" + Txt_custPhone.Text.Replace("'", "''") + "',"+"custAddr=N'" + Txt_custAddr.Text.Replace("'", "''") + "'" + "WHERE custID=N'" + Txt_custID.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                customer_Load(sender, e);
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM customer WHERE " + cbo_attribute.Text + "=N'" + Txt_condition.Text.Replace("'", "''") + "'", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_customer.DataSource = ds.Tables[0];
        }
    }
}
