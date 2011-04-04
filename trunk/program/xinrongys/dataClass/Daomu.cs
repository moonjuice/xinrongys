using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace xinrongys
{
    #region Daomu
    public class Daomu
    {
        #region Member Variables
        protected string id;
        protected int type;
        protected int cabinet;
        protected int d_long;
        protected int d_width;
        protected int d_round;
        protected int l_m;
        protected int l_d;
        protected int w_m;
        protected int w_d;
        #endregion
        #region Constructors
        public Daomu() { }
        public Daomu(MySqlDataReader myData) 
        {
            this.id = myData.GetString(0);
            this.type = (int)myData.GetDecimal(1);
            this.cabinet = (int)myData.GetDecimal(2);
            this.d_long = (int)myData.GetDecimal(3);
            this.d_width = (int)myData.GetDecimal(4);
            this.d_round = (int)myData.GetDecimal(5);
            this.l_m = (int)myData.GetDecimal(6);
            this.l_d = (int)myData.GetDecimal(7);
            this.w_m = (int)myData.GetDecimal(8);
            this.w_d = (int)myData.GetDecimal(9);
        }
        public Daomu(int type, int cabinet, int d_long, int d_width, int d_round, int l_m, int l_d, int w_m, int w_d)
        {
            this.type = type;
            this.cabinet = cabinet;
            this.d_long = d_long;
            this.d_width = d_width;
            this.d_round = d_round;
            this.l_m = l_m;
            this.l_d = l_d;
            this.w_m = w_m;
            this.w_d = w_d;
        }
        #endregion
        #region Public Properties
        public virtual string _Id
        {
            get { return id; }
            set { id = value; }
        }
        public virtual int _Type
        {
            get { return type; }
            set { type = value; }
        }
        public virtual int _Cabinet
        {
            get { return cabinet; }
            set { cabinet = value; }
        }
        public virtual int _D_long
        {
            get { return d_long; }
            set { d_long = value; }
        }
        public virtual int _D_width
        {
            get { return d_width; }
            set { d_width = value; }
        }
        public virtual int _D_round
        {
            get { return d_round; }
            set { d_round = value; }
        }
        public virtual int _L_m
        {
            get { return l_m; }
            set { l_m = value; }
        }
        public virtual int _L_d
        {
            get { return l_d; }
            set { l_d = value; }
        }
        public virtual int _W_m
        {
            get { return w_m; }
            set { w_m = value; }
        }
        public virtual int _W_d
        {
            get { return w_d; }
            set { w_d = value; }
        }
        static public List<string> getColumnHeader()
        {
            List<string> header = new List<string>();
            header.Add("¤M¼Ò½s¸¹");
            header.Add("¤M¼ÒºØÃþ");
            return header;
        }
        public List<string> getRow()
        {
            List<string> column = new List<string>();
            column.Add(this.id);
            column.Add(this.type.ToString());
            return column;
        }
        public List<string> getSQLStruct()
        {
            List<string> column = new List<string>();
            column.Add("id");
            column.Add("type");
            column.Add("cabinet");
            column.Add("d_long");
            column.Add("d_width");
            column.Add("d_round");
            column.Add("l_m");
            column.Add("l_d");
            column.Add("w_m");
            column.Add("w_d");
            return column;
        }
        public List<string> getSQLData()
        {
            List<string> column = new List<string>();
            column.Add(this.id);
            column.Add(this.type.ToString());
            column.Add(this.cabinet.ToString());
            column.Add(this.d_long.ToString());
            column.Add(this.d_width.ToString());
            column.Add(this.d_round.ToString());
            column.Add(this.l_m.ToString());
            column.Add(this.l_d.ToString());
            column.Add(this.w_m.ToString());
            column.Add(this.w_d.ToString());
            return column;
        }
        #endregion
    }
    #endregion
}