using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsForms訂購單
{
    public partial class temp : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnection = "";
        int count = 0;
        int 權限;
        int ID;
        string 會員資訊;
        string 會員電話;

        public temp()
        {
            InitializeComponent();
        }

        private void temp_Load(object sender, EventArgs e)
        {
            txt_訂購人.Text = GlobalVar.訂購人資訊;
            txt_電話.Text = GlobalVar.訂購人電話;
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Restaurant";
            scsb.IntegratedSecurity = true;
            strDBconnection = scsb.ToString();


            if (txt_帳號.Text != "" && txt_密碼.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBconnection);
                con.Open();
                string strSQL = "select * from members where 帳號 = '" + txt_帳號.Text + "' and 密碼='" + txt_密碼.Text + "';";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    count++;
                    ID=Convert.ToInt32(reader["ID"]);
                    會員資訊 = reader["姓名"].ToString();
                    會員電話 = reader["手機"].ToString();
                    權限 = Convert.ToInt32(reader["權限"]);
                }

                if (count != 0)
                {
                    MessageBox.Show("您輸入正確");
                    txt_訂購人.Text = 會員資訊;
                    txt_電話.Text = 會員電話;
                    GlobalVar.ID = ID;
                    GlobalVar.訂購人資訊 = 會員資訊;
                    txt_訂購人.Text = 會員資訊;
                    GlobalVar.訂購人電話 = 會員電話;
                    txt_電話.Text = 會員電話;
                    GlobalVar.權限 = 權限;
                    if (trigger1 != null)
                    {
                        trigger1();
                    }
                }
                else
                {
                    MessageBox.Show("您輸入錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼");
            }

        }
        public delegate void deleToManager ();

        public event deleToManager trigger1;

        private void txt_密碼_TextChanged(object sender, EventArgs e)
        {
            txt_密碼.PasswordChar = '*';
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            GlobalVar.訂購人資訊= txt_訂購人.Text;
            GlobalVar.訂購人電話= txt_電話.Text;
            MessageBox.Show("已登錄資訊");
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
