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
        //連結資料庫的字串
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=|DataDirectory|Database1.mdf;" + "Integrated Security=True";

        public vender()
        {
            InitializeComponent();
        }

        //Form載入時的事件處理
        private void vender_Load(object sender, EventArgs e)
        {
            //DataGridView連結到customer資料表
            SqlConnection db = new SqlConnection();
            db.ConnectionString = cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vender", db);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV_vender.DataSource = ds.Tables[0];

            //SELECT operation的combo box顯示字串
            if (!cbo_attribute.Items.Contains("venderID"))
                cbo_attribute.Items.Add("venderID");//防止執行完一次指令之後重複將同一個item加入combox box
            if (!cbo_attribute.Items.Contains("venderName"))
                cbo_attribute.Items.Add("venderName");//防止執行完一次指令之後重複將同一個item加入combox box
            if (!cbo_attribute.Items.Contains("venderPhone"))
                cbo_attribute.Items.Add("venderPhone");//防止執行完一次指令之後重複將同一個item加入combox box
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
                cmd.CommandText = "INSERT INTO vender(venderID,venderName,venderPhone)VALUES(N'" + Txt_venderID.Text.Replace("'", "''") + "',N'" +
                    Txt_venderName.Text.Replace("'", "''") + "',N'" +
                    Txt_venderPhone.Text.Replace("'", "''") + "')";

                //執行指令
                cmd.ExecuteNonQuery();

                //關閉資料庫
                db.Close();

                //重新load_vender-->讓更新過後的資料呈現在DataGridView
                vender_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                cmd.CommandText = "DELETE FROM vender WHERE venderID=N'" + Txt_venderID.Text.Replace("'", "''") + "'";

                //執行指令
                cmd.ExecuteNonQuery();

                //關閉資料庫
                db.Close();

                //重新load_vender-->讓更新過後的資料呈現在DataGridView
                vender_Load(sender, e);
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
                cmd.CommandText = "UPDATE vender SET venderName=N'" + Txt_venderName.Text.Replace("'", "''") + "'," + "venderPhone=N'" + Txt_venderPhone.Text.Replace("'", "''") + "'" + "WHERE venderID=N'" + Txt_venderID.Text.Replace("'", "''") + "'";

                //執行指令
                cmd.ExecuteNonQuery();

                //關閉資料庫
                db.Close();

                //重新load_vender-->讓更新過後的資料呈現在DataGridView
                vender_Load(sender, e);
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vender WHERE " + cbo_attribute.Text + "=N'" + Txt_condition.Text.Replace("'", "''") + "'", db);
            DataSet ds = new DataSet();

            //DataSet放SELECT結果
            da.Fill(ds);

            //在DataGridView呈現
            DGV_vender.DataSource = ds.Tables[0];
        }
    }
}
