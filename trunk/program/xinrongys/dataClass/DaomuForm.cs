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
    public partial class DaomuForm : Form
    {
        private Connector connect = null;

        public Connector Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        private List<Daomu> daomus = null;

        public List<Daomu> Daomus
        {
            get { return daomus; }
            set { daomus = value; }
        }

        private bool isEdit = false;
        private int index = 0;
        public DaomuForm()
        {
            InitializeComponent();
            this.enterButton.Text = "新增";
            this.navBarPanel.Visible = false;
            this.typeComboBox.SelectedIndex = 0;
        }
        public void setIndex(int i)
        {
            this.isEdit = true;
            this.enterButton.Text = "修改";
            this.navBarPanel.Visible = true;
            this.pageCount.Text = " / " + daomus.Count;
            this.index = i;
            showData();
            if (daomus.Count == 1)
            {
                this.firstButton.Enabled = false;
                this.preButton.Enabled = false;
                this.lastButton.Enabled = false;
                this.nextButton.Enabled = false;
            }
        }

        private void reset()
        {
            this.cabinetTextBox.Text = "";
            this.d_longTextBox.Text = "";
            this.d_roundTextBox.Text = "";
            this.d_widthTextBox.Text = "";
            this.idTextBox.Text = "";
            this.l_dTextBox.Text = "";
            this.l_mTextBox.Text = "";
            this.typeComboBox.SelectedIndex = 0;
            this.w_dTextBox.Text = "";
            this.w_mTextBox.Text = "";
        }

        private void showData()
        {
            Daomu d = daomus.ElementAt(index);
            this.cabinetTextBox.Text = d._Cabinet.ToString();
            this.d_longTextBox.Text = d._D_long.ToString();
            this.d_roundTextBox.Text = d._D_round.ToString();
            this.d_widthTextBox.Text = d._D_width.ToString();
            this.idTextBox.Text = d._Id;
            this.l_dTextBox.Text = d._L_d.ToString();
            this.l_mTextBox.Text = d._L_m.ToString();
            this.typeComboBox.SelectedIndex = d._Type;
            this.w_dTextBox.Text = d._W_d.ToString();
            this.w_mTextBox.Text = d._W_m.ToString();
            this.pageTextBox.Text = (this.index + 1).ToString();
        }

        
        private void enterButton_Click(object sender, EventArgs e)
        {
            Daomu d = new Daomu();
            d._Cabinet = (int)Convert.ToDecimal(this.cabinetTextBox.Text);
            d._D_long = (int)Convert.ToDecimal(this.d_longTextBox.Text);
            d._D_round = (int)Convert.ToDecimal(this.d_roundTextBox.Text);
            d._D_width = (int)Convert.ToDecimal(this.d_widthTextBox.Text);
            d._Id = this.idTextBox.Text;
            d._L_d = (int)Convert.ToDecimal(this.l_dTextBox.Text);
            d._L_m = (int)Convert.ToDecimal(this.l_mTextBox.Text);
            d._Type = this.typeComboBox.SelectedIndex;
            d._W_d = (int)Convert.ToDecimal(this.w_dTextBox.Text);
            d._W_m = (int)Convert.ToDecimal(this.w_mTextBox.Text);
            if (!this.isEdit)
            {
                if (this.connect.add(d))
                {
                    MessageBox.Show("新增資料成功!!");
                    this.daomus.Add(d);
                    reset();
                }
            }
            else
            {
                if (this.connect.edit(d,this.daomus.ElementAt(index)))
                {
                    MessageBox.Show("修改資料成功!!");
                    this.daomus.RemoveAt(index);
                    this.daomus.Insert(index, d);
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
                if (Convert.ToDecimal(this.pageTextBox.Text) > 0 && Convert.ToDecimal(this.pageTextBox.Text) <= daomus.Count)
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
                    if (this.index == daomus.Count - 1)
                    {
                        this.nextButton.Enabled = false;
                        this.lastButton.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入1~" + daomus.Count.ToString() + "!!");
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.index = this.index + 1;
            showData();
            if (this.index == daomus.Count - 1)
            {
                this.nextButton.Enabled = false;
                this.lastButton.Enabled = false;
            }
            this.preButton.Enabled = true;
            this.firstButton.Enabled = true;
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            this.index = daomus.Count - 1;
            showData();
            this.lastButton.Enabled = false;
            this.preButton.Enabled = true;
            this.firstButton.Enabled = true;
            this.nextButton.Enabled = false;
        }

        private void d_longTextBox_TextChanged(object sender, EventArgs e)
        {
            this.textBox6.Text = this.d_longTextBox.Text;
        }

        private void d_widthTextBox_TextChanged(object sender, EventArgs e)
        {
            this.textBox7.Text = this.d_widthTextBox.Text;
        }

        private void l_mTextBox_TextChanged(object sender, EventArgs e)
        {
            if (l_mTextBox.Text != null && !l_mTextBox.Text.Equals("") && w_mTextBox.Text != null && !w_mTextBox.Text.Equals(""))
            {
                if (Convert.ToDecimal(l_mTextBox.Text) < 1 || Convert.ToDecimal(l_mTextBox.Text) > 999)
                    MessageBox.Show("請輸入1~999!!");
                else
                    this.textBox10.Text = (Convert.ToDecimal(l_mTextBox.Text) * Convert.ToDecimal(w_mTextBox.Text)).ToString();
            }
        }

        private void w_mTextBox_TextChanged(object sender, EventArgs e)
        {
            if (l_mTextBox.Text != null && !l_mTextBox.Text.Equals("") && w_mTextBox.Text != null && !w_mTextBox.Text.Equals(""))
            {
                if (Convert.ToDecimal(w_mTextBox.Text) < 1 || Convert.ToDecimal(w_mTextBox.Text) > 999)
                    MessageBox.Show("請輸入1~999!!");
                else
                    this.textBox10.Text = (Convert.ToDecimal(l_mTextBox.Text) * Convert.ToDecimal(w_mTextBox.Text)).ToString();
            }
        }
    }
}
