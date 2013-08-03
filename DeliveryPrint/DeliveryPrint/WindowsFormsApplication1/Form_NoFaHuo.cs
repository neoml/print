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
    public partial class Form_NoFaHuo : Form
    {
        DeliveryPrintService.DeliveryPrintService MyService = new DeliveryPrintService.DeliveryPrintService();

        private string m_Address;
        /// <summary>
        /// xml文件的路径
        /// </summary>
        public string Address
        {
            get { return m_Address; }
            set { m_Address = value; }
        }


        public Form_NoFaHuo()
        {
            InitializeComponent();
        }

        private void button_renew_Click(object sender, EventArgs e)
        {
            MyService.Credentials = System.Net.CredentialCache.DefaultCredentials;
            string address = m_Address;
            MyService.Url = "http://" + address + "/DeliveryPrintService.asmx";

            DataTable dt = MyService.GetWenTiDan(this.dateTimePicker1.Value);
            if(dt!=null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void Form_NoFaHuo_Load(object sender, EventArgs e)
        {
            //添加soapheader

            DeliveryPrintService.myheader myheader = new myheader();
            myheader.username = "nmlch-2012-byken";

            MyService.myheaderValue = myheader;
        }

        private void button_num_Click(object sender, EventArgs e)
        {
            MyService.Credentials = System.Net.CredentialCache.DefaultCredentials;
            string address = m_Address;
            MyService.Url = "http://" + address + "/DeliveryPrintService.asmx";

            int[] ll = MyService.GetTuanNum(this.dateTimePicker1.Value);
            if(ll!=null && ll.Length==4)
            {
                label_nodown.Text = ll[0].ToString();
                label_down.Text = ll[1].ToString();
                label_fahuo.Text = ll[2].ToString();
                label_nofahuo.Text = ll[3].ToString();
            }
        }


    }
}
