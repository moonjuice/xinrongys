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
    public partial class CustomerForm : Form
    {
        private Connector connect = null;
        private List<Customer> customers = null;
        private bool isEdit = false;
        private int index=0;

        public void setIndex(int i)
        {
            this.isEdit = true;
            this.enterButton.Text = "修改";
            this.navBarPanel.Visible = true;
            this.pageCount.Text = " / " + customers.Count;
            showData();
            if (customers.Count == 1)
            {
                this.firstButton.Enabled = false;
                this.preButton.Enabled = false;
                this.lastButton.Enabled = false;
                this.nextButton.Enabled = false;
            }
        }
       
        public CustomerForm()
        {
            InitializeComponent();
            this.enterButton.Text = "新增";
            this.navBarPanel.Visible = false;
            this.currencyBox.SelectedIndex = 0;
        }
        public Connector Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        public List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
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
        }

        private void showData()
        {
            Customer c = customers.ElementAt(index);
            shortnameTextBox.Text = c._Shortname;
            nameTextBox.Text = c._Name;
            idTextBox.Text = c._Id;
            contacterTextBox.Text = c._Contacter;
            mobileTextBox.Text = c._Mobile.ToString();
            phone1TextBox.Text = c._Phone1;
            ext1TextBox.Text = c._Ext1.ToString();
            ext2TextBox.Text = c._Ext2.ToString();
            phone2TextBox.Text = c._Phone2;
            ext3TextBox.Text = c._Ext3.ToString();
            faxTextBox.Text = c._Fax;
            villageTextBox.Text = c._Village;
            townTextBox.Text = c._Town;
            cityTextBox.Text = c._City;
            provinceTextBox.Text = c._Province;
            mailTextBox.Text = c._Mail;
            addrTextBox.Text = c._Addr;
            zoneTextBox.Text = c._Zone;
            districtTextBox.Text = c._District;
            dayTextBox.Text = c._Day.ToString();
            b_accountTextBox.Text = c._B_account;
            b_nameTextBox.Text = c._B_name;
            this.currencyBox.SelectedIndex = c._Currency;
            this.pageTextBox.Text = (this.index+1).ToString();
        }

        /// <summary>
        /// 新增或是修改資料
        /// </summary>
        private void enterButton_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c._Addr = addrTextBox.Text;
            c._B_account = b_accountTextBox.Text;
            c._B_name = b_nameTextBox.Text;
            c._City = cityTextBox.Text;
            c._Contacter = contacterTextBox.Text;
            c._Currency = currencyBox.SelectedIndex;
            c._Day = (int)Convert.ToDecimal(dayTextBox.Text);
            c._District = districtTextBox.Text;
            c._Ext1 = (int)Convert.ToDecimal(ext1TextBox.Text);
            c._Ext2 = (int)Convert.ToDecimal(ext2TextBox.Text);
            c._Ext3 = (int)Convert.ToDecimal(ext3TextBox.Text);
            c._Fax = faxTextBox.Text;
            c._Id = idTextBox.Text;
            c._Mail = mailTextBox.Text;
            c._Mobile = (int)Convert.ToDecimal(mobileTextBox.Text);
            c._Name = nameTextBox.Text;
            c._Phone1 = phone1TextBox.Text;
            c._Phone2 = phone2TextBox.Text;
            c._Province = provinceTextBox.Text;
            c._Shortname = shortnameTextBox.Text;
            c._Town = townTextBox.Text;
            c._Village = villageTextBox.Text;
            c._Zone = zoneTextBox.Text;
            if (!this.isEdit)
            {
                if (this.connect.add(c))
                {
                    MessageBox.Show("新增資料成功!!");
                    this.customers.Add(c);
                    reset();
                }
            }
            else
            {
                if (this.connect.edit(c,this.customers.ElementAt(index)))
                {
                    MessageBox.Show("修改資料成功!!");
                    this.customers.RemoveAt(index);
                    this.customers.Insert(index, c);
                }
                else
                {
                    showData();
                }
            }
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
            if (this.index == customers.Count - 1)
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
            this.index = customers.Count-1;
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
                if (Convert.ToDecimal(this.pageTextBox.Text) > 0 && Convert.ToDecimal(this.pageTextBox.Text) <= customers.Count)
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
                    if (this.index == customers.Count - 1)
                    {
                        this.nextButton.Enabled = false;
                        this.lastButton.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入1~" + customers.Count.ToString() + "!!");
                }
            }
        }
    }
}
