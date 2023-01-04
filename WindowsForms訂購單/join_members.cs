using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsForms訂購單
{

    public partial class join_members : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnection = "";
        int intAccountExist = 0;
        bool bool不完全為空=false;
        bool bool帳號不存在 = false;
        bool bool密碼不相同 = false;
        bool bool電話號碼測試 = false;
        string 稱呼 = "先生";

        public join_members()
        {
            InitializeComponent();
        }

        void join_members_Load(object sender, EventArgs e)
        {
            lbl_ACexist.Visible = false;
            lbl_PWdiffer.Visible = false;
            lblphone.Visible = false;
            lblACshort.Visible = false;
            chkOK.Checked = true;
            rad_m.Checked = true;

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Restaurant";
            scsb.IntegratedSecurity = true;
            strDBconnection = scsb.ToString();
        }

        void 填寫完全()
        {
            if (txtAccount.Text == "" && txtPassword.Text == "" && txtPWcomfirm.Text == "" && txtEmail.Text == "" && txt姓名.Text == "" && txt電話.Text == "") 
            {
                MessageBox.Show("請填寫完全");
            }
            else
            {
                bool不完全為空 = true;
            }
        }
        void 帳號已存在確認()
        {
            if (txtAccount.Text.Length > 5)
            {
                lblACshort.Visible = false;
                SqlConnection con = new SqlConnection(strDBconnection);
                con.Open();
                string toSQL = "select count(*) as count from members where 帳號=@Account";
                SqlCommand amd = new SqlCommand(toSQL, con);
                amd.Parameters.AddWithValue("@Account", txtAccount.Text);
                SqlDataReader reader = amd.ExecuteReader();

                while (reader.Read())
                {
                    intAccountExist = Convert.ToInt32(reader["count"]);
                }
                reader.Close();
                con.Close();


                if (intAccountExist != 0)
                {
                    lbl_ACexist.Visible = true;
                }
                else
                {
                    lbl_ACexist.Visible = false;
                    bool帳號不存在 = true;
                }
            }
            else 
            { 
                lblACshort.Visible = true;
            }
        }
        void 密碼相同確認()
        {
            if (txtPassword.Text != txtPWcomfirm.Text)
            {
                lbl_PWdiffer.Visible = true;
            }
            else
            {
                lbl_PWdiffer.Visible = false;
                bool密碼不相同 = true;
            }
        }
        void 電話確認()
        {
                if (txt電話.Text.Length == 10)
                {
                    int 測試電話號碼 = txt電話.Text.IndexOf("09");
                    if (測試電話號碼 != 0)
                    {
                        lblphone.Visible = true;
                    }
                    else
                    {
                        bool電話號碼測試 = true;
                        lblphone.Visible = false;
                    }
                }

         }

        void btn_join_Click(object sender, EventArgs e)
        {
            填寫完全();
            帳號已存在確認();
            密碼相同確認();
            電話確認();
            if (bool不完全為空==true && bool密碼不相同 == true && bool帳號不存在 == true && bool電話號碼測試 == true && dtp生日.Value!=DateTime.Now)
            {
                SqlConnection con = new SqlConnection(strDBconnection);
                con.Open();
                string toSQL = "insert into members values(@right,@gender,@account,@password,@name,@phone,@mail,@birth,@address,@now,@receive);";
                SqlCommand cmd = new SqlCommand(toSQL, con);
                int 權限 = 100;
                cmd.Parameters.AddWithValue("@right",權限);
                cmd.Parameters.AddWithValue("@gender",稱呼);
                cmd.Parameters.AddWithValue("@account",txtAccount.Text);
                cmd.Parameters.AddWithValue("@password",txtPassword.Text);
                cmd.Parameters.AddWithValue("@name", txt姓名.Text);
                cmd.Parameters.AddWithValue("@phone", txt電話.Text);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@birth",dtp生日.Value);
                cmd.Parameters.AddWithValue("@now",DateTime.Now);
                cmd.Parameters.AddWithValue("@address", txt地址.Text);
                cmd.Parameters.AddWithValue("@receive", chkOK.Checked);
                
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("成功加入會員!");
                this.Close();
                if (能動的事件 != null)
                {
                    能動的事件();
                }
            }
        }

        public delegate void deleToBackTemp();
        public event deleToBackTemp 能動的事件;

        void btn_del_Click(object sender, EventArgs e)
        {
            txtAccount.Clear();
            txtPWcomfirm.Clear();
            txtPassword.Clear();
            txt姓名.Clear();
            txt電話.Clear();
            txtEmail.Clear();
            txt地址.Clear();
            dtp生日.Value=DateTime.Now;
            chkOK.Enabled = true;
        }

        void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(SystemColors.Control);
        }

        void gb_gender_Enter(object sender, EventArgs e)
        {
            if (rad_f.Checked == true)
            {
                稱呼 = "小姐";
            }
            else
            {
                稱呼 = "先生";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtPWcomfirm_TextChanged(object sender, EventArgs e)
        {
            txtPWcomfirm.PasswordChar = '*';
        }

    }
}
