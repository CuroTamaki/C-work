using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class menu_main : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnection = "";
        List<string> list主餐_醬料 = new List<string>();
        List<string> list主餐_配料 = new List<string>();
        List<string> list主餐_主食 = new List<string>();
        List<int> list主餐_醬料價格= new List<int>();
        List<int> list主餐_配料價格 = new List<int>();
        List<int> list主餐_主食價格 = new List<int>();
        List<string> list主餐組合 = new List<string> { "", "", "" };

        int 醬料價格;
        int 配料價格;
        int 主食價格;
        int 所選數量=1;
        int 所選主餐單價;
        int 所選總價;

        int 起司=0;
        int 雙倍起司=0;
        int 焗烤=0;
        int 主食加量=0;
        int 明太子=0;
        string 備註 = "";

        public menu_main()
        {
            InitializeComponent();
        }

        private void menu_main_Load(object sender, EventArgs e)
        {

            btn加入訂單.Enabled = false;
            btn減少.Enabled = false;

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Restaurant";
            scsb.IntegratedSecurity = true;
            strDBconnection = scsb.ToString();

            SqlConnection con1 = new SqlConnection(strDBconnection);
            con1.Open();
            string toSQL_醬料 = "select * from mains where 類型='醬料' and 供應中=1;";
            SqlCommand cmd1 = new SqlCommand(toSQL_醬料, con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                string 醬料項目 = reader1["菜名"].ToString();
                int 醬料價格 = Convert.ToInt32(reader1["價格"]);

                list主餐_醬料.Add(醬料項目);
                list主餐_醬料價格.Add(醬料價格);
            }
            reader1.Close();
            con1.Close();

            SqlConnection con2 = new SqlConnection(strDBconnection);
            con2.Open();
            string toSQL_主食 = "select * from mains where 類型='主食' and 供應中=1;";
            SqlCommand cmd2 = new SqlCommand(toSQL_主食, con2);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                string 主食項目 = reader2["菜名"].ToString();
                int 主食價格 = Convert.ToInt32(reader2["價格"]);

                list主餐_主食.Add(主食項目);
                list主餐_主食價格.Add(主食價格);
            }reader2.Close();con2.Close();

            SqlConnection con3 = new SqlConnection(strDBconnection);
            con3.Open();
            string toSQL_配料 = "select * from mains where 類型='配料' and 供應中=1;";
            SqlCommand cmd3 = new SqlCommand(toSQL_配料, con3);
            SqlDataReader reader3 = cmd3.ExecuteReader();

            while (reader3.Read())
            {
                string 配料項目 = reader3["菜名"].ToString();
                int 配料價格 = Convert.ToInt32(reader3["價格"]);

                list主餐_配料.Add(配料項目);
                list主餐_配料價格.Add(配料價格);
            }
            reader2.Close(); con2.Close();

            for (int i = 0; i < list主餐_醬料.Count; i++)
            {
                string 醬料列表 = list主餐_醬料[i];
                listbox調味醬.Items.Add(醬料列表);
            }

            for (int i = 0; i < list主餐_配料.Count; i++)
            {
                string 配料列表 = list主餐_配料[i];
                listBox配料.Items.Add(配料列表);
            }

            for (int i = 0; i < list主餐_主食.Count; i++)
            {
                string 主食列表 = list主餐_主食[i];
                listBox主食.Items.Add(主食列表);
            }

        }
        private void listbox調味醬_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox調味醬.SelectedIndex > -1)
            {
                list主餐組合[0]=list主餐_醬料[listbox調味醬.SelectedIndex];
                醬料價格 = list主餐_醬料價格[listbox調味醬.SelectedIndex];
                lbl主餐單價.Text = 所選主餐單價.ToString();
            }
            lbl拼圖主餐.Text = string.Join("", list主餐組合);
            下定單按鈕通行();
            計算總價();
        }
        private void listBox配料_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox配料.SelectedIndex > -1)
            {
                list主餐組合[1] = list主餐_配料[listBox配料.SelectedIndex];
                配料價格 = list主餐_配料價格[listBox配料.SelectedIndex];
                lbl主餐單價.Text = 所選主餐單價.ToString();
            }
            lbl拼圖主餐.Text = string.Join("", list主餐組合);
            下定單按鈕通行();
            計算總價();
        }

        private void listBox主食_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox主食.SelectedIndex > -1)
            {
                list主餐組合[2] = list主餐_主食[listBox主食.SelectedIndex];
                主食價格 = list主餐_主食價格[listBox主食.SelectedIndex];
                lbl主餐單價.Text = 所選主餐單價.ToString();
            }
            lbl拼圖主餐.Text = string.Join("", list主餐組合);
            下定單按鈕通行();
            計算總價();
        }


        void 計算總價()
        {
            所選主餐單價 = 300 + 醬料價格 + 配料價格 + 主食價格 + (起司 + 雙倍起司 + 焗烤 + 主食加量 + 明太子); 
            所選總價 = 所選主餐單價 * 所選數量 ;
            lbl主餐單價.Text = 所選主餐單價.ToString();
            lbl主餐總價.Text = 所選總價.ToString();
        }

        private void btn加入訂單_Click(object sender, EventArgs e)
        {
            int ID=0;
            ArrayList 訂購主餐 = new ArrayList();
            訂購主餐.Add(ID);
            訂購主餐.Add(lbl拼圖主餐.Text);
            訂購主餐.Add(所選主餐單價);
            訂購主餐.Add(所選數量);
            訂購主餐.Add(所選總價);
            訂購主餐.Add(備註);

            GlobalVar.list訂購主餐列表.Add(訂購主餐);
            MessageBox.Show("訂購成功");

            lbl數量.Text = "1";
            所選數量 = 1;

        }

        private void btn結束_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk起司_CheckedChanged(object sender, EventArgs e)
        {
            if (chk起司.Checked==true)
            {
                起司 = 30;
                計算總價();
                備註 += "| 起司 ";
            }
            else if(chk起司.Checked == false)
            {
                起司 = 0;
                計算總價();
            }
            
        }

        private void chk雙倍起司_CheckedChanged(object sender, EventArgs e)
        {
            if (chk雙倍起司.Checked == true)
            {
                雙倍起司 = 50;
                計算總價();
                備註 += "| 雙倍起司 ";
            }
            else if (chk雙倍起司.Checked == false)
            {
                雙倍起司 = 0;
                計算總價();
            }
        }

        private void chk焗烤_CheckedChanged(object sender, EventArgs e)
        {
            if (chk焗烤.Checked == true)
            {
                焗烤 = 40;
                計算總價();
                備註 += "| 焗烤 ";
            }
            else if (chk焗烤.Checked == false)
            {
                焗烤 = 0;
                計算總價();
            }
        }

        private void chk主食加量_CheckedChanged(object sender, EventArgs e)
        {
            if (chk主食加量.Checked == true)
            {
                主食加量 = 20;
                計算總價();
                備註 += "| 主食加量 ";
            }
            else if (chk主食加量.Checked == false)
            {
                主食加量 = 0;
                計算總價();
            }
        }

        private void chk明太子_CheckedChanged(object sender, EventArgs e)
        {
            if (chk明太子.Checked == true)
            {
                明太子 = 120;
                計算總價();
                備註 += "| 明太子 ";
            }
            else if (chk明太子.Checked == false)
            {
                明太子 = 0;
                計算總價();
            }
        }

        private void chk不要洋蔥_CheckedChanged(object sender, EventArgs e)
        {
            if (chk不要洋蔥.Checked == true)
            {
                備註 += "| 不要洋蔥 ";
            }
        }

        void 下定單按鈕通行()
        {
            if (listBox主食.SelectedIndex != -1 && listbox調味醬.SelectedIndex != -1 && listBox配料.SelectedIndex != -1)
            {
                btn加入訂單.Enabled = true;
            }
        }

        void 晶晶喜歡吃香菇()
        {
            if(lbl拼圖主餐.Text.Contains("野菇")==true && 所選數量 == 520)
            {
                MessageBox.Show("晶晶最愛吃香菇");
            }
        }

        private void btn增加_Click_1(object sender, EventArgs e)
        {
            所選數量++;
            btn減少.Enabled = true;
            lbl數量.Text = 所選數量.ToString();
            計算總價();
        }

        private void btn減少_Click(object sender, EventArgs e)
        {
            所選數量--;
            lbl數量.Text = 所選數量.ToString();
            if (所選數量 == 1)
            {
                btn減少.Enabled = false;
            }
            計算總價();
        }
    }
}
