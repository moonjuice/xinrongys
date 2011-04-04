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
    public partial class MakingForm : Form
    {
        private Connector connect = null;

        public Connector Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        private List<Making> makings = null;
        private bool isEdit = false;
        private int index = 0;
        public List<Making> Makings
        {
            get { return makings; }
            set { makings = value; }
        }
        public MakingForm()
        {
            InitializeComponent();
            this.enterButton.Text = "新增";
            this.navBarPanel.Visible = false;
        }
        public void setIndex(int i)
        {
            this.isEdit = true;
            this.enterButton.Text = "修改";
            this.navBarPanel.Visible = true;
            this.pageCount.Text = " / " + makings.Count;
            this.index = i;
            showData();
            if (makings.Count == 1)
            {
                this.firstButton.Enabled = false;
                this.preButton.Enabled = false;
                this.lastButton.Enabled = false;
                this.nextButton.Enabled = false;
            }
        }

        private void reset()
        {
            this.idTextBox.Text = "";
            this.nameTextBox.Text = "";
            this.typeComboBox.SelectedIndex = 0;
            this.s_idTextBox.Text = "";
            this.unitComboBox.SelectedIndex = 0;
            this.priceTextBox.Text = "";
        }

        private void showData()
        {
            Making m = makings.ElementAt(index);
            this.idTextBox.Text = m._Id;
            this.nameTextBox.Text = m._Name;
            this.typeComboBox.Text = m._Type;
            this.s_idTextBox.Text = m._S_id;
            this.unitComboBox.Text = m._Unit;
            this.priceTextBox.Text = m._Price.ToString();
            this.pageTextBox.Text = (index + 1).ToString();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Making m = new Making();
            m._Id = this.idTextBox.Text;
            m._Name = this.nameTextBox.Text;
            m._Price = (int)Convert.ToDecimal(this.priceTextBox.Text);
            m._S_id = this.s_idTextBox.Text;
            m._Type = this.typeComboBox.Text;
            m._Unit = this.unitComboBox.Text;
            if (!this.isEdit)
            {
                if (this.connect.add(m))
                {
                    MessageBox.Show("新增資料成功!!");
                    this.makings.Add(m);
                    reset();
                }
            }
            else
            {
                if (this.connect.edit(m, this.makings.ElementAt(index)))
                {
                    MessageBox.Show("修改資料成功!!");
                    this.makings.RemoveAt(index);
                    this.makings.Insert(index, m);
                }
                else
                {
                    showData();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            this.index = 0;
            showData();
            this.firstButton.Enabled = false;
            this.preButton.Enabled = false;
            this.lastButton.Enabled = true;
            this.nextButton.Enabled = true;
        }

        private void preButton_Click(object sender, EventArgs e)
        {
            this.index = this.index - 1;
            showData();
            if (this.index == 0)
            {
                this.preButton.Enabled = false;
                this.firstButton.Enabled = false;
            }
            this.nextButton.Enabled = true;
            this.lastButton.Enabled = true;
        }

        private void pageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.pageTextBox.Text != null && !this.pageTextBox.Text.Equals(""))
            {
                if (Convert.ToDecimal(this.pageTextBox.Text) > 0 && Convert.ToDecimal(this.pageTextBox.Text) <= makings.Count)
                {
                    this.index = ((int)Convert.ToDecimal(this.pageTextBox.Text)) - 1;
                    showData();
                    this.preButton.Enabled = true;
                    this.firstButton.Enabled = true;
                    this.nextButton.Enabled = true;
                    this.lastButton.Enabled = true;
                    if (this.index == 0)
                    {
                        this.preButton.Enabled = false;
                        this.firstButton.Enabled = false;
                    }
                    if (this.index == makings.Count - 1)
                    {
                        this.nextButton.Enabled = false;
                        this.lastButton.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入1~" + makings.Count.ToString() + "!!");
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.index = this.index + 1;
            showData();
            if (this.index == makings.Count - 1)
            {
                this.nextButton.Enabled = false;
                this.lastButton.Enabled = false;
            }
            this.preButton.Enabled = true;
            this.firstButton.Enabled = true;
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            this.index = makings.Count - 1;
            showData();
            this.lastButton.Enabled = false;
            this.preButton.Enabled = true;
            this.firstButton.Enabled = true;
            this.nextButton.Enabled = false;
        }
    }
}
