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
using static System.Net.Mime.MediaTypeNames;
using System.Security.Principal;

namespace WindowsForms訂購單
{
    public partial class manager : Form
    {
        string strSQLtable = "";
        List<int> searchID = new List<int>();
        SqlConnectionStringBuilder scsb;
        string strConnectionDB;
        int intGetID;
        int intCountReply=0;

        public manager()
        {
            InitializeComponent();
        }

        private void manager_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Restaurant";
            scsb.IntegratedSecurity = true;
            strConnectionDB = scsb.ToString();      
            radall.Checked = true;
        }

        void 色系操控()
        {
            btn_appetizers.BackColor=Color.FromArgb(221, 220, 220);
            btn_appetizers.ForeColor=Color.FromArgb(140, 106, 92);
            btn_mains.BackColor = Color.FromArgb(221, 220, 220);
            btn_mains.ForeColor=Color.FromArgb(140, 106, 92);
            btn_dishes.BackColor = Color.FromArgb(221, 220, 220);
            btn_dishes.ForeColor=Color.FromArgb(140, 106, 92);
            btn_desserts.BackColor = Color.FromArgb(221, 220, 220);
            btn_desserts.ForeColor = Color.FromArgb(140, 106, 92);
            btn_drinks.BackColor = Color.FromArgb(221, 220, 220);
            btn_drinks.ForeColor=Color.FromArgb(140, 106, 92);
        }
        void 進階搜尋控制()
        {
            txt搜尋欄.Text = "";
            combo類型.Items.Clear();
            txt地板.Text = "";
            txt天花板.Text = "";
            radall.Checked = true;
            searchID.Clear();
            combo類型.Text = "";
            combo類型.Items.Clear();
            listbox.Items.Clear();
        }

        void 呈現欄位控制()
        {
            lblID.Text = "000";
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            chkSupply.Checked = false;
        }
        
        void 菜單(string table)
        {
            SqlConnection con1 = new SqlConnection(strConnectionDB);
            con1.Open();
            string strSQL_listbox = "select * from "+ table + " order by 類型 DESC,ID";
            SqlCommand cmd1 = new SqlCommand(strSQL_listbox, con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                listbox.Items.Add(string.Format("{0}|{1}|{2}元|{3}", dr1["ID"], dr1["菜名"], dr1["價格"], dr1["類型"]));
                searchID.Add(Convert.ToInt32(dr1["ID"]));
            }
            dr1.Close();
            con1.Close();

            SqlConnection con2 = new SqlConnection(strConnectionDB);
            con2.Open();
            string strSQL_combobox = "select 類型 from "+ table + " group by 類型";
            SqlCommand cmd2 = new SqlCommand(strSQL_combobox, con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                combo類型.Items.Add((string)dr2["類型"]);
            }
        }

        private void btn_appetizers_Click(object sender, EventArgs e)
        {
            色系操控();
            進階搜尋控制();
            呈現欄位控制();
            btn_appetizers.BackColor = Color.FromArgb(130, 70, 70);
            btn_appetizers.ForeColor = Color.White;
            strSQLtable = "appetizers";
            菜單(strSQLtable);
        }

        private void btn_mains_Click(object sender, EventArgs e)
        {
            色系操控(); 進階搜尋控制(); 呈現欄位控制();
            btn_mains.BackColor = Color.FromArgb(130, 70, 70);
            btn_mains.ForeColor = Color.White;
            strSQLtable = "mains";
            菜單(strSQLtable);
        }

        private void btn_dishes_Click(object sender, EventArgs e)
        {
            色系操控(); 進階搜尋控制(); 呈現欄位控制();
            btn_dishes.BackColor = Color.FromArgb(130, 70, 70);
            btn_dishes.ForeColor = Color.White;
            strSQLtable = "dishes";
            菜單(strSQLtable);
        }

        private void btn_desserts_Click(object sender, EventArgs e)
        {
            色系操控(); 進階搜尋控制(); 呈現欄位控制();
            btn_desserts.BackColor = Color.FromArgb(130, 70, 70);
            btn_desserts.ForeColor = Color.White;
            strSQLtable = "desserts";
            菜單(strSQLtable);
        }

        private void btn_drinks_Click(object sender, EventArgs e)
        {
            色系操控(); 進階搜尋控制(); 呈現欄位控制();
            btn_drinks.BackColor = Color.FromArgb(130, 70, 70);
            btn_drinks.ForeColor = Color.White;
            strSQLtable = "drinks";
            菜單(strSQLtable);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            呈現欄位控制();
            listbox.Items.Clear();
            searchID.Clear();
            int count=0;
            
            string str搜尋欄="";
            string str類型="";
            string str地板="";
            string str天花板="";
            string str供應中 = "";
            if (txt搜尋欄.Text != "")
            {
                count++;
                str搜尋欄 = " 菜名 like '%" + txt搜尋欄.Text + "%'";
            }
            if (combo類型.Text != "")
            {
                count++;
                str類型 = " 類型 = '" + combo類型.Text+"'";
            }
            if (txt地板.Text != "")
            {
                count++;
                str地板 = " 價格 >= " + txt地板.Text;
            }
            if (txt天花板.Text != "")
            {
                count++;
                str天花板 = " 價格 <= " + txt天花板.Text;
            }
            if (radall.Checked != true)
            {
                count++;
                if (rad0.Checked == true)
                {
                    str供應中 = " 供應中 = 0";
                }
                else
                {
                    str供應中 = " 供應中 = 1";
                }
            }
            List<string> list進階搜尋 = new List<string> { str搜尋欄, str類型, str地板, str天花板, str供應中 };
            var 暫存 = list進階搜尋.OrderByDescending(f => f.Length).ToList();
            void SQL(string test)
            {
                SqlConnection con1 = new SqlConnection(strConnectionDB);
                con1.Open();
                string strSQL_listbox1 = test;
                SqlCommand cmd1 = new SqlCommand(strSQL_listbox1, con1);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    listbox.Items.Add(string.Format("{0}|{1}|{2}元|{3}", dr1["ID"], dr1["菜名"], dr1["價格"], dr1["類型"]));
                    searchID.Add(Convert.ToInt32(dr1["ID"]));
                }
                dr1.Close();
                con1.Close();
            }
            if (strSQLtable.Length != 0)
            {
                switch (count)
                {
                    case 1:
                        string strSQL_listbox1 = "select * from " + strSQLtable + " where " + 暫存[0].ToString();
                        SQL(strSQL_listbox1);
                        break;

                    case 2:
                        string strSQL_listbox2 = "select * from " + strSQLtable + " where " + 暫存[0].ToString() + " and " + 暫存[1];
                        SQL(strSQL_listbox2);
                        break;

                    case 3:
                        string strSQL_listbox3 = "select * from " + strSQLtable + " where " + 暫存[0].ToString() + " and " + 暫存[1] + " and " + 暫存[2];
                        SQL(strSQL_listbox3);
                        break;
                    case 4:
                        string strSQL_listbox4 = "select * from " + strSQLtable + " where " + 暫存[0].ToString() + " and " + 暫存[1] + " and " + 暫存[2] + " and " + 暫存[3];
                        SQL(strSQL_listbox4);
                        break;
                    case 5:
                        string strSQL_listbox5 = "select * from " + strSQLtable + " where " + 暫存[0].ToString() + " and " + 暫存[1] + " and " + 暫存[2] + " and " + 暫存[3] + " and " + 暫存[4];
                        SQL(strSQL_listbox5);
                        break;
                    default:
                        MessageBox.Show("請輸入搜尋商品");
                        break;
                }
            }if(listbox.Items.Count == 0)
            {
                MessageBox.Show("無此樣商品");
            }
            
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox.SelectedIndex > -1)
            {
                intGetID = searchID[listbox.SelectedIndex];
                SqlConnection con = new SqlConnection(strConnectionDB);
                con.Open();
                string strSQL_listbox = "select * from "+ strSQLtable +" where ID ="+ intGetID.ToString();
                SqlCommand cmd1 = new SqlCommand(strSQL_listbox, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    lblID.Text=dr1["ID"].ToString();
                    txtName.Text=dr1["菜名"].ToString();
                    txtCategory.Text=dr1["類型"].ToString();
                    txtPrice.Text = dr1["價格"].ToString();
                    chkSupply.Checked = Convert.ToBoolean(dr1["供應中"]);
                }
                dr1.Close();
                con.Close();
            }
        }

        void 名稱重複()
        {

            if (txtName.Text.Length > 0 )
            {
                SqlConnection con = new SqlConnection(strConnectionDB);
                con.Open();
                string toSQL = "select count(*) as datacount from " + strSQLtable +" where 菜名=@Name " ;
                SqlCommand amd = new SqlCommand(toSQL, con);
                amd.Parameters.AddWithValue("@Name",txtName.Text);
                SqlDataReader reader= amd.ExecuteReader();

                while (reader.Read())
                {
                    intCountReply = Convert.ToInt32(reader["datacount"]);
                }
                reader.Close();
                con.Close();
                if (intCountReply != 0)
                {
                    MessageBox.Show("名稱重複");
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            名稱重複();
            if (lblID.Text == "000" && intCountReply ==0 && strSQLtable.Length != 0 && txtName.Text != "" && txtName.Text != "" && txtPrice.Text != "")
            {
                SqlConnection con = new SqlConnection(strConnectionDB);
                con.Open();
                string toSQL = "insert into "+ strSQLtable +" values(@Name,@Category,@Price,@Time,@Supply);";
                SqlCommand cmd = new SqlCommand(toSQL, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@Time", DateTime.Now);
                cmd.Parameters.AddWithValue("@Supply", chkSupply.Checked);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("新增成功");
            }
            else
            {
                MessageBox.Show("未成功完成填寫");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (strSQLtable.Length != 0 && txtName.Text != "" && txtName.Text != "" && txtPrice.Text != "")
            {
                SqlConnection con = new SqlConnection(strConnectionDB);
                con.Open();
                string toSQL = "update " + strSQLtable + " set 菜名=@Name , 類型=@Category , 價格=@Price , 上架時間=@Time , 供應中=@Supply where ID = @ID ;";
                SqlCommand cmd = new SqlCommand(toSQL, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@Time", DateTime.Now);
                cmd.Parameters.AddWithValue("@Supply", chkSupply.Checked);
                cmd.Parameters.AddWithValue("@ID", lblID.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("未完成填寫");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "000")
            {
                int intID = Convert.ToInt32(lblID.Text);
                SqlConnection con = new SqlConnection(strConnectionDB);
                con.Open();
                string toSQL = "delete from "+ strSQLtable +" where ID = @ID";
                SqlCommand cmd= new SqlCommand(toSQL, con);
                cmd.Parameters.AddWithValue("@ID",intID);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料已刪除");
                呈現欄位控制();
            }
        }

        private void btnClearPrint_Click(object sender, EventArgs e)
        {
            lblID.Text = "000";
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            chkSupply.Checked = false;
        }
   
    }
}
