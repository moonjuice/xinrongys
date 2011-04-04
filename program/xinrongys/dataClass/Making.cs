using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace xinrongys
{
    #region Making
    public class Making
    {
        #region Member Variables
        protected string id;
        protected string name;
        protected string s_id;
        protected int type;
        protected int unit;
        protected int price;
        #endregion
        #region Constructors
        public Making() { }
        public Making(MySqlDataReader myData) 
        {
            this.id = myData.GetString(0);
            this.name = myData.GetString(1);
            this.s_id = myData.GetString(2);
            this.type = (int)myData.GetDecimal(3);
            this.unit = (int)myData.GetDecimal(4);
            this.price = (int)myData.GetDecimal(5);
        }
        public Making(string name, string s_id, int type, int unit, int price)
        {
            this.name = name;
            this.s_id = s_id;
            this.type = type;
            this.unit = unit;
            this.price = price;
        }
        #endregion
        #region Public Properties
        public virtual string _Id
        {
            get { return id; }
            set { id = value; }
        }
        public virtual string _Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual string _S_id
        {
            get { return s_id; }
            set { s_id = value; }
        }
        public virtual int _Type
        {
            get { return type; }
            set { type = value; }
        }
        public virtual int _Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public virtual int _Price
        {
            get { return price; }
            set { price = value; }
        }
        static public List<string> getColumnHeader()
        {
            List<string> header = new List<string>();
            header.Add("材料編號");
            header.Add("材料名稱");
            return header;
        }
        public List<string> getRow()
        {
            List<string> column = new List<string>();
            column.Add(this.id);
            column.Add(this.name);
            return column;
        }
        public List<string> getSQLStruct()
        {
            List<string> column = new List<string>();
            column.Add("id");
            column.Add("name");
            column.Add("s_id");
            column.Add("type");
            column.Add("unit");
            column.Add("price");
            return column;
        }
        public List<string> getSQLData()
        {
            List<string> column = new List<string>();
            column.Add(this.id);
            column.Add(this.name);
            column.Add(this.s_id);
            column.Add(this.type.ToString());
            column.Add(this.unit.ToString());
            column.Add(this.price.ToString());
            return column;
        }
        #endregion
    }
    #endregion
}