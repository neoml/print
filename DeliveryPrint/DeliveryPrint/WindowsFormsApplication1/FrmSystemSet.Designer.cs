namespace WindowsFormsApplication1
{
    partial class FrmSystemSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSystemSet));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPSystemSet = new System.Windows.Forms.TabPage();
            this.txtPrintName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbShopSource = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tPSystemSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPSystemSet);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(307, 252);
            this.tabControl1.TabIndex = 0;
            // 
            // tPSystemSet
            // 
            this.tPSystemSet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tPSystemSet.Controls.Add(this.txtPrintName);
            this.tPSystemSet.Controls.Add(this.label4);
            this.tPSystemSet.Controls.Add(this.cmbShopSource);
            this.tPSystemSet.Controls.Add(this.label3);
            this.tPSystemSet.Controls.Add(this.label2);
            this.tPSystemSet.Controls.Add(this.txtFormat);
            this.tPSystemSet.Controls.Add(this.txtServiceName);
            this.tPSystemSet.Controls.Add(this.label1);
            this.tPSystemSet.Controls.Add(this.btnCancel);
            this.tPSystemSet.Controls.Add(this.btnSave);
            this.tPSystemSet.Controls.Add(this.txtPath);
            this.tPSystemSet.Controls.Add(this.lblPath);
            this.tPSystemSet.Location = new System.Drawing.Point(4, 21);
            this.tPSystemSet.Name = "tPSystemSet";
            this.tPSystemSet.Padding = new System.Windows.Forms.Padding(3);
            this.tPSystemSet.Size = new System.Drawing.Size(299, 227);
            this.tPSystemSet.TabIndex = 0;
            this.tPSystemSet.Text = "系统设置";
            // 
            // txtPrintName
            // 
            this.txtPrintName.Location = new System.Drawing.Point(112, 159);
            this.txtPrintName.Name = "txtPrintName";
            this.txtPrintName.Size = new System.Drawing.Size(167, 21);
            this.txtPrintName.TabIndex = 15;
            this.txtPrintName.Text = "Microsoft XPS Document Writer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "清单打印机名字";
            // 
            // cmbShopSource
            // 
            this.cmbShopSource.FormattingEnabled = true;
            this.cmbShopSource.Items.AddRange(new object[] {
            "国产",
            "进口",
            "全部"});
            this.cmbShopSource.Location = new System.Drawing.Point(113, 125);
            this.cmbShopSource.Name = "cmbShopSource";
            this.cmbShopSource.Size = new System.Drawing.Size(166, 20);
            this.cmbShopSource.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "货的来源";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "打印格式";
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(113, 89);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(166, 21);
            this.txtFormat.TabIndex = 10;
            this.txtFormat.Text = "2";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(113, 49);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(166, 21);
            this.txtServiceName.TabIndex = 9;
            this.txtServiceName.Text = "Microsoft XPS Document Writer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "面单打印机名字";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(168, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(64, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(112, 17);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(167, 21);
            this.txtPath.TabIndex = 5;
            this.txtPath.Text = "192.168.2.100/daying";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(14, 20);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(65, 12);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "服务器路径";
            // 
            // FrmSystemSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(310, 256);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSystemSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统设置";
            this.Load += new System.EventHandler(this.FrmSystemSet_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSystemSet_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tPSystemSet.ResumeLayout(false);
            this.tPSystemSet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPSystemSet;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbShopSource;
        private System.Windows.Forms.TextBox txtPrintName;
        private System.Windows.Forms.Label label4;

    }
}