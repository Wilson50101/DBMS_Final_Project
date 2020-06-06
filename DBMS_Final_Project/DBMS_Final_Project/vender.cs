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
    public partial class vender : Form
    {
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";

        public vender()
        {
            InitializeComponent();
        }

        private void vender_Load(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vender", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_vender.DataSource = ds.Tables[0];

            if (!cbo_attribute.Items.Contains("venderID"))
                cbo_attribute.Items.Add("venderID");
            if (!cbo_attribute.Items.Contains("venderName"))
                cbo_attribute.Items.Add("venderName");
            if (!cbo_attribute.Items.Contains("venderPhone"))
                cbo_attribute.Items.Add("venderPhone");
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
                cmd.CommandText = "INSERT INTO vender(venderID,venderName,venderPhone)VALUES(N'" + Txt_venderID.Text.Replace("'", "''") + "',N'" +
                    Txt_venderName.Text.Replace("'", "''") + "',N'" +
                    Txt_venderPhone.Text.Replace("'", "''") + "')";
                cmd.ExecuteNonQuery();
                db.Close();
                vender_Load(sender, e);
            }
            catch (Exception ex)
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
                cmd.CommandText = "DELETE FROM vender WHERE venderID=N'" + Txt_venderID.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                vender_Load(sender, e);
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
                cmd.CommandText = "UPDATE vender SET venderName=N'" + Txt_venderName.Text.Replace("'", "''") + "'," + "venderPhone=N'" + Txt_venderPhone.Text.Replace("'", "''") + "'" + "WHERE venderID=N'" + Txt_venderID.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                vender_Load(sender, e);
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vender WHERE " + cbo_attribute.Text + "=N'" + Txt_condition.Text.Replace("'", "''") + "'", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_vender.DataSource = ds.Tables[0];
        }
    }
}
