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
            cf = new ConnectForm();
            cf.FormClosed += new FormClosedEventHandler(cf_FormClosed);
            cf.Show();
        }

        /// <summary>
        /// 連線視窗關閉要做的事情
        /// </summary>
        private void cf_FormClosed(object sender, EventArgs e)
        {
            connect = cf.getConnector();
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
                        customerView.Rows.Add(c.getRow());
                    }
                    break;
                case "supplier":
                    supplierView.Rows.Clear();
                    foreach (Supplier s in suppliers)
                    {
                        supplierView.Rows.Add(s.getRow());
                    }
                    break;
                case "making":
                    makingView.Rows.Clear();
                    foreach (Making m in makings)
                    {
                        makingView.Rows.Add(m.getRow());
                    }
                    break;
                case "daomu":
                    daomuView.Rows.Clear();
                    foreach (Daomu d in daomus)
                    {
                        daomuView.Rows.Add(d.getRow());
                    }
                    break;
                default:
                    //doNothing
                    break;
            }
        }
    }
}
