namespace WindowsFormsApp2
{
    partial class menu_drink
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
            this.btn加入訂單 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl飲料總價 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl飲料單價 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listbox飲料 = new System.Windows.Forms.ListBox();
            this.group冷熱 = new System.Windows.Forms.GroupBox();
            this.radbtn冷 = new System.Windows.Forms.RadioButton();
            this.radbtn熱 = new System.Windows.Forms.RadioButton();
            this.group順序 = new System.Windows.Forms.GroupBox();
            this.rad後上 = new System.Windows.Forms.RadioButton();
            this.rad先上 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_alcohol = new System.Windows.Forms.RadioButton();
            this.rad_nor = new System.Windows.Forms.RadioButton();
            this.btn減少 = new System.Windows.Forms.Button();
            this.btn增加 = new System.Windows.Forms.Button();
            this.lbl數量 = new System.Windows.Forms.Label();
            this.group冷熱.SuspendLayout();
            this.group順序.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn加入訂單
            // 
            this.btn加入訂單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.btn加入訂單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入訂單.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(121)))), ((int)(((byte)(41)))));
            this.btn加入訂單.Location = new System.Drawing.Point(744, 396);
            this.btn加入訂單.Margin = new System.Windows.Forms.Padding(2);
            this.btn加入訂單.Name = "btn加入訂單";
            this.btn加入訂單.Size = new System.Drawing.Size(185, 69);
            this.btn加入訂單.TabIndex = 28;
            this.btn加入訂單.Text = "加入訂單";
            this.btn加入訂單.UseVisualStyleBackColor = false;
            this.btn加入訂單.Click += new System.EventHandler(this.btn加入訂單_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.label6.Location = new System.Drawing.Point(864, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 45);
            this.label6.TabIndex = 20;
            this.label6.Text = "元";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl飲料總價
            // 
            this.lbl飲料總價.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl飲料總價.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl飲料總價.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.lbl飲料總價.Location = new System.Drawing.Point(738, 296);
            this.lbl飲料總價.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl飲料總價.Name = "lbl飲料總價";
            this.lbl飲料總價.Size = new System.Drawing.Size(134, 45);
            this.lbl飲料總價.TabIndex = 21;
            this.lbl飲料總價.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(837, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "總價";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.label4.Location = new System.Drawing.Point(639, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 45);
            this.label4.TabIndex = 23;
            this.label4.Text = "元";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl飲料單價
            // 
            this.lbl飲料單價.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl飲料單價.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl飲料單價.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.lbl飲料單價.Location = new System.Drawing.Point(508, 296);
            this.lbl飲料單價.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl飲料單價.Name = "lbl飲料單價";
            this.lbl飲料單價.Size = new System.Drawing.Size(135, 45);
            this.lbl飲料單價.TabIndex = 24;
            this.lbl飲料單價.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(553, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "單品價格";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(857, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "數量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(114, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 43);
            this.label3.TabIndex = 18;
            this.label3.Text = "飲料";
            // 
            // listbox飲料
            // 
            this.listbox飲料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.listbox飲料.Font = new System.Drawing.Font("微軟正黑體", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listbox飲料.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.listbox飲料.FormattingEnabled = true;
            this.listbox飲料.ItemHeight = 31;
            this.listbox飲料.Location = new System.Drawing.Point(112, 127);
            this.listbox飲料.Margin = new System.Windows.Forms.Padding(2);
            this.listbox飲料.Name = "listbox飲料";
            this.listbox飲料.Size = new System.Drawing.Size(341, 314);
            this.listbox飲料.TabIndex = 17;
            this.listbox飲料.SelectedIndexChanged += new System.EventHandler(this.listbox飲料_SelectedIndexChanged);
            // 
            // group冷熱
            // 
            this.group冷熱.Controls.Add(this.radbtn冷);
            this.group冷熱.Controls.Add(this.radbtn熱);
            this.group冷熱.Font = new System.Drawing.Font("微軟正黑體", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.group冷熱.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.group冷熱.Location = new System.Drawing.Point(510, 379);
            this.group冷熱.Margin = new System.Windows.Forms.Padding(2);
            this.group冷熱.Name = "group冷熱";
            this.group冷熱.Padding = new System.Windows.Forms.Padding(2);
            this.group冷熱.Size = new System.Drawing.Size(185, 86);
            this.group冷熱.TabIndex = 29;
            this.group冷熱.TabStop = false;
            this.group冷熱.Text = "冷/熱";
            // 
            // radbtn冷
            // 
            this.radbtn冷.AutoSize = true;
            this.radbtn冷.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radbtn冷.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(106)))), ((int)(((byte)(92)))));
            this.radbtn冷.Location = new System.Drawing.Point(95, 44);
            this.radbtn冷.Margin = new System.Windows.Forms.Padding(2);
            this.radbtn冷.Name = "radbtn冷";
            this.radbtn冷.Size = new System.Drawing.Size(53, 29);
            this.radbtn冷.TabIndex = 0;
            this.radbtn冷.TabStop = true;
            this.radbtn冷.Text = "冷";
            this.radbtn冷.UseVisualStyleBackColor = true;
            // 
            // radbtn熱
            // 
            this.radbtn熱.AutoSize = true;
            this.radbtn熱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radbtn熱.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(106)))), ((int)(((byte)(92)))));
            this.radbtn熱.Location = new System.Drawing.Point(11, 44);
            this.radbtn熱.Margin = new System.Windows.Forms.Padding(2);
            this.radbtn熱.Name = "radbtn熱";
            this.radbtn熱.Size = new System.Drawing.Size(53, 29);
            this.radbtn熱.TabIndex = 0;
            this.radbtn熱.TabStop = true;
            this.radbtn熱.Text = "熱";
            this.radbtn熱.UseVisualStyleBackColor = true;
            // 
            // group順序
            // 
            this.group順序.Controls.Add(this.rad後上);
            this.group順序.Controls.Add(this.rad先上);
            this.group順序.Font = new System.Drawing.Font("微軟正黑體", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.group順序.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.group順序.Location = new System.Drawing.Point(741, 59);
            this.group順序.Margin = new System.Windows.Forms.Padding(2);
            this.group順序.Name = "group順序";
            this.group順序.Padding = new System.Windows.Forms.Padding(2);
            this.group順序.Size = new System.Drawing.Size(185, 86);
            this.group順序.TabIndex = 29;
            this.group順序.TabStop = false;
            this.group順序.Text = "順序";
            // 
            // rad後上
            // 
            this.rad後上.AutoSize = true;
            this.rad後上.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rad後上.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(106)))), ((int)(((byte)(92)))));
            this.rad後上.Location = new System.Drawing.Point(95, 44);
            this.rad後上.Margin = new System.Windows.Forms.Padding(2);
            this.rad後上.Name = "rad後上";
            this.rad後上.Size = new System.Drawing.Size(73, 29);
            this.rad後上.TabIndex = 0;
            this.rad後上.TabStop = true;
            this.rad後上.Text = "後上";
            this.rad後上.UseVisualStyleBackColor = true;
            // 
            // rad先上
            // 
            this.rad先上.AutoSize = true;
            this.rad先上.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rad先上.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(106)))), ((int)(((byte)(92)))));
            this.rad先上.Location = new System.Drawing.Point(11, 44);
            this.rad先上.Margin = new System.Windows.Forms.Padding(2);
            this.rad先上.Name = "rad先上";
            this.rad先上.Size = new System.Drawing.Size(73, 29);
            this.rad先上.TabIndex = 0;
            this.rad先上.TabStop = true;
            this.rad先上.Text = "先上";
            this.rad先上.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_alcohol);
            this.groupBox1.Controls.Add(this.rad_nor);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.groupBox1.Location = new System.Drawing.Point(499, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(186, 154);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "酒精";
            // 
            // rad_alcohol
            // 
            this.rad_alcohol.AutoSize = true;
            this.rad_alcohol.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rad_alcohol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(106)))), ((int)(((byte)(92)))));
            this.rad_alcohol.Location = new System.Drawing.Point(11, 104);
            this.rad_alcohol.Margin = new System.Windows.Forms.Padding(2);
            this.rad_alcohol.Name = "rad_alcohol";
            this.rad_alcohol.Size = new System.Drawing.Size(93, 29);
            this.rad_alcohol.TabIndex = 0;
            this.rad_alcohol.TabStop = true;
            this.rad_alcohol.Text = "含酒精";
            this.rad_alcohol.UseVisualStyleBackColor = true;
            this.rad_alcohol.CheckedChanged += new System.EventHandler(this.rad_alcohol_CheckedChanged);
            // 
            // rad_nor
            // 
            this.rad_nor.AutoSize = true;
            this.rad_nor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rad_nor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(106)))), ((int)(((byte)(92)))));
            this.rad_nor.Location = new System.Drawing.Point(11, 44);
            this.rad_nor.Margin = new System.Windows.Forms.Padding(2);
            this.rad_nor.Name = "rad_nor";
            this.rad_nor.Size = new System.Drawing.Size(113, 29);
            this.rad_nor.TabIndex = 0;
            this.rad_nor.TabStop = true;
            this.rad_nor.Text = "不含酒精";
            this.rad_nor.UseVisualStyleBackColor = true;
            this.rad_nor.CheckedChanged += new System.EventHandler(this.rad_nor_CheckedChanged);
            // 
            // btn減少
            // 
            this.btn減少.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btn減少.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn減少.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn減少.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn減少.Location = new System.Drawing.Point(721, 204);
            this.btn減少.Name = "btn減少";
            this.btn減少.Size = new System.Drawing.Size(44, 35);
            this.btn減少.TabIndex = 40;
            this.btn減少.Text = "-";
            this.btn減少.UseVisualStyleBackColor = false;
            this.btn減少.Click += new System.EventHandler(this.btn減少_Click_1);
            // 
            // btn增加
            // 
            this.btn增加.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btn增加.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn增加.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn增加.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn增加.Location = new System.Drawing.Point(886, 204);
            this.btn增加.Name = "btn增加";
            this.btn增加.Size = new System.Drawing.Size(44, 35);
            this.btn增加.TabIndex = 41;
            this.btn增加.Text = "+";
            this.btn增加.UseVisualStyleBackColor = false;
            this.btn增加.Click += new System.EventHandler(this.btn增加_Click);
            // 
            // lbl數量
            // 
            this.lbl數量.BackColor = System.Drawing.Color.White;
            this.lbl數量.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl數量.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.lbl數量.Location = new System.Drawing.Point(774, 204);
            this.lbl數量.Name = "lbl數量";
            this.lbl數量.Size = new System.Drawing.Size(101, 34);
            this.lbl數量.TabIndex = 39;
            this.lbl數量.Text = "1";
            this.lbl數量.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menu_drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(993, 522);
            this.Controls.Add(this.btn減少);
            this.Controls.Add(this.btn增加);
            this.Controls.Add(this.lbl數量);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group順序);
            this.Controls.Add(this.group冷熱);
            this.Controls.Add(this.btn加入訂單);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl飲料總價);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl飲料單價);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listbox飲料);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "menu_drink";
            this.Text = "menu_drink";
            this.Load += new System.EventHandler(this.menu_drink_Load);
            this.group冷熱.ResumeLayout(false);
            this.group冷熱.PerformLayout();
            this.group順序.ResumeLayout(false);
            this.group順序.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn加入訂單;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl飲料總價;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl飲料單價;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbox飲料;
        private System.Windows.Forms.GroupBox group冷熱;
        private System.Windows.Forms.RadioButton radbtn冷;
        private System.Windows.Forms.RadioButton radbtn熱;
        private System.Windows.Forms.GroupBox group順序;
        private System.Windows.Forms.RadioButton rad後上;
        private System.Windows.Forms.RadioButton rad先上;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_alcohol;
        private System.Windows.Forms.RadioButton rad_nor;
        private System.Windows.Forms.Button btn減少;
        private System.Windows.Forms.Button btn增加;
        private System.Windows.Forms.Label lbl數量;
    }
}