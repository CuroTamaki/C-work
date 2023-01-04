namespace WindowsFormsApp2
{
    partial class OrderCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad外帶 = new System.Windows.Forms.RadioButton();
            this.rad內用 = new System.Windows.Forms.RadioButton();
            this.listBox訂購內容 = new System.Windows.Forms.ListBox();
            this.lbl提醒 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl開胃菜總價 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn刪除所選項目 = new System.Windows.Forms.Button();
            this.btn清空購物車 = new System.Windows.Forms.Button();
            this.chk購物袋 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_電話 = new System.Windows.Forms.TextBox();
            this.txt_訂購人 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(325, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 43);
            this.label3.TabIndex = 1;
            this.label3.Text = "購 物 餐 車";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(64, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "電話:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(61, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "訂購人:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad外帶);
            this.groupBox1.Controls.Add(this.rad內用);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.groupBox1.Location = new System.Drawing.Point(390, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "內/外";
            // 
            // rad外帶
            // 
            this.rad外帶.AutoSize = true;
            this.rad外帶.Location = new System.Drawing.Point(118, 42);
            this.rad外帶.Name = "rad外帶";
            this.rad外帶.Size = new System.Drawing.Size(80, 33);
            this.rad外帶.TabIndex = 0;
            this.rad外帶.TabStop = true;
            this.rad外帶.Text = "外帶";
            this.rad外帶.UseVisualStyleBackColor = true;
            this.rad外帶.CheckedChanged += new System.EventHandler(this.rad外帶_CheckedChanged);
            // 
            // rad內用
            // 
            this.rad內用.AutoSize = true;
            this.rad內用.Location = new System.Drawing.Point(21, 42);
            this.rad內用.Name = "rad內用";
            this.rad內用.Size = new System.Drawing.Size(80, 33);
            this.rad內用.TabIndex = 0;
            this.rad內用.TabStop = true;
            this.rad內用.Text = "內用";
            this.rad內用.UseVisualStyleBackColor = true;
            this.rad內用.CheckedChanged += new System.EventHandler(this.rad內用_CheckedChanged);
            // 
            // listBox訂購內容
            // 
            this.listBox訂購內容.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.listBox訂購內容.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購內容.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.listBox訂購內容.FormattingEnabled = true;
            this.listBox訂購內容.HorizontalScrollbar = true;
            this.listBox訂購內容.ItemHeight = 20;
            this.listBox訂購內容.Location = new System.Drawing.Point(87, 256);
            this.listBox訂購內容.Name = "listBox訂購內容";
            this.listBox訂購內容.Size = new System.Drawing.Size(459, 224);
            this.listBox訂購內容.TabIndex = 5;
            // 
            // lbl提醒
            // 
            this.lbl提醒.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl提醒.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl提醒.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.lbl提醒.Location = new System.Drawing.Point(636, 99);
            this.lbl提醒.Name = "lbl提醒";
            this.lbl提醒.Size = new System.Drawing.Size(287, 82);
            this.lbl提醒.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.label8.Location = new System.Drawing.Point(636, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 33);
            this.label8.TabIndex = 6;
            this.label8.Text = "小提醒:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(839, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 45);
            this.label7.TabIndex = 7;
            this.label7.Text = "元";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl開胃菜總價
            // 
            this.lbl開胃菜總價.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl開胃菜總價.Font = new System.Drawing.Font("微軟正黑體", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl開胃菜總價.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.lbl開胃菜總價.Location = new System.Drawing.Point(674, 246);
            this.lbl開胃菜總價.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl開胃菜總價.Name = "lbl開胃菜總價";
            this.lbl開胃菜總價.Size = new System.Drawing.Size(167, 45);
            this.lbl開胃菜總價.TabIndex = 8;
            this.lbl開胃菜總價.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.label9.Location = new System.Drawing.Point(809, 206);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 35);
            this.label9.TabIndex = 9;
            this.label9.Text = "總價";
            // 
            // btn刪除所選項目
            // 
            this.btn刪除所選項目.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.btn刪除所選項目.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除所選項目.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(121)))), ((int)(((byte)(41)))));
            this.btn刪除所選項目.Location = new System.Drawing.Point(565, 314);
            this.btn刪除所選項目.Name = "btn刪除所選項目";
            this.btn刪除所選項目.Size = new System.Drawing.Size(196, 70);
            this.btn刪除所選項目.TabIndex = 10;
            this.btn刪除所選項目.Text = "刪除所選項目";
            this.btn刪除所選項目.UseVisualStyleBackColor = false;
            this.btn刪除所選項目.Click += new System.EventHandler(this.btn刪除所選項目_Click);
            // 
            // btn清空購物車
            // 
            this.btn清空購物車.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.btn清空購物車.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空購物車.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(121)))), ((int)(((byte)(41)))));
            this.btn清空購物車.Location = new System.Drawing.Point(565, 398);
            this.btn清空購物車.Name = "btn清空購物車";
            this.btn清空購物車.Size = new System.Drawing.Size(196, 70);
            this.btn清空購物車.TabIndex = 10;
            this.btn清空購物車.Text = "清空購物車";
            this.btn清空購物車.UseVisualStyleBackColor = false;
            this.btn清空購物車.Click += new System.EventHandler(this.btn清空購物車_Click);
            // 
            // chk購物袋
            // 
            this.chk購物袋.AutoSize = true;
            this.chk購物袋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk購物袋.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.chk購物袋.Location = new System.Drawing.Point(414, 206);
            this.chk購物袋.Name = "chk購物袋";
            this.chk購物袋.Size = new System.Drawing.Size(134, 29);
            this.chk購物袋.TabIndex = 11;
            this.chk購物袋.Text = "購買購物袋";
            this.chk購物袋.UseVisualStyleBackColor = true;
            this.chk購物袋.CheckedChanged += new System.EventHandler(this.chk購物袋_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(121)))), ((int)(((byte)(41)))));
            this.button1.Location = new System.Drawing.Point(783, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 116);
            this.button1.TabIndex = 10;
            this.button1.Text = "送出訂單";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_電話
            // 
            this.txt_電話.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_電話.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_電話.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.txt_電話.Location = new System.Drawing.Point(140, 187);
            this.txt_電話.Margin = new System.Windows.Forms.Padding(2);
            this.txt_電話.Name = "txt_電話";
            this.txt_電話.Size = new System.Drawing.Size(198, 34);
            this.txt_電話.TabIndex = 12;
            // 
            // txt_訂購人
            // 
            this.txt_訂購人.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_訂購人.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_訂購人.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.txt_訂購人.Location = new System.Drawing.Point(163, 123);
            this.txt_訂購人.Margin = new System.Windows.Forms.Padding(2);
            this.txt_訂購人.Name = "txt_訂購人";
            this.txt_訂購人.Size = new System.Drawing.Size(198, 34);
            this.txt_訂購人.TabIndex = 13;
            // 
            // OrderCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(975, 503);
            this.Controls.Add(this.txt_電話);
            this.Controls.Add(this.txt_訂購人);
            this.Controls.Add(this.chk購物袋);
            this.Controls.Add(this.btn清空購物車);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn刪除所選項目);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl開胃菜總價);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl提醒);
            this.Controls.Add(this.listBox訂購內容);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "OrderCart";
            this.Text = "OrderCart";
            this.Load += new System.EventHandler(this.OrderCart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad外帶;
        private System.Windows.Forms.RadioButton rad內用;
        private System.Windows.Forms.Label lbl提醒;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl開胃菜總價;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn刪除所選項目;
        private System.Windows.Forms.Button btn清空購物車;
        private System.Windows.Forms.CheckBox chk購物袋;
        public System.Windows.Forms.ListBox listBox訂購內容;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_電話;
        private System.Windows.Forms.TextBox txt_訂購人;
    }
}