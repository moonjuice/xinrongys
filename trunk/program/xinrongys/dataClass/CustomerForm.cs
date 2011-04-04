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
        private bool isAdd = true;

        public void setState(bool isAdd)
        {
            this.isAdd = isAdd;
            if (isAdd)
            {
                this.enterButton.Text = "新增";
                this.navBarPanel.Visible = false;
            }
            else
            {
                this.enterButton.Text = "修改";
                this.navBarPanel.Visible = true;
            }
        }
       
        public CustomerForm()
        {
            InitializeComponent();
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
            c._Currency = currencyBox.Text;
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
            if (this.connect.add(c))
            {
                //新增資料成功
                this.customers.Add(c);
                reset();
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
            //TODO
        }

        /// <summary>
        /// 上一筆資料按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void preButton_Click(object sender, EventArgs e)
        {
            //TODO
        }

        /// <summary>
        /// 下一筆資料按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void nextButton_Click(object sender, EventArgs e)
        {
            //TODO
        }

        /// <summary>
        /// 最後一筆資料按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void lastButton_Click(object sender, EventArgs e)
        {
            //TODO
        }

        /// <summary>
        /// 導覽列數字改變的時候
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void pageTextBox_TextChanged(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
