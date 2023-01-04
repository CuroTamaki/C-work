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
    public partial class menu_appetizer : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnection = "";
        List<int> listID=new List<int>();
        List<string> list開胃菜 = new List<string>();
        List<int> list開胃菜價格 = new List<int>();

        string 所選品項;
        int 所選品項ID;
        string 備註="";
        int 所選價格;

        int 所選數量 = 1;
        int 所選品項總價;
        int 所選品項單價;

        public menu_appetizer()
        {
            InitializeComponent();
        }

        private void menu_appetizer_Load(object sender, EventArgs e)
        {
            btn減少.Enabled = false;
            btn加入訂單.Enabled = false;

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Restaurant";
            scsb.IntegratedSecurity = true;
            strDBconnection = scsb.ToString();

            SqlConnection con1 = new SqlConnection(strDBconnection);
            con1.Open();
            string toSQL_開胃菜 = "select * from appetizers where 供應中=1 order by 類型 DESC,價格;";
            SqlCommand cmd1 = new SqlCommand(toSQL_開胃菜, con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                int ID = Convert.ToInt32(reader1["ID"]);
                string 項目 = reader1["菜名"].ToString();
                int 價格 = Convert.ToInt32(reader1["價格"]);

                listID.Add(ID);
                list開胃菜.Add(項目);
                list開胃菜價格.Add(價格);
            }
            reader1.Close(); con1.Close();

            for (int i = 0; i < list開胃菜.Count; i++)
            {
                string 開胃菜列表 = list開胃菜[i] +" | "+ list開胃菜價格[i]+"元";
                listbox開胃菜.Items.Add(開胃菜列表);
            }

        }


        private void listbox開胃菜_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox開胃菜.SelectedIndex > -1)
            {
                btn加入訂單.Enabled = true;

                所選品項 = list開胃菜[listbox開胃菜.SelectedIndex];
                所選價格 = list開胃菜價格[listbox開胃菜.SelectedIndex];
                所選品項ID = listID[listbox開胃菜.SelectedIndex];
                lbl開胃菜單價.Text = String.Format("{0}", 所選價格);

                所選品項單價 = Convert.ToInt32(lbl開胃菜單價.Text);
                計算總價();
            }
        }

        void 計算總價()
        {
            if(lbl開胃菜單價.Text.Length > 0)
            {
                所選品項總價 = 所選數量 * 所選品項單價;
                lbl開胃菜總價.Text = string.Format("{0}", 所選品項總價);
            }
        }


        private void btn加入訂單_Click(object sender, EventArgs e)
        {

            ArrayList 訂購開胃菜 = new ArrayList();
            訂購開胃菜.Add(所選品項ID);
            訂購開胃菜.Add(所選品項);
            訂購開胃菜.Add(所選品項單價);
            訂購開胃菜.Add(所選數量);
            訂購開胃菜.Add(所選品項總價);
            訂購開胃菜.Add(備註);
            GlobalVar.list訂購開胃菜列表.Add(訂購開胃菜);
            MessageBox.Show("訂購成功");

            lbl數量.Text = "1";
            所選數量 = 1;
        }


        void 小蘭喜歡吃洋蔥()
        {
            if (listbox開胃菜.SelectedIndex==11 && 所選數量 == 520)
            {
                MessageBox.Show("小蘭最愛吃洋蔥");
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
