namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_主餐 = new System.Windows.Forms.Button();
            this.btn_排餐 = new System.Windows.Forms.Button();
            this.btn_開胃菜 = new System.Windows.Forms.Button();
            this.btn_甜點 = new System.Windows.Forms.Button();
            this.btn_飲料 = new System.Windows.Forms.Button();
            this.siderbar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCart = new System.Windows.Forms.Button();
            this.panelCart = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMember = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelHello = new System.Windows.Forms.Panel();
            this.siderbartimer = new System.Windows.Forms.Timer(this.components);
            this.sidermenutimer = new System.Windows.Forms.Timer(this.components);
            this.panelview = new System.Windows.Forms.Panel();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureboxBanner = new System.Windows.Forms.PictureBox();
            this.siderbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCart.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_主餐
            // 
            this.btn_主餐.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_主餐.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.btn_主餐.FlatAppearance.BorderSize = 0;
            this.btn_主餐.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_主餐.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_主餐.ForeColor = System.Drawing.Color.Transparent;
            this.btn_主餐.Location = new System.Drawing.Point(3, 110);
            this.btn_主餐.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_主餐.Name = "btn_主餐";
            this.btn_主餐.Size = new System.Drawing.Size(229, 45);
            this.btn_主餐.TabIndex = 2;
            this.btn_主餐.Text = "    主 餐";
            this.btn_主餐.UseVisualStyleBackColor = false;
            this.btn_主餐.Click += new System.EventHandler(this.btn_主餐_Click);
            // 
            // btn_排餐
            // 
            this.btn_排餐.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_排餐.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.btn_排餐.FlatAppearance.BorderSize = 0;
            this.btn_排餐.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_排餐.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_排餐.ForeColor = System.Drawing.Color.Transparent;
            this.btn_排餐.Location = new System.Drawing.Point(3, 159);
            this.btn_排餐.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_排餐.Name = "btn_排餐";
            this.btn_排餐.Size = new System.Drawing.Size(229, 45);
            this.btn_排餐.TabIndex = 2;
            this.btn_排餐.Text = "    排 餐";
            this.btn_排餐.UseVisualStyleBackColor = false;
            this.btn_排餐.Click += new System.EventHandler(this.btn_排餐_Click);
            // 
            // btn_開胃菜
            // 
            this.btn_開胃菜.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_開胃菜.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.btn_開胃菜.FlatAppearance.BorderSize = 0;
            this.btn_開胃菜.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_開胃菜.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_開胃菜.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_開胃菜.Location = new System.Drawing.Point(3, 68);
            this.btn_開胃菜.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_開胃菜.Name = "btn_開胃菜";
            this.btn_開胃菜.Size = new System.Drawing.Size(229, 38);
            this.btn_開胃菜.TabIndex = 2;
            this.btn_開胃菜.Text = "    開 胃 菜";
            this.btn_開胃菜.UseVisualStyleBackColor = false;
            this.btn_開胃菜.Click += new System.EventHandler(this.btn_開胃菜_Click);
            // 
            // btn_甜點
            // 
            this.btn_甜點.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_甜點.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.btn_甜點.FlatAppearance.BorderSize = 0;
            this.btn_甜點.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_甜點.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_甜點.ForeColor = System.Drawing.Color.Transparent;
            this.btn_甜點.Location = new System.Drawing.Point(3, 208);
            this.btn_甜點.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_甜點.Name = "btn_甜點";
            this.btn_甜點.Size = new System.Drawing.Size(229, 45);
            this.btn_甜點.TabIndex = 2;
            this.btn_甜點.Text = "    甜 點";
            this.btn_甜點.UseVisualStyleBackColor = false;
            this.btn_甜點.Click += new System.EventHandler(this.btn_甜點_Click);
            // 
            // btn_飲料
            // 
            this.btn_飲料.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_飲料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.btn_飲料.FlatAppearance.BorderSize = 0;
            this.btn_飲料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_飲料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_飲料.ForeColor = System.Drawing.Color.Transparent;
            this.btn_飲料.Location = new System.Drawing.Point(3, 257);
            this.btn_飲料.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_飲料.Name = "btn_飲料";
            this.btn_飲料.Size = new System.Drawing.Size(229, 45);
            this.btn_飲料.TabIndex = 2;
            this.btn_飲料.Text = "    飲 料";
            this.btn_飲料.UseVisualStyleBackColor = false;
            this.btn_飲料.Click += new System.EventHandler(this.btn_飲料_Click);
            // 
            // siderbar
            // 
            this.siderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.siderbar.Controls.Add(this.panel1);
            this.siderbar.Controls.Add(this.panelCart);
            this.siderbar.Controls.Add(this.btnSetting);
            this.siderbar.Controls.Add(this.flowLayoutPanel1);
            this.siderbar.Controls.Add(this.panelHome);
            this.siderbar.Controls.Add(this.panelHello);
            this.siderbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.siderbar.Location = new System.Drawing.Point(0, 0);
            this.siderbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siderbar.MaximumSize = new System.Drawing.Size(229, 730);
            this.siderbar.MinimumSize = new System.Drawing.Size(69, 730);
            this.siderbar.Name = "siderbar";
            this.siderbar.Size = new System.Drawing.Size(69, 730);
            this.siderbar.TabIndex = 6;
            this.siderbar.Click += new System.EventHandler(this.siderbar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 60);
            this.panel1.TabIndex = 9;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("新細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(151)))), ((int)(((byte)(75)))));
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(2, 0);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.btnCart.Size = new System.Drawing.Size(227, 60);
            this.btnCart.TabIndex = 8;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // panelCart
            // 
            this.panelCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.panelCart.Controls.Add(this.btnMenu);
            this.panelCart.Controls.Add(this.btn_開胃菜);
            this.panelCart.Controls.Add(this.btn_主餐);
            this.panelCart.Controls.Add(this.btn_排餐);
            this.panelCart.Controls.Add(this.btn_甜點);
            this.panelCart.Controls.Add(this.btn_飲料);
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCart.Location = new System.Drawing.Point(0, 204);
            this.panelCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCart.MaximumSize = new System.Drawing.Size(0, 305);
            this.panelCart.MinimumSize = new System.Drawing.Size(0, 60);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(69, 60);
            this.panelCart.TabIndex = 9;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("新細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(151)))), ((int)(((byte)(75)))));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(3, 2);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(229, 62);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("新細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(151)))), ((int)(((byte)(75)))));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 581);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(221, 58);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(46)))));
            this.flowLayoutPanel1.Controls.Add(this.btnMember);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 142);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(69, 62);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("新細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(151)))), ((int)(((byte)(75)))));
            this.btnMember.Image = ((System.Drawing.Image)(resources.GetObject("btnMember.Image")));
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(3, 2);
            this.btnMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(227, 60);
            this.btnMember.TabIndex = 8;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(46)))));
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 80);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(69, 62);
            this.panelHome.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("新細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(151)))), ((int)(((byte)(75)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(1, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(227, 60);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelHello
            // 
            this.panelHello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.panelHello.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHello.Location = new System.Drawing.Point(0, 0);
            this.panelHello.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHello.Name = "panelHello";
            this.panelHello.Size = new System.Drawing.Size(69, 80);
            this.panelHello.TabIndex = 9;
            this.panelHello.Click += new System.EventHandler(this.panelHello_Click);
            // 
            // siderbartimer
            // 
            this.siderbartimer.Interval = 1;
            this.siderbartimer.Tick += new System.EventHandler(this.siderbartimer_Tick);
            // 
            // sidermenutimer
            // 
            this.sidermenutimer.Interval = 1;
            this.sidermenutimer.Tick += new System.EventHandler(this.sidermenutimer_Tick);
            // 
            // panelview
            // 
            this.panelview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.panelview.Location = new System.Drawing.Point(69, 136);
            this.panelview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelview.Name = "panelview";
            this.panelview.Size = new System.Drawing.Size(1061, 545);
            this.panelview.TabIndex = 7;
            // 
            // panelBanner
            // 
            this.panelBanner.Controls.Add(this.lblTitle);
            this.panelBanner.Controls.Add(this.pictureboxBanner);
            this.panelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBanner.Location = new System.Drawing.Point(69, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(1059, 137);
            this.panelBanner.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTitle.Font = new System.Drawing.Font("Reem Kufi", 48F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, -17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1059, 154);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureboxBanner
            // 
            this.pictureboxBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureboxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxBanner.Image")));
            this.pictureboxBanner.Location = new System.Drawing.Point(0, 0);
            this.pictureboxBanner.Name = "pictureboxBanner";
            this.pictureboxBanner.Size = new System.Drawing.Size(1059, 137);
            this.pictureboxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxBanner.TabIndex = 0;
            this.pictureboxBanner.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1128, 641);
            this.Controls.Add(this.panelBanner);
            this.Controls.Add(this.siderbar);
            this.Controls.Add(this.panelview);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.siderbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCart.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_主餐;
        private System.Windows.Forms.Button btn_排餐;
        private System.Windows.Forms.Button btn_開胃菜;
        private System.Windows.Forms.Button btn_甜點;
        private System.Windows.Forms.Button btn_飲料;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Timer siderbartimer;
        private System.Windows.Forms.Timer sidermenutimer;
        private System.Windows.Forms.FlowLayoutPanel panelCart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Panel panelHello;
        private System.Windows.Forms.Panel siderbar;
        internal System.Windows.Forms.Panel panelview;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.PictureBox pictureboxBanner;
        private System.Windows.Forms.Label lblTitle;
    }
}

