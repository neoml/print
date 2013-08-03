using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form_kucun : Form
    {
        public Form_kucun()
        {
            InitializeComponent();
            
        }
        private Thread read;
        private delegate void labels(string[] s);
        private delegate void dt(DataTable dt);
        private string sellename;
        private string code;
        private string hdname;
        private string time;
        private string isclose;
        DeliveryPrintService.DeliveryPrintService MyService = new DeliveryPrintService.DeliveryPrintService();
        public Object huodongname { get; set; }
        public void XS()
        { 
            comboBox1.DataSource = huodongname;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable de = new DataTable();
            de.Columns.Add("Stockcode", Type.GetType("System.String"));
            de.Columns.Add("Color", Type.GetType("System.String"));
            de.Columns.Add("Size", Type.GetType("System.String"));
            de.Columns.Add("剩余库存", Type.GetType("System.String"));
            de.Columns.Add("团购数量", Type.GetType("System.String"));
            DataTable dt = MyService.Getkucun(sellename, hdname, time,isclose);
            DataTable dt1 = MyService.kucun(code);
            var sd = from kc in dt1.AsEnumerable()
                     from ka in dt.AsEnumerable()
                     where kc.Field<string>("Stockcode") == ka.Field<string>("货号") &&
                     kc.Field<string>("Color") == ka.Field<string>("颜色") &&
                     kc.Field<string>("Size") == ka.Field<string>("尺码")
                     select new
                     {
                         code = kc["Stockcode"],
                         color = kc["Color"],
                         size = kc["Size"],
                         oldnum = kc["Amount"],
                         nownum = ka["数量"]
                     };

            foreach (var now in sd)
            {
                DataRow cku = de.NewRow();
                cku["Stockcode"] = now.code;
                cku["Color"] = now.color;
                cku["Size"] = now.size;
                cku["剩余库存"] = (Convert.ToInt32(now.oldnum) - Convert.ToInt32(now.nownum)).ToString();
                cku["团购数量"] = now.nownum;
                de.Rows.Add(cku); 
            }
            dataGridView1.DataSource = de;
        }

        private void Form_kucun_Load(object sender, EventArgs e)
        {
            str();
            DeliveryPrintService.myheader myheader = new DeliveryPrintService.myheader();
            myheader.username = "nmlch-2012-byken";
            MyService.myheaderValue = myheader;
            dataGridView1.DataSource = null;
        }

        private void str()
        {
            sellename = comboBox1.SelectedValue.ToString().Substring(comboBox1.SelectedValue.ToString().LastIndexOf("|") + 1);
            code = comboBox1.SelectedValue.ToString().Substring(comboBox1.SelectedValue.ToString().LastIndexOf("|") - 6, 6);
            hdname = comboBox1.SelectedValue.ToString().Substring(0, comboBox1.SelectedValue.ToString().LastIndexOf("|"));
            time = DateTime.Now.AddDays(-10).ToString("yyyy-MM-dd HH:mm:ss");
            isclose = checkBox1.Checked ? "1" : "0";
        }       

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            str();
            read = new Thread(combox);
            read.Start();
        }

        private void combox()
        {            
            string[] odnum = MyService.GetorderNum(this.sellename, this.hdname, this.time);            
            this.Invoke(new labels(xians), new object[] { odnum });            
        }

        private void xians(string[] odnum)
        {
            if (odnum != null)
            {
                label5.Text = odnum[0];
                label7.Text = odnum[1];
                label9.Text = odnum[2];
                label3.Text = odnum[3];
                label11.Text = (Convert.ToInt32(odnum[0]) - Convert.ToInt32(odnum[2])).ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            str();
            DataTable dt1 = MyService.kucun(code);
        }








    }
}
