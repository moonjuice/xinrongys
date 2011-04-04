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
        private ConnectForm cnf;
        private CustomerForm cf;
        private SupplierForm sf;
        private DaomuForm df;
        private MakingForm mf;
        private List<Customer> customers = new List<Customer>();
        private List<Supplier> suppliers = new List<Supplier>();
        private List<Making> makings = new List<Making>();
        private List<Daomu> daomus = new List<Daomu>();
        public MainForm()
        {
            InitializeComponent();
            #region 初始化表格
            customerView.ColumnCount = Customer.getColumnHeader().Count;
            supplierView.ColumnCount = Supplier.getColumnHeader().Count;
            makingView.ColumnCount = Making.getColumnHeader().Count;
            daomuView.ColumnCount = Daomu.getColumnHeader().Count;
            for (int i = 0; i < Customer.getColumnHeader().Count; i++)
            {
                customerView.Columns[i].Name = Customer.getColumnHeader()[i];
            }
            for (int i = 0; i < Supplier.getColumnHeader().Count; i++)
            {
                supplierView.Columns[i].Name = Supplier.getColumnHeader()[i];
            }
            for (int i = 0; i < Making.getColumnHeader().Count; i++)
            {
                makingView.Columns[i].Name = Making.getColumnHeader()[i];
            }
            for (int i = 0; i < Daomu.getColumnHeader().Count; i++)
            {
                daomuView.Columns[i].Name = Daomu.getColumnHeader()[i];
            }
            #endregion
        }

        /// <summary>
        /// 按下連線至資料庫
        /// </summary>
        private void connectMenuItem_Click(object sender, EventArgs e)
        {
            cnf = new ConnectForm();
            cnf.FormClosed += new FormClosedEventHandler(cnf_FormClosed);
            cnf.Show();
        }

        /// <summary>
        /// 連線視窗關閉要做的事情
        /// </summary>
        private void cnf_FormClosed(object sender, EventArgs e)
        {
            connect = cnf.getConnector();
            if (connect != null)
            {
                freshData("all");
                freshView("all");
            }
        }

        /// <summary>
        /// 重新整理資料
        /// </summary>
        /// <param name="tableName">要整理的表格名稱</param>
        private void freshData(string tableName)
        {
            switch(tableName)
            {
                case "all" :
                    freshData("customer");
                    freshData("supplier");
                    freshData("making");
                    freshData("daomu");
                    break;
                case "customer":
                    customers.Clear();
                    customers = connect.getCustomers();
                    break;
                case "supplier":
                    suppliers.Clear();
                    suppliers = connect.getSuppliers();
                    break;
                case "making":
                    makings.Clear();
                    makings = connect.getMakings();
                    break;
                case "daomu":
                    daomus.Clear();
                    daomus = connect.getDaomus();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 重新整理顯示頁面
        /// </summary>
        /// <param name="tableName">要整理的表格名稱</param>
        private void freshView(string tableName)
        {
            switch (tableName)
            {
                case "all":
                    freshView("customer");
                    freshView("supplier");
                    freshView("making");
                    freshView("daomu");
                    break;
                case "customer":
                    customerView.Rows.Clear();
                    foreach(Customer c in customers)
                    {
                        customerView.Rows.Add(c.getRow().ToArray());
                    }
                    break;
                case "supplier":
                    supplierView.Rows.Clear();
                    foreach (Supplier s in suppliers)
                    {
                        supplierView.Rows.Add(s.getRow().ToArray());
                    }
                    break;
                case "making":
                    makingView.Rows.Clear();
                    foreach (Making m in makings)
                    {
                        makingView.Rows.Add(m.getRow().ToArray());
                    }
                    break;
                case "daomu":
                    daomuView.Rows.Clear();
                    foreach (Daomu d in daomus)
                    {
                        daomuView.Rows.Add(d.getRow().ToArray());
                    }
                    break;
                default:
                    //doNothing
                    break;
            }
        }

        /// <summary>
        /// 新增客戶
        /// </summary>
        private void addCustomerMenuItem_Click(object sender, EventArgs e)
        {
            cf = new CustomerForm();
            cf.Connect = this.connect;
            cf.Customers = this.customers;
            cf.FormClosed += new FormClosedEventHandler(cf_FormClosed);
            cf.Show();
        }

        /// <summary>
        /// 編輯客戶資料
        /// </summary>
        private void editCustomerMenuItem_Click(object sender, EventArgs e)
        {
            int i = customerView.SelectedRows[customerView.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1].Index;
            if (i < customers.Count)
            {
                cf = new CustomerForm();
                cf.Connect = this.connect;
                cf.Customers = this.customers;
                cf.setIndex(i);
                cf.FormClosed += new FormClosedEventHandler(cf_FormClosed);
                cf.Show();
            }
        }

        /// <summary>
        /// 刪除客戶資料
        /// </summary>
        private void delCustomerMenuItem_Click(object sender, EventArgs e)
        {
            int index = customerView.SelectedRows[customerView.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1].Index;
            if (index < customers.Count)
            {
                string message = "你確定要刪除客戶編號：" + customers[index]._Id + "，\n客戶名稱：" + customers[index]._Name + "這筆資料？";
                string caption = "刪除客戶資料";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons,MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (connect.del(customers[index]))
                    {
                        customers.RemoveAt(index);
                        freshView("customer");
                    }
                }
            }            
        }

        /// <summary>
        /// 重新整理客戶頁面
        /// </summary>
        private void refreshCustomerMenuItem_Click(object sender, EventArgs e)
        {
            if (connect != null)
            {
                freshData("customer");
                freshView("customer");
            }
        }

        /// <summary>
        /// 客戶基本資料視窗關閉要做的事情
        /// </summary>
        private void cf_FormClosed(object sender, EventArgs e)
        {
            this.customers = cf.Customers;
            freshView("customer");
        }

        /// <summary>
        /// 新增供應商資料
        /// </summary>
        private void addSupplierMenuItem_Click(object sender, EventArgs e)
        {
            sf = new SupplierForm();
            sf.Connect = this.connect;
            sf.Suppliers = this.suppliers;
            sf.FormClosed += new FormClosedEventHandler(sf_FormClosed);
            sf.Show();
        }

        /// <summary>
        /// 修改供應商資料
        /// </summary>
        private void editSupplierMenuItem_Click(object sender, EventArgs e)
        {
            int i = this.supplierView.SelectedRows[supplierView.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1].Index;
            if (i < suppliers.Count)
            {
                sf = new SupplierForm();
                sf.Connect = this.connect;
                sf.Suppliers = this.suppliers;
                sf.setIndex(i);
                sf.FormClosed += new FormClosedEventHandler(sf_FormClosed);
                sf.Show();
            }
        }

        /// <summary>
        /// 刪除供應商資料
        /// </summary>
        private void delSupplierMenuItem_Click(object sender, EventArgs e)
        {
            int index = supplierView.SelectedRows[supplierView.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1].Index;
            if (index < suppliers.Count)
            {
                string message = "你確定要刪除供應商編號：" + suppliers[index]._Id + "，\n供應商名稱：" + suppliers[index]._Name + "這筆資料？";
                string caption = "刪除供應商資料";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (connect.del(suppliers[index]))
                    {
                        suppliers.RemoveAt(index);
                        freshView("supplier");
                    }
                }
            }
        }

        /// <summary>
        /// 重新整理供應商資料
        /// </summary>
        private void refreshSupplierMenuItem_Click(object sender, EventArgs e)
        {
            if (connect != null)
            {
                freshData("supplier");
                freshView("supplier");
            }
        }

        /// <summary>
        /// 供應商基本資料視窗關閉要做的事情
        /// </summary>
        private void sf_FormClosed(object sender, EventArgs e)
        {
            this.suppliers = sf.Suppliers;
            freshView("supplier");
        }
        
        /// <summary>
        /// 新增材料資料
        /// </summary>
        private void addMakingMenuItem_Click(object sender, EventArgs e)
        {
            mf = new MakingForm();
            mf.Connect = this.connect;
            mf.Makings = this.makings;
            mf.FormClosed += new FormClosedEventHandler(mf_FormClosed);
            mf.Show();
        }

        /// <summary>
        /// 修改材料資料
        /// </summary>
        private void editMakingMenuItem_Click(object sender, EventArgs e)
        {
            int index = makingView.SelectedRows[makingView.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1].Index;
            if (index < makings.Count)
            {
                mf = new MakingForm();
                mf.Connect = this.connect;
                mf.Makings = this.makings;
                mf.setIndex(index);
                mf.FormClosed += new FormClosedEventHandler(mf_FormClosed);
                mf.Show();
            }            
        }

        /// <summary>
        /// 刪除材料資料
        /// </summary>
        private void delMakingMenuItem_Click(object sender, EventArgs e)
        {
            int index = makingView.SelectedRows[makingView.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1].Index;
            if (index < makings.Count)
            {
                string message = "你確定要刪除材料編號：" + makings[index]._Id + "，\n材料名稱：" + makings[index]._Name + "這筆資料？";
                string caption = "刪除材料資料";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (connect.del(makings[index]))
                    {
                        makings.RemoveAt(index);
                        freshView("making");
                    }
                }
            }
        }

        /// <summary>
        /// 重新整理材料資料
        /// </summary>
        private void refreshMakingMenuItem_Click(object sender, EventArgs e)
        {
            if (connect != null)
            {
                freshData("making");
                freshView("making");
            }
        }

        /// <summary>
        /// 材料基本資料視窗關閉要做的事情
        /// </summary>
        private void mf_FormClosed(object sender, EventArgs e)
        {
            this.makings = mf.Makings;
            freshView("making");
        }
        
        /// <summary>
        /// 新增刀模資料
        /// </summary>
        private void addDaomuMenuItem_Click(object sender, EventArgs e)
        {
            df = new DaomuForm();
            df.Connect = this.connect;
            df.Daomus = this.daomus;
            df.FormClosed += new FormClosedEventHandler(df_FormClosed);
            df.Show();
        }

        /// <summary>
        /// 修改刀模資料
        /// </summary>
        private void editDaomuMenuItem_Click(object sender, EventArgs e)
        {
            int index = daomuView.SelectedRows[daomuView.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1].Index;
            if (index < daomus.Count)
            {
                df = new DaomuForm();
                df.Connect = this.connect;
                df.Daomus = this.daomus;
                df.setIndex(index);
                df.FormClosed += new FormClosedEventHandler(df_FormClosed);
                df.Show();
            }
        }

        /// <summary>
        /// 刪除刀模資料
        /// </summary>
        private void delDaomuMenuItem_Click(object sender, EventArgs e)
        {
            int index = daomuView.SelectedRows[daomuView.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1].Index;
            if (index < daomus.Count)
            {
                string message = "你確定要刪除刀模編號：" + daomus[index]._Id + "，\n刀模櫃號：" + daomus[index]._Cabinet + "這筆資料？";
                string caption = "刪除刀模資料";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (connect.del(daomus[index]))
                    {
                        daomus.RemoveAt(index);
                        freshView("daomu");
                    }
                }
            }
        }

        /// <summary>
        /// 重新整理刀模資料
        /// </summary>
        private void refreshDaomuMenuItem_Click(object sender, EventArgs e)
        {
            if (connect != null)
            {
                freshData("daomu");
                freshView("daomu");
            }
        }

        /// <summary>
        /// 刀模基本資料視窗關閉要做的事情
        /// </summary>
        private void df_FormClosed(object sender, EventArgs e)
        {
            this.daomus = df.Daomus;
            freshView("daomu");
        }
    }
}
