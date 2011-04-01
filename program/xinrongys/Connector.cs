using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace xinrongys
{
    public class Connector
    {
        #region Member Variables
        private string host;
        private string name;
        private string password;
        private string dbname = "xinrongys";
        private MySqlConnection conn;
        #endregion

        #region Constructors
        public Connector(string host, string name, string password)
        {
            this.host = host;
            this.name = name;
            this.password = password;
        }
        #endregion

        #region Public Method
        public bool connect()
        {
            bool result = true;
            if (host == null || name == null || password == null)
            {
                MessageBox.Show("無法連線到資料庫");
                result = false;
            }
            else
            {
                // 如果有特殊的編碼在database後面請加上;CharSet=編碼, utf8請使用utf8_general_ci 
                string connStr = "server=" + host + ";uid=" + name + ";pwd=" + password + ";database=" + dbname + ";CharSet=utf8";
                conn = new MySqlConnection(connStr);

                // 連線到資料庫
                try
                {
                    conn.Open();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("無法連線到資料庫");
                            break;
                        case 1045:
                            MessageBox.Show("使用者帳號或密碼錯誤,請再試一次");
                            break;
                        default:
                            MessageBox.Show("無法連線到資料庫，錯誤代碼："+ex.Number);
                            break;
                    }
                    result = false;
                }
            }
            return result;
        }
        public List<Customer> getCustomers()
        {
            string sqlString = "select * from customer order by id desc";
            List<Customer> cs = new List<Customer>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlString, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                if (!myData.HasRows)
                {
                    // 如果沒有資料,顯示沒有資料的訊息 
                    MessageBox.Show("目前沒有客戶資料!!");
                }
                else
                {
                    while (myData.Read())
                    {
                        cs.Add(new Customer(myData));
                    }
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("錯誤代碼： " + ex.Number + "\n 錯誤訊息 : " + ex.Message);
            }
            return cs;
        }
        public List<Supplier> getSuppliers()
        {
            string sqlString = "select * from supplier order by id desc";
            List<Supplier> ss = new List<Supplier>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlString, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                if (!myData.HasRows)
                {
                    // 如果沒有資料,顯示沒有資料的訊息 
                    MessageBox.Show("目前沒有供應商資料!!");
                }
                else
                {
                    while (myData.Read())
                    {
                        ss.Add(new Supplier(myData));
                    }                    
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("錯誤代碼： " + ex.Number + "\n 錯誤訊息 : " + ex.Message);
            }
            return ss;            
        }
        public List<Making> getMakings()
        {
            string sqlString = "select * from making order by id desc";
            List<Making> ms = new List<Making>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlString, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                if (!myData.HasRows)
                {
                    // 如果沒有資料,顯示沒有資料的訊息 
                    MessageBox.Show("目前沒有材料資料!!");
                }
                else
                {
                    while (myData.Read())
                    {
                        ms.Add(new Making(myData));
                    }
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("錯誤代碼： " + ex.Number + "\n 錯誤訊息 : " + ex.Message);
            }
            return ms;
        }
        public List<Daomu> getDaomus()
        {
            string sqlString = "select * from daomu order by id desc";
            List<Daomu> ds = new List<Daomu>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlString, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                if (!myData.HasRows)
                {
                    // 如果沒有資料,顯示沒有資料的訊息 
                    MessageBox.Show("目前沒有刀模資料!!");
                }
                else
                {
                    while (myData.Read())
                    {
                        ds.Add(new Daomu(myData));
                    }
                }
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("錯誤代碼： " + ex.Number + "\n 錯誤訊息 : " + ex.Message);
            }
            return ds;
        }
        public bool add(Customer c)
        {
            bool result = false;
            string addSQL = "INSERT INTO customer (";
            foreach (string s in c.getSQLStruct())
                addSQL = addSQL + s + ",";
            addSQL = addSQL.Substring(0, addSQL.Length - 1);
            addSQL = addSQL + ") VALUES (";
            foreach (string s in c.getSQLData())
                addSQL = addSQL + "'" + s + "',";
            addSQL = addSQL.Substring(0, addSQL.Length - 1);
            addSQL = addSQL + ")";
            try
            {
                MySqlCommand cmd = new MySqlCommand(addSQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                result = true;
                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("錯誤代碼： " + ex.Number + "\n 錯誤訊息 : " + ex.Message);
            }
            return result;
        }
        #endregion

    }
}
