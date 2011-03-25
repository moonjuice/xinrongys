using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xinrongys
{
    public partial class MainForm : Form
    {
        private Connector connect = null;
        private ConnectForm cf;
        public MainForm()
        {
            InitializeComponent();
        }

        private void connectMenuItem_Click(object sender, EventArgs e)
        {
            cf = new ConnectForm();
            cf.FormClosed += new FormClosedEventHandler(cf_FormClosed);
            cf.Show();
        }

        private void cf_FormClosed(object sender, EventArgs e)
        {
            connect = cf.getConnector();           
        }
    }
}
