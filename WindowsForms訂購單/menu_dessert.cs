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
    public partial class menu_dessert : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnection = "";
        List<string> list甜點 = new List<string>();
        List<int> list甜點價格 = new List<int>();
        List<int> listID = new List<int>();

        string 所選品項;
        int 所選品項ID;
        string 備註 = "";
        int 所選數量 = 1;
        int 所選品項總價;
        int 所選品項單價;

        public menu_dessert()
        {
            InitializeComponent();
        }

        private void menu_dessert_Load(object sender, EventArgs e)
        {
            btn減少.Enabled = false;

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Restaurant";
            scsb.IntegratedSecurity = true;
            strDBconnection = scsb.ToString();

            SqlConnection con1 = new SqlConnection(strDBconnection);
            con1.Open();
            string toSQL_甜點 = "select * from desserts where 供應中=1 order by 類型,價格;";
            SqlCommand cmd1 = new SqlCommand(toSQL_甜點, con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                int ID = Convert.ToInt32(reader1["ID"]);
                string 項目 = reader1["菜名"].ToString();
                int 價格 = Convert.ToInt32(reader1["價格"]);

                listID.Add(ID);
                list甜點.Add(項目);
                list甜點價格.Add(價格);

            }
            reader1.Close(); con1.Close();


            for (int i = 0; i < list甜點.Count; i++)
            {
                string 甜點列表 = list甜點[i] + " | " + list甜點價格[i]+"元";
                listbox甜點.Items.Add(甜點列表);
            }
            btn加入訂單.Enabled = false;
            
        }

        private void listbox甜點_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox甜點.SelectedIndex > -1)
            {
                btn加入訂單.Enabled = true;
                所選品項 = list甜點[listbox甜點.SelectedIndex];
                所選品項單價 = list甜點價格[listbox甜點.SelectedIndex];
                所選品項ID = listID[listbox甜點.SelectedIndex];
                lbl甜點單價.Text = 所選品項單價.ToString();
            }
            計算總價();
        }


        void 計算總價()
        {
            所選品項總價 = 所選品項單價 * 所選數量;
            lbl甜點總價.Text=所選品項總價.ToString();
        }

        private void btn加入訂單_Click(object sender, EventArgs e)
        {
            ArrayList 訂購甜點 = new ArrayList();
            訂購甜點.Add(所選品項ID);
            訂購甜點.Add(所選品項);
            訂購甜點.Add(所選品項單價);
            訂購甜點.Add(所選數量);
            訂購甜點.Add(所選品項總價);
            訂購甜點.Add(備註);

            GlobalVar.list訂購甜點列表.Add(訂購甜點);
            MessageBox.Show("訂購成功");

            lbl數量.Text = "1";
            所選數量 = 1;
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
