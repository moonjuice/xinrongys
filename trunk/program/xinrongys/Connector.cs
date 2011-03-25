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
        public List<T> getRowDatas(string tableName)
        {
            switch (tableName)
            {
                case "customer":
                    List<Customer> cs = new List<Customer>();
                    return cs;
                case "supplier":
                    List<Customer> ss = new List<Customer>();
                    return ss;
                case "making":
                    List<Customer> ms = new List<Customer>();
                    return ms;                    
                case "daomu":
                    List<Customer> ds = new List<Customer>();
                    return ds;
                default:
                    return null;
            }
        }
        #endregion

    }
}
