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
    public partial class ConnectForm : Form
    {
        private Connector connect;
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            this.connect = new Connector(this.hostTextBox.Text,this.nameTextBox.Text,this.passwordTextBox.Text);
            if (!connect.connect())
                connect = null;
            else
                this.Close();
        }

        public Connector getConnector()
        {
            return this.connect;
        }
    }
}
