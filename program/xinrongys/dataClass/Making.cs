using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace xinrongys
{
    #region Making
    public class Making
    {
        #region Member Variables
        protected string id;
        protected string name;
        protected string s_id;
        protected string type;
        protected string unit;
        protected int price;
        #endregion
        #region Constructors
        public Making() { }
        public Making(string name, string s_id, string type, string unit, int price)
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
        public virtual string _Type
        {
            get { return type; }
            set { type = value; }
        }
        public virtual string _Unit
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
        #endregion
    }
    #endregion
}