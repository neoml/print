using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApplication1.DeliveryPrintService;

namespace WindowsFormsApplication1
{
    public partial class Form_jiesuo : Form
    {
        public Form_jiesuo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("PathConfig.xml");
            XmlNode node = doc.SelectSingleNode("Config/Path");
            XmlNode node1 = doc.SelectSingleNode("Config/ServiceName");
            XmlNode node2 = doc.SelectSingleNode("Config/Format");
            XmlNode node3 = doc.SelectSingleNode("Config/ShopSource");
            XmlNode node4 = doc.SelectSingleNode("Config/PrintName");

            string serverPath = node.InnerText;
            //serviceName = node1.InnerText;
            //format = node2.InnerText;
             string address = serverPath;
            //shopSource = node3.InnerText;
            //printName = node4.InnerText;

            DeliveryPrintService.DeliveryPrintService MyService = new DeliveryPrintService.DeliveryPrintService();
            MyService.Credentials = System.Net.CredentialCache.DefaultCredentials;
            MyService.Url = "http://" + address + "/DeliveryPrintService.asmx";


            DeliveryPrintService.myheader myheader = new myheader();
            myheader.username = "nmlch-2012-byken";

            MyService.myheaderValue = myheader;

            string strUserName = StringTools.EncodingForString(this.textBox_gly.Text.Trim());
            string strPassword = StringTools.EncodingForString(this.textBox_kl.Text.Trim());
            string fuser = StringTools.EncodingForString(this.textBox_user.Text.Trim());


            bool b = MyService.RUser(strUserName, strPassword, fuser);
            if(b)
            {
                MessageBox.Show("用户："+this.textBox_user.Text+"  解锁成功！");
            }
            else
            {
                MessageBox.Show("解锁失败，请确认管理密码、口令和解锁用户代码正确！");
            }
        }
    }
}
