using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class menu_dish : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnection = "";
        List<string> list排餐_牛排 = new List<string>();
        List<int> list排餐_牛排價格 = new List<int>();
        List<int> list牛排ID = new List<int>();

        List<string> list熟度 = new List<string>();

        List<string> list排餐_其他 = new List<string>();
        List<int> list排餐_其他價格 = new List<int>();
        List<int> list其他ID = new List<int>();


        string 所選熟度;
        string 所選品項;
        int 所選品項ID;
        string 備註 = "";
        int 所選數量 = 1;
        int 所選品項總價;
        int 所選品項單價;

        public menu_dish()
        {
            InitializeComponent();
        }

        private void menu_dish_Load(object sender, EventArgs e)
        {
            btn減少.Enabled = false;
            radbtn牛肉.Checked = true;
            btn加入訂單.Enabled = false;

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Restaurant";
            scsb.IntegratedSecurity = true;
            strDBconnection = scsb.ToString();

            SqlConnection con1 = new SqlConnection(strDBconnection);
            con1.Open();
            string toSQL_牛肉 = "select * from dishes where 類型='牛肉' and 供應中=1 order by 價格;";
            SqlCommand cmd1 = new SqlCommand(toSQL_牛肉, con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                int ID = Convert.ToInt32(reader1["ID"]);
                string 項目 = reader1["菜名"].ToString();
                int 價格 = Convert.ToInt32(reader1["價格"]);

                list牛排ID.Add(ID);
                list排餐_牛排.Add(項目);
                list排餐_牛排價格.Add(價格);
            }
            reader1.Close(); con1.Close();

            SqlConnection con2 = new SqlConnection(strDBconnection);
            con2.Open();
            string toSQL_其他 = "select * from dishes where 類型!='牛肉' and 供應中=1 order by 價格;";
            SqlCommand cmd2 = new SqlCommand(toSQL_其他, con2);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                int ID = Convert.ToInt32(reader2["ID"]);
                string 項目 = reader2["菜名"].ToString();
                int 價格 = Convert.ToInt32(reader2["價格"]);

                list其他ID.Add(ID);
                list排餐_其他.Add(項目);
                list排餐_其他價格.Add(價格);

            }
            reader2.Close(); con2.Close();


            for (int i = 0; i < list排餐_牛排.Count; i++)
            {
                string 牛排列表 = list排餐_牛排[i] + "|" + list排餐_牛排價格[i] + "元";
                listbox排餐.Items.Add(牛排列表);
            }

            list熟度.Add("全熟");
            list熟度.Add("八分熟");
            list熟度.Add("半熟");
            list熟度.Add("三分熟");

            foreach(string 熟度 in list熟度)
            {
                combox熟度.Items.Add(熟度);
            }
            combox熟度.SelectedIndex = 0;

        }

        private void listbox排餐_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listbox排餐.SelectedIndex > -1)
            {
                btn加入訂單.Enabled = true;

                if (radbtn牛肉.Checked == true)
                {
                    所選品項 = list排餐_牛排[listbox排餐.SelectedIndex];
                    所選品項單價 = list排餐_牛排價格[listbox排餐.SelectedIndex];
                    所選品項ID = list牛排ID[listbox排餐.SelectedIndex];
                    lbl排餐單價.Text = 所選品項單價.ToString();
                }
                else if (radbtn其他.Checked == true)
                {
                    所選品項ID = list其他ID[listbox排餐.SelectedIndex];
                    所選品項 = list排餐_其他[listbox排餐.SelectedIndex];
                    所選品項單價 = list排餐_其他價格[listbox排餐.SelectedIndex];
                    lbl排餐單價.Text = 所選品項單價.ToString();
                    海老威武();
                }
            }
            計算總價();
        }

        void 計算總價()
        {
            所選品項總價 = 所選品項單價 * 所選數量 ;
            lbl排餐總價.Text = 所選品項總價.ToString();
        }

        void 清空()
        {
            listbox排餐.Items.Clear();
            lbl排餐單價.Text = "";
            lbl排餐總價.Text = "";
            btn加入訂單.Enabled = false;
        }


        private void radbtn牛肉_CheckedChanged(object sender, EventArgs e)
        {
            清空();
            combox熟度.Text = "全熟";
            備註 = "| "+combox熟度.Text;
            for (int i = 0; i < list排餐_牛排.Count; i++)
            {
                string 牛排列表 = list排餐_牛排[i] + "|" + list排餐_牛排價格[i] + "元";
                listbox排餐.Items.Add(牛排列表);
            }
            combox熟度.Enabled = true;

        }

        private void radbtn其他_CheckedChanged(object sender, EventArgs e)
        {
            清空();
            combox熟度.Text = "";
            備註 = combox熟度.Text;
            for (int i = 0; i < list排餐_其他.Count; i++)
            {
                string 其他列表 = list排餐_其他[i] + "|" + list排餐_其他價格[i] + "元";
                listbox排餐.Items.Add(其他列表);
            }
            combox熟度.Enabled = false;

        }

        private void combox熟度_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選熟度 = list熟度[combox熟度.SelectedIndex];
            備註 = "|" + 所選熟度;
        }

        private void btn加入訂單_Click(object sender, EventArgs e)
        {
            ArrayList 訂購排餐 = new ArrayList();
            訂購排餐.Add(所選品項ID);
            訂購排餐.Add(所選品項);
            訂購排餐.Add(所選品項單價);
            訂購排餐.Add(所選數量);
            訂購排餐.Add(所選品項總價);
            訂購排餐.Add(備註);
            GlobalVar.list訂購排餐列表.Add(訂購排餐);
            MessageBox.Show("訂購成功");

            lbl數量.Text = "1";
            所選數量 = 1;
        }

        void 海老威武()
        {
            if (listbox排餐.SelectedIndex == 4 && 所選數量 == 666 && radbtn其他.Checked==true)
            {
                MessageBox.Show("海老威武 千秋萬世");
            }
        }
        private void btn增加_Click(object sender, EventArgs e)
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
