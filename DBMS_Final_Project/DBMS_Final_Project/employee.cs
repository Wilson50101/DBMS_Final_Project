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
        //連結資料庫的字串
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";
        public employee()
        {
            InitializeComponent();
        }

        //Form載入時的事件處理
        private void employee_Load(object sender, EventArgs e)
        {
            //DataGridView連結到customer資料表
            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM employee", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_employee.DataSource = ds.Tables[0];

            //SELECT operation的combo box顯示字串
            if (!cbo_attribute.Items.Contains("EmpID"))
                cbo_attribute.Items.Add("EmpID");//防止執行完一次指令之後重複將同一個item加入combox box
            if (!cbo_attribute.Items.Contains("EmpName"))
                cbo_attribute.Items.Add("EmpName");//防止執行完一次指令之後重複將同一個item加入combox box
            if (!cbo_attribute.Items.Contains("EmpPhone"))
                cbo_attribute.Items.Add("EmpPhone");//防止執行完一次指令之後重複將同一個item加入combox box
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            //利用try catch結構可以抓出例外處理
            try
            {
                //連結資料庫設定
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;

                //打開資料庫
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                
                //INSERT指令
                cmd.CommandText = "INSERT INTO employee(EmpID,EmpName,EmpPhone)VALUES(N'" + Txt_EmpID.Text.Replace("'", "''") + "',N'" +
                    Txt_EmpName.Text.Replace("'", "''") + "',N'" +
                    Txt_EmpPhone.Text.Replace("'", "''")+"')";

                //執行指令
                cmd.ExecuteNonQuery();

                //關閉資料庫
                db.Close();

                //重新load_employee-->讓更新過後的資料呈現在DataGridView
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
                //連結資料庫設定
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;

                //連結資料庫設定
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;

                //DELETE指令
                cmd.CommandText = "DELETE FROM employee WHERE EmpID=N'" + Txt_EmpID.Text.Replace("'", "''") + "'";

                //執行指令
                cmd.ExecuteNonQuery();

                //關閉資料庫
                db.Close();

                //重新load_employee-->讓更新過後的資料呈現在DataGridView
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

                //連結資料庫設定
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;

                //打開資料庫
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;

                //DELETE指令
                cmd.CommandText = "UPDATE employee SET EmpName=N'" + Txt_EmpName.Text.Replace("'", "''") + "'," + "EmpPhone=N'" + Txt_EmpPhone.Text.Replace("'", "''") +"'" + "WHERE EmpID=N'" + Txt_EmpID.Text.Replace("'", "''") + "'";

                //執行指令
                cmd.ExecuteNonQuery();
                
                //關閉資料庫
                db.Close();

                //重新load_employee-->讓更新過後的資料呈現在DataGridView
                employee_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            //連結資料庫設定
            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;

            //DataAdapter為資料來源和DataSet之間配接器,將SQL指令讀取到的資料填到DataSet
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM employee WHERE "+ cbo_attribute.Text + "=N'" + Txt_condition.Text.Replace("'", "''") + "'", db);

            //DataSet放SELECT結果
            DataSet ds = new DataSet();
            da.Fill(ds);

            //在DataGridView呈現
            DGV_employee.DataSource = ds.Tables[0];
        }
    }
}
