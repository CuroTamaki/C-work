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
    public partial class menu_drink : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnection = "";
        List<string> list飲料_無酒精 = new List<string>();
        List<int> list飲料_無酒精價格 = new List<int>();
        List<int> list無酒精ID = new List<int>();

        List<string> list飲料_含酒精 = new List<string>();
        List<int> list飲料_含酒精價格 = new List<int>();
        List<int> list含酒精ID = new List<int>();

        int 所選品項ID;
        string 所選品項;
        string 備註 = "";
        int 所選數量 = 1;
        int 所選品項總價;
        int 所選品項單價;

        string 冷熱="熱";
        string 順序="先上";

        public menu_drink()
        {
            InitializeComponent();
        }

        private void menu_drink_Load(object sender, EventArgs e)
        {
            rad_nor.Checked = true;
            btn減少.Enabled = false;

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Restaurant";
            scsb.IntegratedSecurity = true;
            strDBconnection = scsb.ToString();

            SqlConnection con1 = new SqlConnection(strDBconnection);
            con1.Open();
            string toSQL_無酒精飲料 = "select * from drinks where 類型='無酒精' and 供應中 =1;";
            SqlCommand cmd1 = new SqlCommand(toSQL_無酒精飲料, con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                int ID = Convert.ToInt32(reader1["ID"]);
                string 無酒精項目 = reader1["菜名"].ToString();
                int 無酒精價格 = Convert.ToInt32(reader1["價格"]);
                
                list無酒精ID.Add(ID);
                list飲料_無酒精.Add(無酒精項目);
                list飲料_無酒精價格.Add(無酒精價格);
            }reader1.Close(); con1.Close();
            無酒精呈現();

            SqlConnection con2 = new SqlConnection(strDBconnection);
            con2.Open();
            string toSQL_含酒精飲料 = "select * from drinks where 類型='含酒精' and 供應中 = 1;";
            SqlCommand cmd2 = new SqlCommand(toSQL_含酒精飲料, con2);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                string 含酒精項目 = reader2["菜名"].ToString();
                int 含酒精價格 = Convert.ToInt32(reader2["價格"]);
                int ID = Convert.ToInt32(reader2["ID"]);

                list含酒精ID.Add(ID);
                list飲料_含酒精.Add(含酒精項目);
                list飲料_含酒精價格.Add(含酒精價格);
            }
            reader2.Close(); con2.Close();

            btn加入訂單.Enabled = false;
            radbtn熱.Checked = true;
            rad先上.Checked = true;
        }


        void 無酒精呈現()
        {
            lbl飲料單價.Text = "";
            lbl飲料總價.Text = "";
            for (int i = 0; i < list飲料_無酒精.Count; i++)
            {
                string 無酒精飲料列表 = list飲料_無酒精[i] + " | " + list飲料_無酒精價格[i] + "元";
                
                listbox飲料.Items.Add(無酒精飲料列表);

            }
        }
        void 含酒精呈現()
        {
            lbl飲料單價.Text = "";
            lbl飲料總價.Text = "";
            for (int i = 0; i < list飲料_含酒精.Count; i++)
            {
                string 含酒精飲料列表 = list飲料_含酒精[i] + " | " + list飲料_含酒精價格[i] + "元";

                listbox飲料.Items.Add(含酒精飲料列表);
            }
        }


        private void listbox飲料_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox飲料.SelectedIndex > -1)
            {
                if (rad_nor.Checked == true)
                {
                    btn加入訂單.Enabled = true;
                    所選品項 = list飲料_無酒精[listbox飲料.SelectedIndex];
                    所選品項單價 = list飲料_無酒精價格[listbox飲料.SelectedIndex];
                    所選品項ID = list無酒精ID[listbox飲料.SelectedIndex];
                    if (listbox飲料.SelectedIndex > 17)
                    {
                        radbtn冷.Checked = true;
                        group冷熱.Enabled = false;
                    }
                    else
                    {
                        group冷熱.Enabled = true;
                    }
                    
                }
                else if (rad_alcohol.Checked == true)
                {
                    btn加入訂單.Enabled = true;
                    所選品項 = list飲料_含酒精[listbox飲料.SelectedIndex];
                    所選品項單價 = list飲料_含酒精價格[listbox飲料.SelectedIndex];
                    所選品項ID = list含酒精ID[listbox飲料.SelectedIndex];
                    radbtn冷.Checked = true;
                    group冷熱.Enabled = false;
                }
                lbl飲料單價.Text = 所選品項單價.ToString();
                計算總價();
            }
        }

        void 計算總價()
        {
            所選品項總價 = 所選品項單價 * 所選數量;
            lbl飲料總價.Text = 所選品項總價.ToString();
        }

        private void btn加入訂單_Click(object sender, EventArgs e)
        {
            確認冷熱();
            確認順序();
            備註 = " | "+冷熱 + " | " + 順序;

            ArrayList 訂購飲料 = new ArrayList();
            訂購飲料.Add(所選品項ID);
            訂購飲料.Add(所選品項);
            訂購飲料.Add(所選品項單價);
            訂購飲料.Add(所選數量);
            訂購飲料.Add(所選品項總價);
            訂購飲料.Add(備註);
            GlobalVar.list訂購飲料列表.Add(訂購飲料);
            MessageBox.Show("訂購成功");

            lbl數量.Text = "1";
            所選數量 = 1;

        }

        void 確認冷熱()
        {
            if (radbtn冷.Checked == true)
            {
                冷熱 = "冷";
            }else if(radbtn熱.Checked == true)
            {
                冷熱 = "熱";
            }
        }

        void 確認順序()
        {
            if (rad先上.Checked == true)
            {
                順序 = "先上";
            }
            else if (rad後上.Checked == true)
            {
                順序 = "後上";
            }
        }

        private void rad_nor_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_nor.Checked == true)
            {
                listbox飲料.Items.Clear();
                無酒精呈現();
            }
        }

        private void rad_alcohol_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_alcohol.Checked == true)
            {
                listbox飲料.Items.Clear();
                含酒精呈現();
            }
        }
        private void btn增加_Click(object sender, EventArgs e)
        {
            所選數量++;
            btn減少.Enabled = true;
            lbl數量.Text = 所選數量.ToString();
            計算總價();
        }

        private void btn減少_Click_1(object sender, EventArgs e)
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
