using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsForms訂購單
{
    public partial class homepage : Form
    {
        int 數量 = 1;
        int 總價 = 0;

        public homepage()
        {
            InitializeComponent();
        }

        private void homepage_Load(object sender, EventArgs e)
        {
            btn減少.Enabled = false;
        }
        private void btn增加_Click(object sender, EventArgs e)
        {
            數量++;
            btn減少.Enabled = true;
            lbl數量.Text = 數量.ToString();
        }

        private void btn減少_Click(object sender, EventArgs e)
        {
            數量--;
            lbl數量.Text = 數量.ToString();
            if (數量 == 1)
            {
                btn減少.Enabled = false;
            }
        }

        private void btn加入訂單_Click(object sender, EventArgs e)
        {
            總價 = 459 * 數量;
            int ID = 999;
            ArrayList 訂購特餐 = new ArrayList();
            訂購特餐.Add(ID);
            訂購特餐.Add("今日特餐");
            訂購特餐.Add(459);
            訂購特餐.Add(數量);
            訂購特餐.Add(總價);
            訂購特餐.Add("");

            GlobalVar.list訂購套餐.Add(訂購特餐);
            MessageBox.Show("訂購成功");

            lbl數量.Text = "1";
            數量 = 1;
        }
    }
}
