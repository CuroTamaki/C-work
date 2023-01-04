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
using WindowsFormsApp2;
using System.Security.Cryptography.X509Certificates;

namespace WindowsForms訂購單
{
    public partial class old_members : Form
    {
        SqlConnectionStringBuilder scsb;
        string strConnection = "";
        int ID = GlobalVar.ID;
        string 稱謂="先生";

        public old_members()
        {
            InitializeComponent();
        }

        private void old_members_Load(object sender, EventArgs e)
        {
            txtAccount.Enabled = false;

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource=@".";
            scsb.InitialCatalog = "Restaurant";
            scsb.IntegratedSecurity = true;
            strConnection = scsb.ToString();

            SqlConnection con = new SqlConnection(strConnection);
            con.Open();
            string str_SQL = "select * from members where ID="+ID.ToString();
            SqlCommand cmd = new SqlCommand(str_SQL, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtAccount.Text = dr["帳號"].ToString();
                txtPassword.Text = dr["密碼"].ToString();
                txtPWcomfirm.Text = dr["密碼"].ToString();
                txt姓名.Text= dr["姓名"].ToString();
                稱謂= dr["稱謂"].ToString();
                txt電話.Text = dr["手機"].ToString();
                txt地址.Text= dr["地址"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                dtp生日.Value = Convert.ToDateTime(dr["生日"]);
                chkOK.Checked = Convert.ToBoolean(dr["收到資訊"]);

            }
            dr.Close();
            con.Close();
            if (稱謂 != "小姐")
            {
                rad_m.Checked = true;
            }
            else
            {
                稱謂 = "小姐";
                rad_f.Checked = true;
            }

            SqlConnection con1 = new SqlConnection(strConnection);
            con1.Open();
            string str_SQLOrder = "select * from orders where 會員ID=" + ID.ToString()+"order by 訂購時間 ASC";
            SqlCommand cmd1 = new SqlCommand(str_SQLOrder, con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                Panel panel = new Panel();
                PanelLoad.Controls.Add(panel);
                panel.Size = new Size(100, 70);
                panel.Dock = DockStyle.Top;
                Button btn = new Button();
                btn.Click += new EventHandler(button_click);
                panel.Controls.Add(btn);
                btn.Size = new Size(100, 70);
                btn.Dock = DockStyle.Top;
                btn.Tag = dr1["訂單編號"].ToString();
                string str訂單編號 = dr1["訂單編號"].ToString();
                string str訂單時間 = dr1["訂購時間"].ToString();
                btn.Text = "訂單編號"+str訂單編號 + "\n" + str訂單時間;
                btn.BackColor = Color.FromArgb(221, 220, 220);
                btn.ForeColor = Color.FromArgb(140, 106, 92);
                btn.Font = new Font("微軟正黑體",10,FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleCenter;
            }
            dr1.Close();
            con1.Close();
        }

        void button_click(object sender,EventArgs e)
        {

            Button btn = (Button)sender;
            string strOrderID = btn.Tag.ToString();
            
            SqlConnection con1 = new SqlConnection(strConnection);
            con1.Open();
            string str_SQLOrder = "select o.訂單編號,OD.項目ID,OD.名稱,OD.單價,OD.數量,OD.總價 from orders as O join  order_detail as OD on O.訂單編號=OD.訂單編號 where O.訂單編號=" + strOrderID;
            SqlCommand cmd1 = new SqlCommand(str_SQLOrder, con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            string strOrderIDShow="";
            string strItem="";
            while (dr1.Read())
            {
                strOrderIDShow = dr1["訂單編號"].ToString();
                string strProductName = dr1["名稱"].ToString();
                string strProductPrice = dr1["單價"].ToString();
                string strProductAmong = dr1["數量"].ToString();
                string strProductSum = dr1["總價"].ToString();

                strItem += strProductName + " | " + strProductPrice + "元 | " + strProductAmong + "份 | " + strProductSum + "元\n";
            }
            dr1.Close();
            con1.Close();
            MessageBox.Show("訂單編號:"+strOrderIDShow +"\n"+ strItem);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtPWcomfirm_TextChanged(object sender, EventArgs e)
        {
            txtPWcomfirm.PasswordChar = '*';
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strConnection);
            con.Open();
            string toSQL = "update members set 權限=@right , 稱謂=@gender , 帳號=@account , 密碼=@password , 姓名=@name , 手機=@phone , Email=@mail , 生日=@birth , 地址=@address , 註冊時間=@now , 收到資訊=@receive where ID = @ID;";
            SqlCommand cmd = new SqlCommand(toSQL, con);
            int 權限 = GlobalVar.權限;
            cmd.Parameters.AddWithValue("@right", 權限);
            cmd.Parameters.AddWithValue("@gender", 稱謂);
            cmd.Parameters.AddWithValue("@account", txtAccount.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@name", txt姓名.Text);
            cmd.Parameters.AddWithValue("@phone", txt電話.Text);
            cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@birth", dtp生日.Value);
            cmd.Parameters.AddWithValue("@now", DateTime.Now);
            cmd.Parameters.AddWithValue("@address", txt地址.Text);
            cmd.Parameters.AddWithValue("@receive", chkOK.Checked);
            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("成功修改資料!");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            GlobalVar.權限 = 0;
            GlobalVar.訂購人資訊 = "";
            GlobalVar.訂購人電話 = "";
            GlobalVar.ID = 0;
            if (Logout != null)
            {
                Logout();
            }
            this.Close();
        }
        public delegate void deleToLogOut();
        public event deleToLogOut Logout;
    }
}
