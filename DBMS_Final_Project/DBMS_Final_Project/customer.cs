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
        //連結資料庫的字串
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";
        public customer()
        {
            InitializeComponent();
        }

        //Form載入時的事件處理
        private void customer_Load(object sender, EventArgs e)
        {
            //DataGridView連結到customer資料表
            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM customer", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_customer.DataSource = ds.Tables[0];

            //SELECT operation的combo box顯示字串
            if (!cbo_attribute.Items.Contains("custID"))
                cbo_attribute.Items.Add("custID");//防止執行完一次指令之後重複將同一個item加入combox box
            if (!cbo_attribute.Items.Contains("custName"))
                cbo_attribute.Items.Add("custName");//防止執行完一次指令之後重複將同一個item加入combox box
            if (!cbo_attribute.Items.Contains("custPhone"))
                cbo_attribute.Items.Add("custPhone");//防止執行完一次指令之後重複將同一個item加入combox box
            if (!cbo_attribute.Items.Contains("custAddr"))
                cbo_attribute.Items.Add("custAddr");//防止執行完一次指令之後重複將同一個item加入combox box
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
                cmd.CommandText="INSERT INTO customer(custID,custName,custPhone,custAddr)VALUES(N'"+Txt_custID.Text.Replace("'","''")+"',N'"+
                    Txt_custName.Text.Replace("'", "''") + "',N'" +
                    Txt_custPhone.Text.Replace("'", "''") + "',N'" +
                    Txt_custAddr.Text.Replace("'", "''")+"')";

                //執行指令
                cmd.ExecuteNonQuery();

                //關閉資料庫
                db.Close();

                //重新load_ customer-->讓更新過後的資料呈現在DataGridView
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
                //連結資料庫設定
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;

                //打開資料庫
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                
                //DELETE指令
                cmd.CommandText = "DELETE FROM customer WHERE custID=N'" + Txt_custID.Text.Replace("'", "''") + "'";

                //執行指令
                cmd.ExecuteNonQuery();

                //關閉資料庫
                db.Close();

                //重新load_ customer-->讓更新過後的資料呈現在DataGridView
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
                //連結資料庫設定
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;

                //打開資料庫
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;

                //DELETE指令
                cmd.CommandText = "UPDATE customer SET custName=N'"+ Txt_custName.Text.Replace("'", "''") + "',"+ "custPhone=N'" + Txt_custPhone.Text.Replace("'", "''") + "',"+"custAddr=N'" + Txt_custAddr.Text.Replace("'", "''") + "'" + "WHERE custID=N'" + Txt_custID.Text.Replace("'", "''") + "'";

                //執行指令
                cmd.ExecuteNonQuery();

                //關閉資料庫
                db.Close();

                //重新load_ customer-->讓更新過後的資料呈現在DataGridView
                customer_Load(sender, e);
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM customer WHERE " + cbo_attribute.Text + "=N'" + Txt_condition.Text.Replace("'", "''") + "'", db);

            //DataSet放SELECT結果
            DataSet ds = new DataSet();
            da.Fill(ds);

            //在DataGridView呈現
            DGV_customer.DataSource = ds.Tables[0];
        }
    }
}
