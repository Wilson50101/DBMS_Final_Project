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
    public partial class employee : Form
    {
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";
        public employee()
        {
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM employee", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_employee.DataSource = ds.Tables[0];

            if(!cbo_attribute.Items.Contains("EmpID"))
                cbo_attribute.Items.Add("EmpID");
            if (!cbo_attribute.Items.Contains("EmpName"))
                cbo_attribute.Items.Add("EmpName");
            if (!cbo_attribute.Items.Contains("EmpPhone"))
                cbo_attribute.Items.Add("EmpPhone");
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
                cmd.CommandText = "INSERT INTO employee(EmpID,EmpName,EmpPhone)VALUES(N'" + Txt_EmpID.Text.Replace("'", "''") + "',N'" +
                    Txt_EmpName.Text.Replace("'", "''") + "',N'" +
                    Txt_EmpPhone.Text.Replace("'", "''")+"')";
                cmd.ExecuteNonQuery();
                db.Close();
                employee_Load(sender, e);
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
                cmd.CommandText = "DELETE FROM employee WHERE EmpID=N'" + Txt_EmpID.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                employee_Load(sender, e);
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
                cmd.CommandText = "UPDATE employee SET EmpName=N'" + Txt_EmpName.Text.Replace("'", "''") + "'," + "EmpPhone=N'" + Txt_EmpPhone.Text.Replace("'", "''") +"'" + "WHERE EmpID=N'" + Txt_EmpID.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                employee_Load(sender, e);
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM employee WHERE "+ cbo_attribute.Text + "=N'" + Txt_condition.Text.Replace("'", "''") + "'", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_employee.DataSource = ds.Tables[0];
        }
    }
}
