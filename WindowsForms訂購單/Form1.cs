using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms訂購單;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        bool siderbarExpand;
        bool siderbarDetail=true;
        List<int> SearchIDs = new List<int>();
        Form actform;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSetting.Visible = false;
            homepage homepage = new homepage();
            actform = homepage;
            homepage.TopLevel = false;
            homepage.FormBorderStyle = FormBorderStyle.None;
            homepage.Dock = DockStyle.None;
            this.panelview.Controls.Add(homepage);
            this.panelview.Tag = homepage;
            homepage.BringToFront();
            homepage.Show();
            lblTitle.Parent=pictureboxBanner;
            lblTitle.BackColor = Color.Transparent;
            pictureboxBanner.Controls.Add(lblTitle);
        }

        internal void OpenFormInPanel(Form PanelLoad,object btnsender) 
        {
            if (actform != null)
            {
                actform.Close();
            }actform = PanelLoad;
            PanelLoad.TopLevel=false;
            PanelLoad.FormBorderStyle = FormBorderStyle.None;
            PanelLoad.Dock = DockStyle.Fill;
            this.panelview.Controls.Add(PanelLoad);
            this.panelview.Tag = PanelLoad;
            PanelLoad.BringToFront();
            PanelLoad.Show();
        }

        private void btn_開胃菜_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new menu_appetizer(), sender);
            lblTitle.Text = "Appetizer";
        }

        private void btn_主餐_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new menu_main(), sender);
            lblTitle.Text = "Staple Food";
        }

        private void btn_排餐_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new menu_dish(), sender);
            lblTitle.Text = "Main Dish";
        }
        private void btn_甜點_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new menu_dessert(), sender);
            lblTitle.Text = "Dessert";
        }

        private void btn_飲料_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new menu_drink(), sender);
            lblTitle.Text = "Drinks";
        }
        private void siderbartimer_Tick(object sender, EventArgs e)
        {
            if (siderbarExpand)
            {
                siderbar.Width += 30;
                if (siderbar.Width == siderbar.MaximumSize.Width)
                {
                    siderbartimer.Stop();
                    siderbarExpand = false;
                }
            }
            else
            {
                siderbar.Width -= 30;
                if (panelCart.Height != panelCart.MinimumSize.Height)
                {
                    panelCart.Height -= 30;
                }
                if (siderbar.Width == siderbar.MinimumSize.Width && panelCart.Height == panelCart.MinimumSize.Height)
                {
                    siderbartimer.Stop();
                    siderbarExpand=true;
                    siderbarDetail = true;
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidermenutimer.Start();
        }

        private void sidermenutimer_Tick(object sender, EventArgs e)
        {
            if (siderbarDetail==true)
            {
                panelCart.Height += 30;
                if(panelCart.Height == panelCart.MaximumSize.Height)
                {
                    sidermenutimer.Stop();
                    siderbarDetail=false;
                }
            }
            else if(panelCart.Height != panelCart.MinimumSize.Height)
            {
                panelCart.Height -= 30;
                if (panelCart.Height == panelCart.MinimumSize.Height)
                {
                    sidermenutimer.Stop();
                    siderbarDetail = true;
                }
            }
        }

        private void siderbar_Click(object sender, EventArgs e)
        {
            siderbartimer.Start();
            if (GlobalVar.權限 < 1000)
            {
                btnSetting.Visible= false;
            }
            else
            {
                btnSetting.Visible= true;
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new OrderCart(), sender);
            lblTitle.Text = "Shopping Cart";
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            if (GlobalVar.權限 == 0)
            {
                join_members join_Members = new join_members();
                join_Members.TopLevel = false;
                join_Members.FormBorderStyle = FormBorderStyle.None;
                join_Members.Dock = DockStyle.None;
                this.panelview.Controls.Add(join_Members);
                this.panelview.Tag = join_Members;
                join_Members.BringToFront();
                join_Members.能動的事件 += new join_members.deleToBackTemp(ControlLogOut);
                join_Members.Show();
                temp Temp = new temp();
                Temp.trigger1 += new temp.deleToManager(ControlManager);
                OpenFormInPanel(Temp, sender);
            }
            else
            {
                this.panelview.Controls.Clear();
                old_members old_Members = new old_members();
                old_Members.Logout += new old_members.deleToLogOut(ControlLogOut);
                OpenFormInPanel(old_Members, sender);
            }
            lblTitle.Text = "Members Only";
        }
        void ControlManager()
        {
            if (GlobalVar.權限 > 999)
            {
                btnSetting.Visible = true;
            }
            else if(GlobalVar.權限<1000)
            {
                btnSetting.Visible = false;
            }
            this.panelview.Controls.Clear();
            old_members old_Members = new old_members();
            old_Members.TopLevel = false;
            old_Members.FormBorderStyle = FormBorderStyle.None;
            old_Members.Dock = DockStyle.None;
            this.panelview.Controls.Add(old_Members);
            this.panelview.Tag = old_Members;
            old_Members.BringToFront();
            old_Members.Show();
        }

        void ControlLogOut()
        {
            this.panelview.Controls.Clear();
            temp Temp = new temp();
            Temp.TopLevel = false;
            Temp.FormBorderStyle = FormBorderStyle.None;
            Temp.Dock = DockStyle.None;
            this.panelview.Controls.Add(Temp);
            this.panelview.Tag = Temp;
            Temp.BringToFront();
            Temp.Show();
            if (GlobalVar.權限 < 1000)
            {
                btnSetting.Visible = false;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new manager(), sender);
            lblTitle.Text = "Setting";
        }

        private void panelHello_Click(object sender, EventArgs e)
        {
            siderbartimer.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.panelview.Controls.Clear();
            OpenFormInPanel(new homepage(), sender);
            lblTitle.Text = "Home";
        }
    }
}
