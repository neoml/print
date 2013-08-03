using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class FrmSystemSet : Form
    {
        public FrmSystemSet()
        {
            InitializeComponent();
        }
      // string path = AppDomain.CurrentDomain.BaseDirectory + @"\PathConfig.xml"; //读取PahConfig.xml的路径
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string address = txtPath.Text.Trim();  //获取路径
            string serviceName = txtServiceName.Text.Trim(); //获取面单打印机的名字
            string format = txtFormat.Text.Trim();          //打印格式
            string shopSource = this.cmbShopSource.SelectedItem.ToString(); //货的来源
            string printName = this.txtPrintName.Text.Trim();//清单打印机的名字

            XmlDocument doc = new XmlDocument();

            doc.Load("PathConfig.xml");
            //获取根节点
            XmlNode xn = doc.SelectSingleNode("Config");
            //创建货的来源的节点
            XmlNode xn4 = doc.CreateElement("ShopSource");
            //创建打印机的名字的节点
            XmlNode xn6= doc.CreateElement("PrintName");
 
            //获取路径
            XmlNode node = doc.SelectSingleNode("Config/Path");
            //获取服务器名字
            XmlNode node2 = doc.SelectSingleNode("Config/ServiceName");
            //获取打印的格式
            XmlNode node3 = doc.SelectSingleNode("Config/Format");

            //把货的来源节点加进来
            xn.AppendChild(xn4);
            //把打印机的名字节点加进来
            xn.AppendChild(xn6);
            //获取货的来源
            XmlNode xn5 = doc.SelectSingleNode("Config/ShopSource");
            //获取打印机名字
            XmlNode xn7 = doc.SelectSingleNode("Config/PrintName");
            xn5.InnerText = this.cmbShopSource.SelectedItem.ToString();
            xn7.InnerText = this.txtPrintName.Text.Trim();
          
            node.InnerText = address;
            node2.InnerText = serviceName;
            node3.InnerText = format;
            xn5.InnerText = shopSource;
            xn7.InnerText = printName;
            doc.Save("PathConfig.xml");
            FrmLogin fl = new FrmLogin();
            fl.Show();
            this.Hide();

        }

        private void FrmSystemSet_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("PathConfig.xml");
            XmlNode node = doc.SelectSingleNode("Config/Path");
            XmlNode node2 = doc.SelectSingleNode("Config/ServiceName");
            XmlNode node3 = doc.SelectSingleNode("Config/Format");
             XmlNode node4 = doc.SelectSingleNode("Config/ShopSource");
             XmlNode node5 = doc.SelectSingleNode("Config/PrintName");
            string address = node.InnerText;
            this.txtPath.Text = address;  //把xml的路径值赋给txtPah
            this.txtServiceName.Text = node2.InnerText;
            this.txtFormat.Text = node3.InnerText;
            this.cmbShopSource.SelectedItem = node4.InnerText;
            this.txtPrintName.Text = node5.InnerText;
            
            
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmLogin fl = new FrmLogin();
            fl.Show();
            this.Hide();
        }
        /// <summary>
        /// 关闭系统设置窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemSet_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("是否要关掉当前窗体？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}
