using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ServiceLib.BC;
using ServiceLib.DA;
using ServiceLib.Util;
using TestFrom.DeliveryPrintService;


namespace TestFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdateDeliveryNo_Click(object sender, EventArgs e)
        {
            //DeliveryPrintBC deliveryPrintBc = new DeliveryPrintBC();

            //string orderNo = txtOrderNo.Text.Trim();
            //string deliveryNo = txtDeliveryNo.Text.Trim();


            //deliveryPrintBc.UpdateDeliveryNo(orderNo,deliveryNo);

            //string s = string.Empty;


        }

        private void btnDispatchListsInsert_Click(object sender, EventArgs e)
        {
            //DeliveryPrintBC().GetInvoiceAndInsertSQL
            //GetInvoiceAndInsertSQL
            //DeliveryPrintBC deliveryPrintBc = new DeliveryPrintBC();

            //string orderNo = txtOrderNo.Text.Trim();
            //string deliveryNo = txtDeliveryNo.Text.Trim();

            //deliveryPrintBc.GetInvoiceAndInsertSQL(deliveryNo, orderNo);

            //string s = string.Empty;

        }

        private void btnGetInvoice_Click(object sender, EventArgs e)
        {
            ServiceLib.DA.StoragePrintDA storagePrintDa = new StoragePrintDA();
            //MDY=
            //""
            //全部
            //""
            //0

            //string str = "01";
            //var dt = storagePrintDa.GetInvoice(str, "T20110623001730", "全部", "T", 0);

            //string s = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ServiceLib.BC.DeliveryPrintBC deliveryPrintBc = new DeliveryPrintBC();

            //var dt = deliveryPrintBc.GetRemoveInfo();
        }

        private void btnGetRegionString_Click(object sender, EventArgs e)
        {
            //ServiceLib.BC.DeliveryPrintBC deliveryPrintBc = new DeliveryPrintBC();
            //var s = deliveryPrintBc.GetRegionString("440783");
            //MessageBox.Show(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ServiceLib.BC.DeliveryPrintBC deliveryPrintBc = new DeliveryPrintBC();
            //var dt = deliveryPrintBc.GetShippingChoice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeliveryPrintService.DeliveryPrintService MyService = new DeliveryPrintService.DeliveryPrintService();
            DeliveryPrintService.myheader myheader = new DeliveryPrintService.myheader();
            myheader.username = "nmlch-2012-byken";
            MyService.myheaderValue = myheader;
            string[] odnum = MyService.GetorderNum("beautyaction", "2013-07-27-拖鞋-G00046", "2013-07-20 00:00:00");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string password= textBox_md5.Text.Trim();
            textBox_md5.Text = StringTools.MD5Encode(password);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_md5.Text = StringTools.EncodingForString(textBox_md5.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strUserNum = StringTools.DecodingForString(this.txtOrderNo.Text);
            string strPassword = StringTools.MD5Encode(StringTools.DecodingForString(this.txtDeliveryNo.Text));

            DataTable dt = new DeliveryPrintBC().LoginCheck(strUserNum, strPassword);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(dt.Rows.Count.ToString());
                }
                else
                {
                    MessageBox.Show("0");
                }
            }
            else
            {
                MessageBox.Show("null");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox_md5.Text = StringTools.EncodingForString("1234");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox_md5.Text = StringTools.DecodingForString(textBox_md5.Text);
        }

        private void button_hdname_Click(object sender, EventArgs e)
        {
            StoragePrintDA sd=new StoragePrintDA();
            //DataTable  ll = sd.GetHdNameAll();
            //if(ll.Count>0)
            //{
               

            //    comboBox1.DataSource = ll;
            //}
            //else
            //{
            //    textBox1.Text = "没有找到活动名称";
            //}
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text += "s序号："+comboBox1.SelectedIndex+"\r\n s-value:"+ comboBox1.SelectedValue+"\r\n s_text:"+comboBox1.SelectedText;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StartThread();
            //StringBuilder sb = new StringBuilder();
            //DataTable dt = new StoragePrintDA().GetInvoice2();
            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        sb.Append(row["id"] + "-");
            //    }
            //}
            //textBox1.Text = sb.ToString();
        }


        private void StartThread()
        {
            var wc1 = new WaitCallback(ExeThread);
            for (int i = 0; i < 20; i++)
            {
                ThreadPool.QueueUserWorkItem(wc1, i.ToString());
            }


        }

        private void ExeThread(object nn)
        {
            //string tt = System.Threading.Thread.CurrentThread.GetHashCode().ToString();
            StringBuilder sb=new StringBuilder();
            var ac = new Action<string>(Showtext);
            sb.Append("user:" + nn.ToString()+"::");
            DataTable dt = new StoragePrintDA().GetInvoice(nn.ToString(), "快递", "", "", "", 5, "", "2011年双12");
            if(dt!=null && dt.Rows.Count>0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    sb.Append(row["id"]+"-");
                }
            }

            this.Invoke(ac, sb.ToString());

        }



        private void Showtext(string ii)
        {
            textBox1.Text += ii + "\r\n";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string strPassword = StringTools.MD5Encode(textBox1.Text.Trim()).ToUpper();
            textBox1.Text = strPassword;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DeliveryPrintService.DeliveryPrintService MyService = new DeliveryPrintService.DeliveryPrintService();
            MyService.Timeout = 600000;
            DeliveryPrintService.myheader myheader = new myheader();
            myheader.username = "nmlch-2012-byken";

            MyService.myheaderValue = myheader;
            textBox1.Text = MyService.GetHdNameAll()[0];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;
            textBox1.Text = dt.ToString();
        }
    }
}
