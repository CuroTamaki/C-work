using System;
using System.Collections;
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
using System.Xml;

namespace WindowsFormsApp2
{
    public partial class OrderCart : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnection = "";

        static int 全部總價;
        int 套餐數量;
        int 開胃菜數量;
        int 主餐數量;
        int 排餐數量;
        int 甜點數量;
        int 飲料數量;

        int intdate;
        int ran;
        Int64 orderID;

        public OrderCart()
        {
            InitializeComponent();
        }

        private void OrderCart_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Restaurant";
            scsb.IntegratedSecurity = true;
            strDBconnection = scsb.ToString();

            rad內用.Checked = true;
            chk購物袋.Enabled = false;
            txt_訂購人.Text = GlobalVar.訂購人資訊;
            txt_電話.Text = GlobalVar.訂購人電話;
            列表();
            內用外帶計算機();
            intdate=int.Parse(DateTime.Now.ToString("yyMMdd"));
            Random random = new Random();
            ran = random.Next(1000, 10000);
            orderID = Convert.ToInt64(intdate.ToString() + ran.ToString());
            if(listBox訂購內容.Items.Count == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        void 列表()
        {
            foreach (ArrayList 細項 in GlobalVar.list訂購套餐)
            {
                int ID = (int)細項[0];
                string 品項 = (string)細項[1];
                int 單價 = (int)細項[2];
                int 數量 = (int)細項[3];
                int 總價 = (int)細項[4];
                string 備註 = (string)細項[5];
                string str訂單 = string.Format("套餐:{0} | {1}元 | {2}份 | {3}元 | {4}", 品項, 單價, 數量, 總價, 備註);
                listBox訂購內容.Items.Add(str訂單);
                全部總價 += (int)細項[4];
            }

            foreach (ArrayList 細項 in GlobalVar.list訂購開胃菜列表)
            {
                int ID = (int)細項[0];
                string 品項 = (string)細項[1];
                int 單價 = (int)細項[2];
                int 數量 = (int)細項[3];
                int 總價 = (int)細項[4];
                string 備註 = (string)細項[5];
                string str訂單 = string.Format("{0} | {1}元 | {2}份 | {3}元 | {4}", 品項, 單價, 數量, 總價, 備註);
                listBox訂購內容.Items.Add(str訂單);
                全部總價 += (int)細項[4];
            }
            
            foreach (ArrayList 細項 in GlobalVar.list訂購主餐列表)
            {
                int ID = (int)細項[0];
                string 品項 = (string)細項[1];
                int 單價 = (int)細項[2];
                int 數量 = (int)細項[3];
                int 總價 = (int)細項[4];
                string 備註 = (string)細項[5];
                string str訂單 = string.Format("{0} | {1}元 | {2}份 | {3}元 | {4}", 品項, 單價, 數量, 總價, 備註);
                listBox訂購內容.Items.Add(str訂單);
                全部總價 += (int)細項[4];
            }

            foreach (ArrayList 細項 in GlobalVar.list訂購排餐列表)
            {
                int ID = (int)細項[0];
                string 品項 = (string)細項[1];
                int 單價 = (int)細項[2];
                int 數量 = (int)細項[3];
                int 總價 = (int)細項[4];
                string 備註 = (string)細項[5];
                string str訂單 = string.Format("{0} | {1}元 | {2}份 | {3}元 | {4}", 品項, 單價, 數量, 總價, 備註);
                listBox訂購內容.Items.Add(str訂單);
                全部總價 += (int)細項[4];
            }

            foreach(ArrayList 細項 in GlobalVar.list訂購甜點列表)
            {
                int ID = (int)細項[0];
                string 品項 = (string)細項[1];
                int 單價 = (int)細項[2];
                int 數量 = (int)細項[3];
                int 總價 = (int)細項[4];
                string 備註 = (string)細項[5];
                string str訂單 = string.Format("{0} | {1}元 | {2}份 | {3}元 | {4}", 品項, 單價, 數量, 總價, 備註);
                listBox訂購內容.Items.Add(str訂單);
                全部總價 += (int)細項[4];
            }

            foreach (ArrayList 細項 in GlobalVar.list訂購飲料列表)
            {
                int ID = (int)細項[0];
                string 品項 = (string)細項[1];
                int 單價 = (int)細項[2];
                int 數量 = (int)細項[3];
                int 總價 = (int)細項[4];
                string 備註 = (string)細項[5];
                string str訂單 = string.Format("{0} | {1}元 | {2}份 | {3}元 | {4}", 品項, 單價, 數量, 總價, 備註);
                listBox訂購內容.Items.Add(str訂單);
                全部總價 += (int)細項[4];
            }
        }


        private void rad內用_CheckedChanged(object sender, EventArgs e)
        {
            chk購物袋.Checked = false;
            chk購物袋.Enabled = false;
            內用外帶計算機();
        }

        private void rad外帶_CheckedChanged(object sender, EventArgs e)
        {
            chk購物袋.Enabled = true;
            內用外帶計算機();
        }

        private void chk購物袋_CheckedChanged(object sender, EventArgs e)
        {
            內用外帶計算機();
        }

        private void btn刪除所選項目_Click(object sender, EventArgs e)
        {
            if (listBox訂購內容.SelectedIndex > -1)
            {
                int 選擇清除項目 = listBox訂購內容.SelectedIndex;
                listBox訂購內容.Items.RemoveAt(選擇清除項目);
                套餐數量 = GlobalVar.list訂購套餐.Count;
                開胃菜數量 = GlobalVar.list訂購開胃菜列表.Count;
                主餐數量 = GlobalVar.list訂購主餐列表.Count;
                排餐數量 = GlobalVar.list訂購排餐列表.Count;
                甜點數量 = GlobalVar.list訂購甜點列表.Count;
                飲料數量 = GlobalVar.list訂購飲料列表.Count;
                if (選擇清除項目 < 套餐數量)
                {
                    GlobalVar.list訂購套餐.RemoveAt(選擇清除項目);
                }
                else if (選擇清除項目 < 開胃菜數量+套餐數量)
                {
                    GlobalVar.list訂購開胃菜列表.RemoveAt(選擇清除項目-套餐數量);
                }
                else if (選擇清除項目 < (套餐數量 + 開胃菜數量 + 主餐數量))
                {
                    GlobalVar.list訂購主餐列表.RemoveAt(選擇清除項目-(套餐數量 + 開胃菜數量));
                }else if(選擇清除項目 < (套餐數量 + 開胃菜數量 + 主餐數量 + 排餐數量))
                {
                    GlobalVar.list訂購排餐列表.RemoveAt(選擇清除項目 - (套餐數量 + 開胃菜數量 + 主餐數量));
                }
                else if(選擇清除項目 < (套餐數量 + 開胃菜數量 + 主餐數量 + 排餐數量 + 甜點數量))
                {
                    int 甜點序列 = 套餐數量 + 開胃菜數量 + 主餐數量 +排餐數量;
                    GlobalVar.list訂購甜點列表.RemoveAt(選擇清除項目-甜點序列);
                }
                else if (選擇清除項目 < (套餐數量 + 開胃菜數量 + 主餐數量 + 排餐數量 + 甜點數量 + 飲料數量))
                {
                    int 飲料序列 = 套餐數量 + 開胃菜數量 + 主餐數量 + 排餐數量 + 甜點數量;
                    GlobalVar.list訂購飲料列表.RemoveAt(選擇清除項目 - 飲料序列); 
                }
            }
            全部總價 = 0;
            listBox訂購內容.Items.Clear();
            列表();
            內用外帶計算機();
        }
        void 清空購物車()
        {
            全部總價 = 0;
            listBox訂購內容.Items.Clear();
            GlobalVar.list訂購套餐.Clear();
            GlobalVar.list訂購開胃菜列表.Clear();
            GlobalVar.list訂購主餐列表.Clear();
            GlobalVar.list訂購排餐列表.Clear();
            GlobalVar.list訂購甜點列表.Clear();
            GlobalVar.list訂購飲料列表.Clear();
        }

        private void btn清空購物車_Click(object sender, EventArgs e)
        {
            清空購物車();
            內用外帶計算機();
            button1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_訂購人.Text != "" && txt_電話.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBconnection);
                con.Open();
                string toSQL = "insert into orders values(@OrderID,@MemberID,@Name,@Phone,@Settle,@InOrOut,@Time);";
                SqlCommand cmd = new SqlCommand(toSQL, con);

                cmd.Parameters.AddWithValue("@OrderID", orderID.ToString());
                cmd.Parameters.AddWithValue("@MemberID", GlobalVar.ID.ToString());
                cmd.Parameters.AddWithValue("@Name", GlobalVar.訂購人資訊.ToString());
                cmd.Parameters.AddWithValue("@Phone", GlobalVar.訂購人電話.ToString());
                cmd.Parameters.AddWithValue("@Settle", 全部總價.ToString());
                cmd.Parameters.AddWithValue("@InOrOut", rad內用.Checked);
                cmd.Parameters.AddWithValue("@Time", DateTime.Now);

                cmd.ExecuteNonQuery();
                con.Close();

                訂購完成建置資料庫(GlobalVar.list訂購套餐);
                訂購完成建置資料庫(GlobalVar.list訂購開胃菜列表);
                訂購完成建置資料庫(GlobalVar.list訂購主餐列表);
                訂購完成建置資料庫(GlobalVar.list訂購排餐列表);
                訂購完成建置資料庫(GlobalVar.list訂購甜點列表);
                訂購完成建置資料庫(GlobalVar.list訂購飲料列表);
                MessageBox.Show("購買成功，請支付金額");
                清空購物車();
                內用外帶計算機();
                button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("請完成訂購人資料");
            }
        }

        void 訂購完成建置資料庫(List<ArrayList> 測試)
        {
            if (測試.Count != 0)
            {
                foreach (ArrayList item in 測試)
                {
                    SqlConnection con = new SqlConnection(strDBconnection);
                    con.Open();
                    string toSQL = "insert into order_detail values(@OrderID,@ProductID,@Name,@Price,@Count,@SumPrice,@PS);";
                    SqlCommand cmd = new SqlCommand(toSQL, con);

                    cmd.Parameters.AddWithValue("@OrderID", orderID.ToString());
                    cmd.Parameters.AddWithValue("@ProductID", item[0].ToString());
                    cmd.Parameters.AddWithValue("@Name", item[1].ToString());
                    cmd.Parameters.AddWithValue("@Price", item[2].ToString());
                    cmd.Parameters.AddWithValue("@Count", item[3].ToString());
                    cmd.Parameters.AddWithValue("@SumPrice", item[4].ToString());
                    cmd.Parameters.AddWithValue("@PS", item[5].ToString());

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        void 內用外帶計算機()
        {
            if (rad內用.Checked == true)
            {
                double 總價含服務費 = Math.Round(全部總價 * 1.1, 0);
                lbl開胃菜總價.Text = 總價含服務費.ToString();
                double 服務費 = Math.Round(全部總價 * 0.1, 0);
                lbl提醒.Text = String.Format("未含服務費:{0}元\n您的服務費:{1}元", 全部總價, 服務費);
            }
            else if (rad外帶.Checked == true)
            {
                lbl提醒.Text = "無須負擔服務費。\n";
                if(chk購物袋.Checked == true)
                {
                    int 買購物袋 = 全部總價 / 1000 + 1;
                    lbl開胃菜總價.Text = (全部總價 + 買購物袋).ToString();
                    lbl提醒.Text += String.Format("購買購物袋{0}元", 買購物袋);
                }
                else
                {
                    lbl開胃菜總價.Text = 全部總價.ToString();
                }
            }
        }
    }
}
