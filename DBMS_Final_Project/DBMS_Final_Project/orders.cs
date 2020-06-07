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

    public partial class orders : Form
    {
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";

        public orders()
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
                cmd.CommandText = "INSERT INTO orders(orderID,fare,deliverDate)VALUES(N'" + Txt_orderID.Text.Replace("'", "''") + "'," +
                    int.Parse(Txt_fare.Text) + ",N'" +
                    Txt_deliverDate.Text.Replace("'", "''") + "')";
                cmd.ExecuteNonQuery();
                db.Close();
                orders_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void orders_Load(object sender, EventArgs e)
        {

            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM orders", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_orders.DataSource = ds.Tables[0];

            if (!cbo_attribute.Items.Contains("orderID"))
                cbo_attribute.Items.Add("orderID");
            if (!cbo_attribute.Items.Contains("fare"))
                cbo_attribute.Items.Add("fare");
            if (!cbo_attribute.Items.Contains("deliverDate"))
                cbo_attribute.Items.Add("deliverDate");
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
                cmd.CommandText = "DELETE FROM orders WHERE orderID=N'" + Txt_orderID.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                orders_Load(sender, e);
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
                cmd.CommandText = "UPDATE orders SET fare=" + int.Parse(Txt_fare.Text)+ ",deliverDate=N'" + Txt_deliverDate.Text.Replace("'", "''") + "'" + "WHERE orderID=N'" + Txt_orderID.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                orders_Load(sender, e);
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

            string operation = "SELECT * FROM orders WHERE " + cbo_attribute.Text;
            if (cbo_attribute.Text == "fare")
                operation += Txt_condition.Text;
            else
                operation += "=N'" + Txt_condition.Text.Substring(1).Replace("'", "''") + "'";

            SqlDataAdapter da = new SqlDataAdapter(operation, db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_orders.DataSource = ds.Tables[0];
            Txt_condition.Text = "= 還是 >,<,>=,<= 要打在這";
        }
    }
}
