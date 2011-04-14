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
    public partial class SupplierForm : Form
    {
        private Connector connect = null;

        public Connector Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        private List<Supplier> suppliers = null;

        public List<Supplier> Suppliers
        {
            get { return suppliers; }
            set { suppliers = value; }
        }
        private bool isEdit = false;
        private int index = 0;

        public void setIndex(int i)
        {
            this.isEdit = true;
            this.enterButton.Text = "修改";
            this.navBarPanel.Visible = true;
            this.pageCount.Text = " / " + suppliers.Count;
            showData();
            if (suppliers.Count == 1)
            {
                this.firstButton.Enabled = false;
                this.preButton.Enabled = false;
                this.lastButton.Enabled = false;
                this.nextButton.Enabled = false;
            }
        }
        public SupplierForm()
        {
            InitializeComponent();
            this.enterButton.Text = "新增";
            this.navBarPanel.Visible = false;
            this.currencyBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 新增或是修改資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void enterButton_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s._Addr = addrTextBox.Text;
            s._B_account = b_accountTextBox.Text;
            s._B_name = b_nameTextBox.Text;
            s._City = cityTextBox.Text;
            s._Contacter = contacterTextBox.Text;
            s._Currency = currencyBox.SelectedIndex;
            s._Day = (int)Convert.ToDecimal(dayTextBox.Text);
            s._District = districtTextBox.Text;
            s._Ext1 = (int)Convert.ToDecimal(ext1TextBox.Text);
            s._Ext2 = (int)Convert.ToDecimal(ext2TextBox.Text);
            s._Ext3 = (int)Convert.ToDecimal(ext3TextBox.Text);
            s._Fax = faxTextBox.Text;
            s._Id = idTextBox.Text;
            s._Mail = mailTextBox.Text;
            s._Mobile = (int)Convert.ToDecimal(mobileTextBox.Text);
            s._Name = nameTextBox.Text;
            s._Phone1 = phone1TextBox.Text;
            s._Phone2 = phone2TextBox.Text;
            s._Province = provinceTextBox.Text;
            s._Shortname = shortnameTextBox.Text;
            s._Town = townTextBox.Text;
            s._Village = villageTextBox.Text;
            s._Zone = zoneTextBox.Text;
            if (!this.isEdit)
            {
                if (this.connect.add(s))
                {
                    MessageBox.Show("新增資料成功!!");
                    this.suppliers.Add(s);
                    reset();
                }
            }
            else
            {
                if (this.connect.edit(s,this.suppliers.ElementAt(index)))
                {
                    MessageBox.Show("修改資料成功!!");
                    this.suppliers.RemoveAt(index);
                    this.suppliers.Insert(index, s);
                }
                else
                {
                    showData();
                }
            }
        }

        private void reset()
        {
            shortnameTextBox.Text = "";
            nameTextBox.Text = "";
            idTextBox.Text = "";
            contacterTextBox.Text = "";
            mobileTextBox.Text = "";
            phone1TextBox.Text = "";
            ext1TextBox.Text = "";
            ext2TextBox.Text = "";
            phone2TextBox.Text = "";
            ext3TextBox.Text = "";
            faxTextBox.Text = "";
            villageTextBox.Text = "";
            townTextBox.Text = "";
            cityTextBox.Text = "";
            provinceTextBox.Text = "";
            mailTextBox.Text = "";
            addrTextBox.Text = "";
            zoneTextBox.Text = "";
            districtTextBox.Text = "";
            dayTextBox.Text = "";
            b_accountTextBox.Text = "";
            b_nameTextBox.Text = "";
            pageTextBox.Text = "";
            this.currencyBox.SelectedIndex = 0;
        }

        private void showData()
        {
            Supplier s = suppliers.ElementAt(index);
            shortnameTextBox.Text = s._Shortname;
            nameTextBox.Text = s._Name;
            idTextBox.Text = s._Id;
            contacterTextBox.Text = s._Contacter;
            mobileTextBox.Text = s._Mobile.ToString();
            phone1TextBox.Text = s._Phone1;
            ext1TextBox.Text = s._Ext1.ToString();
            ext2TextBox.Text = s._Ext2.ToString();
            phone2TextBox.Text = s._Phone2;
            ext3TextBox.Text = s._Ext3.ToString();
            faxTextBox.Text = s._Fax;
            villageTextBox.Text = s._Village;
            townTextBox.Text = s._Town;
            cityTextBox.Text = s._City;
            provinceTextBox.Text = s._Province;
            mailTextBox.Text = s._Mail;
            addrTextBox.Text = s._Addr;
            zoneTextBox.Text = s._Zone;
            districtTextBox.Text = s._District;
            dayTextBox.Text = s._Day.ToString();
            b_accountTextBox.Text = s._B_account;
            b_nameTextBox.Text = s._B_name;
            this.currencyBox.SelectedIndex = s._Currency;
            this.pageTextBox.Text = (this.index + 1).ToString();
        }

        /// <summary>
        /// 取消按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 第一筆資料按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void firstButton_Click(object sender, EventArgs e)
        {
            this.index = 0;
            showData();
            this.firstButton.Enabled = false;
            this.preButton.Enabled = false;
            this.lastButton.Enabled = true;
            this.nextButton.Enabled = true;
        }

        /// <summary>
        /// 上一筆資料按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 下一筆資料按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void nextButton_Click(object sender, EventArgs e)
        {
            this.index = this.index + 1;
            showData();
            if (this.index == suppliers.Count - 1)
            {
                this.nextButton.Enabled = false;
                this.lastButton.Enabled = false;
            }
            this.preButton.Enabled = true;
            this.firstButton.Enabled = true;
        }

        /// <summary>
        /// 最後一筆資料按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void lastButton_Click(object sender, EventArgs e)
        {
            this.index = suppliers.Count - 1;
            showData();
            this.lastButton.Enabled = false;
            this.preButton.Enabled = true;
            this.firstButton.Enabled = true;
            this.nextButton.Enabled = false;
        }

        /// <summary>
        /// 導覽列數字改變的時候
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void pageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.pageTextBox.Text != null && !this.pageTextBox.Text.Equals(""))
            {
                if (Convert.ToDecimal(this.pageTextBox.Text) > 0 && Convert.ToDecimal(this.pageTextBox.Text) <= suppliers.Count)
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
                    if (this.index == suppliers.Count - 1)
                    {
                        this.nextButton.Enabled = false;
                        this.lastButton.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入1~" + suppliers.Count.ToString() + "!!");
                }
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
