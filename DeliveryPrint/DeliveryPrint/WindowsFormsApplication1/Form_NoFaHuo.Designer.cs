namespace WindowsFormsApplication1
{
    partial class Form_NoFaHuo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NoFaHuo));
            this.button_renew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_nofahuo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_fahuo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_down = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_nodown = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_num = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_tid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_kddh = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_renew
            // 
            this.button_renew.Location = new System.Drawing.Point(206, 19);
            this.button_renew.Name = "button_renew";
            this.button_renew.Size = new System.Drawing.Size(84, 22);
            this.button_renew.TabIndex = 0;
            this.button_renew.Text = "刷新";
            this.button_renew.UseVisualStyleBackColor = true;
            this.button_renew.Click += new System.EventHandler(this.button_renew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(542, 200);
            this.dataGridView1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(284, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "下面刷新都是在此时间之后，请选择正确的时间";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_nofahuo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_fahuo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_down);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_nodown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_num);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数量统计";
            // 
            // label_nofahuo
            // 
            this.label_nofahuo.AutoSize = true;
            this.label_nofahuo.Location = new System.Drawing.Point(177, 90);
            this.label_nofahuo.Name = "label_nofahuo";
            this.label_nofahuo.Size = new System.Drawing.Size(11, 12);
            this.label_nofahuo.TabIndex = 8;
            this.label_nofahuo.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(11, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "已打印但没有点发货订单数：";
            // 
            // label_fahuo
            // 
            this.label_fahuo.AutoSize = true;
            this.label_fahuo.Location = new System.Drawing.Point(476, 55);
            this.label_fahuo.Name = "label_fahuo";
            this.label_fahuo.Size = new System.Drawing.Size(11, 12);
            this.label_fahuo.TabIndex = 6;
            this.label_fahuo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(314, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "打印并成功确认发货订单数：";
            // 
            // label_down
            // 
            this.label_down.AutoSize = true;
            this.label_down.Location = new System.Drawing.Point(272, 55);
            this.label_down.Name = "label_down";
            this.label_down.Size = new System.Drawing.Size(11, 12);
            this.label_down.TabIndex = 4;
            this.label_down.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(141, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "已下载打印中订单数：";
            // 
            // label_nodown
            // 
            this.label_nodown.AutoSize = true;
            this.label_nodown.Location = new System.Drawing.Point(106, 55);
            this.label_nodown.Name = "label_nodown";
            this.label_nodown.Size = new System.Drawing.Size(11, 12);
            this.label_nodown.TabIndex = 2;
            this.label_nodown.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "未下载订单数：";
            // 
            // button_num
            // 
            this.button_num.Location = new System.Drawing.Point(207, 21);
            this.button_num.Name = "button_num";
            this.button_num.Size = new System.Drawing.Size(75, 23);
            this.button_num.TabIndex = 0;
            this.button_num.Text = "刷新";
            this.button_num.UseVisualStyleBackColor = true;
            this.button_num.Click += new System.EventHandler(this.button_num_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button_renew);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 321);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已打印但未点发货订单检查";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "订单号：";
            // 
            // label_tid
            // 
            this.label_tid.AutoSize = true;
            this.label_tid.Location = new System.Drawing.Point(60, 14);
            this.label_tid.Name = "label_tid";
            this.label_tid.Size = new System.Drawing.Size(17, 12);
            this.label_tid.TabIndex = 3;
            this.label_tid.Text = "no";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "快递单号：";
            // 
            // label_kddh
            // 
            this.label_kddh.AutoSize = true;
            this.label_kddh.Location = new System.Drawing.Point(252, 14);
            this.label_kddh.Name = "label_kddh";
            this.label_kddh.Size = new System.Drawing.Size(17, 12);
            this.label_kddh.TabIndex = 5;
            this.label_kddh.Text = "no";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(441, 9);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 6;
            this.button_edit.Text = "确认修改";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_tid);
            this.panel1.Controls.Add(this.label_kddh);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(13, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 46);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(303, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // Form_NoFaHuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_NoFaHuo";
            this.Text = "团购未点发货订单汇总";
            this.Load += new System.EventHandler(this.Form_NoFaHuo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_renew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_num;
        private System.Windows.Forms.Label label_down;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_nodown;
        private System.Windows.Forms.Label label_fahuo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_nofahuo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_tid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_kddh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}