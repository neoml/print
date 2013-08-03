using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_help : Form
    {
        public Form_help()
        {
            InitializeComponent();
        }

        private static Form_help _instance;

        //创建窗体对象的静态方法
        public static Form_help InstanceObject()
        {
            if (_instance == null)
                _instance = new Form_help();
            return _instance;
        }

        private void Form_help_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }


    }
}
