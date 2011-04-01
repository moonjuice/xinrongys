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
        /// <summary>
        /// 取得客戶資料集
        /// </summary>
        /// <returns>客戶資料集</returns>
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
        /// <summary>
        /// 取得供應商資料集
        /// </summary>
        /// <returns>供應商資料集</returns>
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
        /// <summary>
        /// 取得材料資料集
        /// </summary>
        /// <returns>材料資料集</returns>
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
        /// <summary>
        /// 取得刀模資料集
        /// </summary>
        /// <returns>刀模資料集</returns>
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
        #region 新增資料
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
        public bool add(Supplier s)
        {
            bool result = false;
            string addSQL = "INSERT INTO supplier (";
            foreach (string ss in s.getSQLStruct())
                addSQL = addSQL + ss + ",";
            addSQL = addSQL.Substring(0, addSQL.Length - 1);
            addSQL = addSQL + ") VALUES (";
            foreach (string ss in s.getSQLData())
                addSQL = addSQL + "'" + ss + "',";
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
        public bool add(Daomu d)
        {
            bool result = false;
            string addSQL = "INSERT INTO daomu (";
            foreach (string s in d.getSQLStruct())
                addSQL = addSQL + s + ",";
            addSQL = addSQL.Substring(0, addSQL.Length - 1);
            addSQL = addSQL + ") VALUES (";
            foreach (string s in d.getSQLData())
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
        public bool add(Making m)
        {
            bool result = false;
            string addSQL = "INSERT INTO making (";
            foreach (string s in m.getSQLStruct())
                addSQL = addSQL + s + ",";
            addSQL = addSQL.Substring(0, addSQL.Length - 1);
            addSQL = addSQL + ") VALUES (";
            foreach (string s in m.getSQLData())
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
        #region 修改資料
        public bool edit(Customer c)
        {
            bool result = false;
            string addSQL = "UPDATE customer SET ";
            for (int i=0;i<c.getSQLStruct().Count;i++)
            {
                addSQL = addSQL + c.getSQLStruct().ElementAt(i) + " = '"+c.getSQLData().ElementAt(i)+"',";
            }
            addSQL = addSQL.Substring(0,addSQL.Length-1);
            addSQL = addSQL + " WHERE id = "+c._Id;
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
        public bool edit(Supplier s)
        {
            bool result = false;
            string addSQL = "UPDATE supplier SET ";
            for (int i = 0; i < s.getSQLStruct().Count; i++)
            {
                addSQL = addSQL + s.getSQLStruct().ElementAt(i) + " = '" + s.getSQLData().ElementAt(i) + "',";
            }
            addSQL = addSQL.Substring(0, addSQL.Length - 1);
            addSQL = addSQL + " WHERE id = " + s._Id;
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
        public bool edit(Daomu d)
        {
            bool result = false;
            string addSQL = "UPDATE daomu SET ";
            for (int i = 0; i < d.getSQLStruct().Count; i++)
            {
                addSQL = addSQL + d.getSQLStruct().ElementAt(i) + " = '" + d.getSQLData().ElementAt(i) + "',";
            }
            addSQL = addSQL.Substring(0, addSQL.Length - 1);
            addSQL = addSQL + " WHERE id = " + d._Id;
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
        public bool edit(Making m)
        {
            bool result = false;
            string addSQL = "UPDATE making SET ";
            for (int i = 0; i < m.getSQLStruct().Count; i++)
            {
                addSQL = addSQL + m.getSQLStruct().ElementAt(i) + " = '" + m.getSQLData().ElementAt(i) + "',";
            }
            addSQL = addSQL.Substring(0, addSQL.Length - 1);
            addSQL = addSQL + " WHERE id = " + m._Id;
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
        #region 刪除資料
        public bool del(Customer c)
        {
            bool result = false;
            string addSQL = "DELETE FROM customer WHERE id='"+c._Id+"'";
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
        public bool del(Supplier s)
        {
            bool result = false;
            string addSQL = "DELETE FROM supplier WHERE id='" + s._Id + "'";
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
        public bool del(Daomu d)
        {
            bool result = false;
            string addSQL = "DELETE FROM daomu WHERE id='" + d._Id + "'";
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
        public bool del(Making m)
        {
            bool result = false;
            string addSQL = "DELETE FROM making WHERE id='" + m._Id + "'";
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
        #endregion

    }
}
