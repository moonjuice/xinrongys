using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace xinrongys
{
    #region Customer
    public class Customer
    {
        #region Member Variables
        protected string id;
        protected string name;
        protected string shortname;
        protected string contacter;
        protected int mobile;
        protected string phone1;
        protected int ext1;
        protected string phone2;
        protected int ext2;
        protected string province;
        protected string city;
        protected string town;
        protected string village;
        protected string district;
        protected string zone;
        protected string addr;
        protected string mail;
        protected string b_name;
        protected string b_account;
        protected int day;
        protected string currency;
        protected string fax;
        protected int ext3;
        #endregion
        #region Constructors
        public Customer() { }
        public Customer(MySqlDataReader myData) 
        {
            this.id = myData.GetString(0);
            this.name = myData.GetString(1);
            this.shortname = myData.GetString(2);
            this.contacter = myData.GetString(3);
            this.mobile = (int)myData.GetDecimal(4);
            this.phone1 = myData.GetString(5);
            this.ext1 = (int)myData.GetDecimal(6); ;
            this.phone2 = myData.GetString(7);
            this.ext2 = (int)myData.GetDecimal(8);
            this.province = myData.GetString(9);
            this.city = myData.GetString(10);
            this.town = myData.GetString(11);
            this.village = myData.GetString(12);
            this.district = myData.GetString(13);
            this.zone = myData.GetString(14);
            this.addr = myData.GetString(15);
            this.mail = myData.GetString(16);
            this.b_name = myData.GetString(17);
            this.b_account = myData.GetString(18);
            this.day = (int)myData.GetDecimal(19);
            this.currency = myData.GetString(20);
            this.fax = myData.GetString(21);
            this.ext3 = (int)myData.GetDecimal(22);
        }
        public Customer(string id,string name, string shortname, string contacter, int mobile, string phone1, int ext1, string phone2, int ext2, string province, string city, string town, string village, string district, string zone, string addr, string mail, string b_name, string b_account, int day, string currency,string fax,int ext3)
        {
            this.id = id;
            this.name = name;
            this.shortname = shortname;
            this.contacter = contacter;
            this.mobile = mobile;
            this.phone1 = phone1;
            this.ext1 = ext1;
            this.phone2 = phone2;
            this.ext2 = ext2;
            this.province = province;
            this.city = city;
            this.town = town;
            this.village = village;
            this.district = district;
            this.zone = zone;
            this.addr = addr;
            this.mail = mail;
            this.b_name = b_name;
            this.b_account = b_account;
            this.day = day;
            this.currency = currency;
            this.fax = fax;
            this.ext3 = ext3;
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
        public virtual string _Shortname
        {
            get { return shortname; }
            set { shortname = value; }
        }
        public virtual string _Contacter
        {
            get { return contacter; }
            set { contacter = value; }
        }
        public virtual int _Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        public virtual string _Phone1
        {
            get { return phone1; }
            set { phone1 = value; }
        }
        public virtual int _Ext1
        {
            get { return ext1; }
            set { ext1 = value; }
        }
        public virtual string _Phone2
        {
            get { return phone2; }
            set { phone2 = value; }
        }
        public virtual int _Ext2
        {
            get { return ext2; }
            set { ext2 = value; }
        }
        public virtual int _Ext3
        {
            get { return ext3; }
            set { ext3 = value; }
        }
        public virtual string _Province
        {
            get { return province; }
            set { province = value; }
        }
        public virtual string _City
        {
            get { return city; }
            set { city = value; }
        }
        public virtual string _Town
        {
            get { return town; }
            set { town = value; }
        }
        public virtual string _Village
        {
            get { return village; }
            set { village = value; }
        }
        public virtual string _District
        {
            get { return district; }
            set { district = value; }
        }
        public virtual string _Zone
        {
            get { return zone; }
            set { zone = value; }
        }
        public virtual string _Addr
        {
            get { return addr; }
            set { addr = value; }
        }
        public virtual string _Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public virtual string _B_name
        {
            get { return b_name; }
            set { b_name = value; }
        }
        public virtual string _B_account
        {
            get { return b_account; }
            set { b_account = value; }
        }
        public virtual int _Day
        {
            get { return day; }
            set { day = value; }
        }
        public virtual string _Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        public virtual string _Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        static public List<string> getColumnHeader()
        {
            List<string> header = new List<string>();
            header.Add("客戶編號");
            header.Add("客戶名稱");
            header.Add("聯絡人");
            header.Add("聯絡人手機");
            return header;
        }
        public List<string> getRow()
        {
            List<string> row = new List<string>();
            row.Add(this.id);
            row.Add(this.name);
            row.Add(this.contacter);
            row.Add(this.mobile.ToString());
            return row;
        }
        public List<string> getSQLStruct()
        {
            List<string> column = new List<string>();
            column.Add("id");
            column.Add("name");
            column.Add("shortname");
            column.Add("contacter");
            column.Add("mobile");
            column.Add("phone1");
            column.Add("ext1");
            column.Add("phone2");
            column.Add("ext2");
            column.Add("province");
            column.Add("city");
            column.Add("town");
            column.Add("village");
            column.Add("district");
            column.Add("zone");
            column.Add("addr");
            column.Add("mail");
            column.Add("b_name");
            column.Add("b_account");
            column.Add("day");
            column.Add("currency");
            column.Add("fax");
            column.Add("ext3");
            return column;
        }
        public List<string> getSQLData()
        {
            List<string> column = new List<string>();
            column.Add(this.id);
            column.Add(this.name);
            column.Add(this.shortname);
            column.Add(this.contacter);
            column.Add(this.mobile.ToString());
            column.Add(this.phone1);
            column.Add(this.ext1.ToString());
            column.Add(this.phone2);
            column.Add(this.ext2.ToString());
            column.Add(this.province);
            column.Add(this.city);
            column.Add(this.town);
            column.Add(this.village);
            column.Add(this.district);
            column.Add(this.zone);
            column.Add(this.addr);
            column.Add(this.mail);
            column.Add(this.b_name);
            column.Add(this.b_account);
            column.Add(this.day.ToString());
            column.Add(this.currency);
            column.Add(this.fax);
            column.Add(this.ext3.ToString());
            return column;
        }
        #endregion
    }
    #endregion
}