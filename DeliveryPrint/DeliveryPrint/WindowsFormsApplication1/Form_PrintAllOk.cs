using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.DeliveryPrintService;

namespace WindowsFormsApplication1
{
    public partial class Form_PrintAllOk : Form
    {
        DeliveryPrintService.DeliveryPrintService MyService = new DeliveryPrintService.DeliveryPrintService();
        
        //点击刷新标记
        private int renew = 0;

        private int lastid = 0;
        //开始id
        private int fromid = 0;

        //查询打印时间选定
        private bool ptimeselect = false;

        //查询订单时间选定
        private bool ddtimeselect = false;
        //
        private string orderunm = "";//订单号
        private string kddh = "";//快递单号
        private string mjid = "";//买家id
        private string caozuo = "";//操作员
        //private string huodong = "";//活动名
        DateTime shijian ;//打印时间

        private DateTime ddtime;//订单时间

        private string m_Address;
        /// <summary>
        /// xml文件的路径
        /// </summary>
        public string Address
        {
            get { return m_Address; }
            set { m_Address = value; }
        }

        public string Hdname
        {
            get { return hdname; }
            set { hdname = value; }
        }

        private string hdname;//活动名称

        private static Form_PrintAllOk _instance;

        //创建窗体对象的静态方法
        public static Form_PrintAllOk InstanceObject()
        {
            if (_instance == null)
                _instance = new Form_PrintAllOk();
            return _instance;
        }


        public Form_PrintAllOk()
        {
            InitializeComponent();

            

            //控件自适应
            int count = Controls.Count * 2 + 2;
            var factor = new float[count];
            int i = 0;
            factor[i++] = Size.Width;
            factor[i++] = Size.Height;
            foreach (Control ctrl in Controls)
            {
                factor[i++] = ctrl.Location.X / (float)Size.Width;
                factor[i++] = ctrl.Location.Y / (float)Size.Height;
                ctrl.Tag = ctrl.Size;
            }
            Tag = factor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if(renew==1)
            {
                this.button_renew.Enabled = false;
            }
            else
            {
                button_renew.Enabled = true;
            }

        }

        private void button_renew_Click(object sender, EventArgs e)
        {
            //renew = 1;
            //this.button_renew.Enabled = false;
            //this.timer1.Interval = 6 * 60 * 1000;
            //timer1.Enabled = false;
            
            //renew = 0;
            //timer1.Enabled = true;
            //
            this.button_renew.Enabled = false;
            this.getprintpartok(0);
            //
            GetNumGroupBy();
            this.button_renew.Enabled = true;
        }

        private void getprintpartok(int sid)
        {
            orderunm = textBox_ordernum.Text.Trim();
            kddh = textBox_kddh.Text.Trim();
            mjid = textBox_maijia.Text.Trim();
            caozuo = textBox_caozuo.Text.Trim();
            shijian = dateTimePicker1.Value.Date;
            hdname = textBox_huodongname.Text.Trim();
            ddtime = dateTimePicker2.Value.Date;

            try
            {
                //执行查询
                MyService.Credentials = System.Net.CredentialCache.DefaultCredentials;
                string address = m_Address;
                DataTable dt = new DataTable();
                
                    MyService.Url = "http://" + address + "/DeliveryPrintService.asmx";

                    DeliveryPrintService.myheader myheader = new myheader();
                    myheader.username = "nmlch-2012-byken";

                    MyService.myheaderValue = myheader;
                 
                    dt = MyService.GetPrintPart(sid,orderunm,kddh,mjid,caozuo,shijian,hdname,ddtime,ptimeselect,ddtimeselect);
                
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.dataGridView_allprintok.DataSource = dt;
                    lastid = fromid;
                    fromid = int.Parse(dt.Rows[dt.Rows.Count - 1]["编号"].ToString());
                    checknext();

                }
                else
                {
                    fromid = 0;
                    checknext();
                    MessageBox.Show("没有找到符合条件的打印数据。", "提示：");
                    dataGridView_allprintok.DataSource = null;
                }
            }
            catch (Exception ee)
            {
                
                MessageBox.Show(ee.Message);
            }
        }

        private void button_renew_MouseHover(object sender, EventArgs e)
        {
            if(this.button_renew.Enabled==false)
            {
                this.button_renew.Tag = "为避免给服务器造成过大检索压力，请在6分钟后再次进行刷新。";
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.getprintpartok(fromid);
        }

        private void checknext()
        {
            if (fromid == 0)
            {
                button_next.Enabled = false;
            }
            else
            {
                button_next.Enabled = true;
            }
        }

        private void Form_PrintAllOk_Load(object sender, EventArgs e)
        {
            getprintpartok(fromid);

            if (fromid == 0)
            {
                button_next.Enabled = false;
            }

            DeliveryPrintService.myheader myheader = new myheader();
            myheader.username = "nmlch-2012-byken";

            MyService.myheaderValue = myheader;

            GetNumGroupBy();
        }

        private void Form_PrintAllOk_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }


        //
        private void GetNumGroupBy()
        {

            try
            {
                //执行查询
                MyService.Credentials = System.Net.CredentialCache.DefaultCredentials;
                string address = m_Address;
                DataTable dt = new DataTable();

                MyService.Url = "http://" + address + "/DeliveryPrintService.asmx";
                dt = MyService.GetPrintGroupBy();

                if (dt != null && dt.Rows.Count > 0)
                {
                    this.dataGridView_groupbyprint.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("获取汇总打印数据失败，请联网重新尝试。", "提示：");
                    dataGridView_groupbyprint.DataSource = null;
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_ordernum.Text = this.dateTimePicker1.Value.Date.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value != System.DateTime.Parse("2011-09-30"))
            ddtimeselect = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != System.DateTime.Parse("2011-11-30"))
            ptimeselect = true;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_ordernum.Text = "";
            textBox_kddh.Text = "";
            textBox_maijia.Text = "";
            textBox_huodongname.Text = "";
            textBox_caozuo.Text = "";
            ptimeselect = false;
            ddtimeselect = false;
            dateTimePicker1.Value = System.DateTime.Parse("2011-11-30");
            dateTimePicker2.Value = DateTime.Parse("2011-09-30");
            ddtime = dateTimePicker2.Value.Date;
            shijian = dateTimePicker1.Value.Date;
            lastid = 0;
            fromid = 0;
        }

        private void Form_PrintAllOk_Resize(object sender, EventArgs e)
        {
            float[] scale = (float[])Tag;
            int i = 2;

            foreach (Control ctrl in Controls)
            {
                ctrl.Left = (int)(Size.Width * scale[i++]);
                ctrl.Top = (int)(Size.Height * scale[i++]);
                ctrl.Width = (int)(Size.Width / (float)scale[0] * ((Size)ctrl.Tag).Width);
                ctrl.Height = (int)(Size.Height / (float)scale[1] * ((Size)ctrl.Tag).Height);

                //每次使用的都是最初始的控件大小，保证准确无误。
            }
        }




    }
}
