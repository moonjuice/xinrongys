using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace xinrongys
{
    #region Daomu
    public class Daomu
    {
        #region Member Variables
        protected string id;
        protected string type;
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
        public Daomu(string type, int cabinet, int d_long, int d_width, int d_round, int l_m, int l_d, int w_m, int w_d)
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
        public virtual string _Type
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
            column.Add(this.type);
            return column;
        }
        #endregion
    }
    #endregion
}