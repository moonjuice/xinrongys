using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

#region Supplier
public class Supplier
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
	#endregion
	#region Constructors
	public Supplier() { }
	public Supplier(string name, string shortname, string contacter, int mobile, string phone1, int ext1, string phone2, int ext2, string province, string city, string town, string village, string district, string zone, string addr, string mail, string b_name, string b_account, int day, string currency)
	{
		this.name=name;
		this.shortname=shortname;
		this.contacter=contacter;
		this.mobile=mobile;
		this.phone1=phone1;
		this.ext1=ext1;
		this.phone2=phone2;
		this.ext2=ext2;
		this.province=province;
		this.city=city;
		this.town=town;
		this.village=village;
		this.district=district;
		this.zone=zone;
		this.addr=addr;
		this.mail=mail;
		this.b_name=b_name;
		this.b_account=b_account;
		this.day=day;
		this.currency=currency;
	}
	#endregion
	#region Public Properties
	public virtual string _Id
	{
		get {return id;}
		set {id=value;}
	}
	public virtual string _Name
	{
		get {return name;}
		set {name=value;}
	}
	public virtual string _Shortname
	{
		get {return shortname;}
		set {shortname=value;}
	}
	public virtual string _Contacter
	{
		get {return contacter;}
		set {contacter=value;}
	}
	public virtual int _Mobile
	{
		get {return mobile;}
		set {mobile=value;}
	}
	public virtual string _Phone1
	{
		get {return phone1;}
		set {phone1=value;}
	}
	public virtual int _Ext1
	{
		get {return ext1;}
		set {ext1=value;}
	}
	public virtual string _Phone2
	{
		get {return phone2;}
		set {phone2=value;}
	}
	public virtual int _Ext2
	{
		get {return ext2;}
		set {ext2=value;}
	}
	public virtual string _Province
	{
		get {return province;}
		set {province=value;}
	}
	public virtual string _City
	{
		get {return city;}
		set {city=value;}
	}
	public virtual string _Town
	{
		get {return town;}
		set {town=value;}
	}
	public virtual string _Village
	{
		get {return village;}
		set {village=value;}
	}
	public virtual string _District
	{
		get {return district;}
		set {district=value;}
	}
	public virtual string _Zone
	{
		get {return zone;}
		set {zone=value;}
	}
	public virtual string _Addr
	{
		get {return addr;}
		set {addr=value;}
	}
	public virtual string _Mail
	{
		get {return mail;}
		set {mail=value;}
	}
	public virtual string _B_name
	{
		get {return b_name;}
		set {b_name=value;}
	}
	public virtual string _B_account
	{
		get {return b_account;}
		set {b_account=value;}
	}
	public virtual int _Day
	{
		get {return day;}
		set {day=value;}
	}
	public virtual string _Currency
	{
		get {return currency;}
		set {currency=value;}
	}
	#endregion
}
#endregion
