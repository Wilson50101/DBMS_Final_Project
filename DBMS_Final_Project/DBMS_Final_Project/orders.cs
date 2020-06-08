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
        //連結資料庫的字串
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";

        public orders()
        {
            InitializeComponent();
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
                cmd.CommandText = "INSERT INTO orders(orderID,fare,deliverDate)VALUES(N'" + Txt_orderID.Text.Replace("'", "''") + "'," +
                    int.Parse(Txt_fare.Text) + ",N'" +
                    Txt_deliverDate.Text.Replace("'", "''") + "')";

                //執行指令
                cmd.ExecuteNonQuery();

                //關閉資料庫
                db.Close();

                //重新load_order-->讓更新過後的資料呈現在DataGridView
                orders_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Form載入時的事件處理
        private void orders_Load(object sender, EventArgs e)
        {
            //DataGridView連結到customer資料表
            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM orders", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_orders.DataSource = ds.Tables[0];

            //SELECT operation的combo box顯示字串

            //防止執行完一次指令之後重複將同一個item加入combox box
            if (!cbo_attribute.Items.Contains("orderID"))
                cbo_attribute.Items.Add("orderID");

            //防止執行完一次指令之後重複將同一個item加入combox box
            if (!cbo_attribute.Items.Contains("fare"))
                cbo_attribute.Items.Add("fare");

            //防止執行完一次指令之後重複將同一個item加入combox box
            if (!cbo_attribute.Items.Contains("deliverDate"))
                cbo_attribute.Items.Add("deliverDate");
        }

        private void btn_delete_Click(object sender, EventArgs e)
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

                //DELETE指令
                cmd.CommandText = "DELETE FROM orders WHERE orderID=N'" + Txt_orderID.Text.Replace("'", "''") + "'";

                //執行指令
                cmd.ExecuteNonQuery();

                //關閉資料庫
                db.Close();

                //重新load_order-->讓更新過後的資料呈現在DataGridView
                orders_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
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

                //UPDATE指令
                cmd.CommandText = "UPDATE orders SET fare=" + int.Parse(Txt_fare.Text)+ ",deliverDate=N'" + Txt_deliverDate.Text.Replace("'", "''") + "'" + "WHERE orderID=N'" + Txt_orderID.Text.Replace("'", "''") + "'";

                //執行指令
                cmd.ExecuteNonQuery();

                //關閉資料庫
                db.Close();

                //重新load_order-->讓更新過後的資料呈現在DataGridView
                orders_Load(sender, e);
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


            //SQL指令
            string operation = "SELECT * FROM orders WHERE " + cbo_attribute.Text;
            if (cbo_attribute.Text == "fare")
                operation += Txt_condition.Text;
            else
                operation += "=N'" + Txt_condition.Text.Substring(1).Replace("'", "''") + "'";

            //DataAdapter為資料來源和DataSet之間配接器,將SQL指令讀取到的資料填到DataSet
            SqlDataAdapter da = new SqlDataAdapter(operation, db);

            //DataSet放SELECT結果
            DataSet ds = new DataSet();
            da.Fill(ds);

            //在DataGridView呈現
            DGV_orders.DataSource = ds.Tables[0];

            Txt_condition.Text = "= 還是 >,<,>=,<= 要打在這";
        }
    }
}
