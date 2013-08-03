namespace WindowsFormsApplication1
{
    partial class Form_PrintAllOk
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PrintAllOk));
            this.button_renew = new System.Windows.Forms.Button();
            this.dataGridView_allprintok = new System.Windows.Forms.DataGridView();
            this.dataGridView_groupbyprint = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_hdname = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_huodongname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_caozuo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_maijia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_kddh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ordernum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allprintok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groupbyprint)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_renew
            // 
            this.button_renew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_renew.Location = new System.Drawing.Point(228, 128);
            this.button_renew.Name = "button_renew";
            this.button_renew.Size = new System.Drawing.Size(75, 30);
            this.button_renew.TabIndex = 0;
            this.button_renew.Text = "查询";
            this.button_renew.UseVisualStyleBackColor = false;
            this.button_renew.Click += new System.EventHandler(this.button_renew_Click);
            this.button_renew.MouseHover += new System.EventHandler(this.button_renew_MouseHover);
            // 
            // dataGridView_allprintok
            // 
            this.dataGridView_allprintok.AllowUserToAddRows = false;
            this.dataGridView_allprintok.AllowUserToDeleteRows = false;
            this.dataGridView_allprintok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_allprintok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_allprintok.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_allprintok.Name = "dataGridView_allprintok";
            this.dataGridView_allprintok.RowTemplate.Height = 23;
            this.dataGridView_allprintok.Size = new System.Drawing.Size(723, 421);
            this.dataGridView_allprintok.TabIndex = 1;
            // 
            // dataGridView_groupbyprint
            // 
            this.dataGridView_groupbyprint.AllowUserToAddRows = false;
            this.dataGridView_groupbyprint.AllowUserToDeleteRows = false;
            this.dataGridView_groupbyprint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_groupbyprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_groupbyprint.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_groupbyprint.Name = "dataGridView_groupbyprint";
            this.dataGridView_groupbyprint.RowTemplate.Height = 23;
            this.dataGridView_groupbyprint.Size = new System.Drawing.Size(397, 144);
            this.dataGridView_groupbyprint.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_hdname
            // 
            this.label_hdname.AutoSize = true;
            this.label_hdname.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_hdname.ForeColor = System.Drawing.Color.Green;
            this.label_hdname.Location = new System.Drawing.Point(12, 34);
            this.label_hdname.Name = "label_hdname";
            this.label_hdname.Size = new System.Drawing.Size(0, 20);
            this.label_hdname.TabIndex = 3;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(661, 615);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 4;
            this.button_next.Text = "下一页>>";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_groupbyprint);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打印汇总";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_allprintok);
            this.groupBox2.Location = new System.Drawing.Point(13, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 441);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细订单";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_reset);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_huodongname);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_caozuo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.textBox_maijia);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_kddh);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox_ordernum);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button_renew);
            this.groupBox3.Location = new System.Drawing.Point(431, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 164);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询与刷新";
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_reset.Location = new System.Drawing.Point(228, 99);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 15;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(13, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(166, 21);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.Value = new System.DateTime(2011, 9, 30, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "订单时间：";
            // 
            // textBox_huodongname
            // 
            this.textBox_huodongname.Location = new System.Drawing.Point(245, 68);
            this.textBox_huodongname.MaxLength = 200;
            this.textBox_huodongname.Name = "textBox_huodongname";
            this.textBox_huodongname.Size = new System.Drawing.Size(60, 21);
            this.textBox_huodongname.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "活动名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "操作员：";
            // 
            // textBox_caozuo
            // 
            this.textBox_caozuo.Location = new System.Drawing.Point(245, 12);
            this.textBox_caozuo.MaxLength = 200;
            this.textBox_caozuo.Name = "textBox_caozuo";
            this.textBox_caozuo.Size = new System.Drawing.Size(58, 21);
            this.textBox_caozuo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "打印时间:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 21);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2011, 11, 30, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox_maijia
            // 
            this.textBox_maijia.Location = new System.Drawing.Point(245, 40);
            this.textBox_maijia.MaxLength = 200;
            this.textBox_maijia.Name = "textBox_maijia";
            this.textBox_maijia.Size = new System.Drawing.Size(58, 21);
            this.textBox_maijia.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "买家ID：";
            // 
            // textBox_kddh
            // 
            this.textBox_kddh.Location = new System.Drawing.Point(79, 40);
            this.textBox_kddh.MaxLength = 200;
            this.textBox_kddh.Name = "textBox_kddh";
            this.textBox_kddh.Size = new System.Drawing.Size(100, 21);
            this.textBox_kddh.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "快递单号：";
            // 
            // textBox_ordernum
            // 
            this.textBox_ordernum.Location = new System.Drawing.Point(79, 12);
            this.textBox_ordernum.MaxLength = 200;
            this.textBox_ordernum.Name = "textBox_ordernum";
            this.textBox_ordernum.Size = new System.Drawing.Size(100, 21);
            this.textBox_ordernum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "订单号：";
            // 
            // Form_PrintAllOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 644);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_hdname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_PrintAllOk";
            this.Text = "查看订单";
            this.Load += new System.EventHandler(this.Form_PrintAllOk_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_PrintAllOk_FormClosing);
            this.Resize += new System.EventHandler(this.Form_PrintAllOk_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allprintok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groupbyprint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_renew;
        private System.Windows.Forms.DataGridView dataGridView_allprintok;
        private System.Windows.Forms.DataGridView dataGridView_groupbyprint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_hdname;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ordernum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kddh;
        private System.Windows.Forms.TextBox textBox_maijia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_caozuo;
        private System.Windows.Forms.TextBox textBox_huodongname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button_reset;
    }
}