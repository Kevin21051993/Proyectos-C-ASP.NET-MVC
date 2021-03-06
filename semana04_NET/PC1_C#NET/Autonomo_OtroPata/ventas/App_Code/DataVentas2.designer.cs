﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bdventas")]
public partial class DataVentas2DataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Definiciones de métodos de extensibilidad
  partial void OnCreated();
  partial void InsertArticulos(Articulos instance);
  partial void UpdateArticulos(Articulos instance);
  partial void DeleteArticulos(Articulos instance);
  partial void InsertClientes(Clientes instance);
  partial void UpdateClientes(Clientes instance);
  partial void DeleteClientes(Clientes instance);
  partial void InsertFac_cabe(Fac_cabe instance);
  partial void UpdateFac_cabe(Fac_cabe instance);
  partial void DeleteFac_cabe(Fac_cabe instance);
  partial void InsertFac_deta(Fac_deta instance);
  partial void UpdateFac_deta(Fac_deta instance);
  partial void DeleteFac_deta(Fac_deta instance);
  partial void InsertVendedor(Vendedor instance);
  partial void UpdateVendedor(Vendedor instance);
  partial void DeleteVendedor(Vendedor instance);
  #endregion
	
	public DataVentas2DataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["bdventasConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataVentas2DataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataVentas2DataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataVentas2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataVentas2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Articulos> Articulos
	{
		get
		{
			return this.GetTable<Articulos>();
		}
	}
	
	public System.Data.Linq.Table<Clientes> Clientes
	{
		get
		{
			return this.GetTable<Clientes>();
		}
	}
	
	public System.Data.Linq.Table<Fac_cabe> Fac_cabe
	{
		get
		{
			return this.GetTable<Fac_cabe>();
		}
	}
	
	public System.Data.Linq.Table<Fac_deta> Fac_deta
	{
		get
		{
			return this.GetTable<Fac_deta>();
		}
	}
	
	public System.Data.Linq.Table<Vendedor> Vendedor
	{
		get
		{
			return this.GetTable<Vendedor>();
		}
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SPDETA")]
	public ISingleResult<SPDETAResult> SPDETA([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FAC", DbType="Char(5)")] string fAC)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fAC);
		return ((ISingleResult<SPDETAResult>)(result.ReturnValue));
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Articulos")]
public partial class Articulos : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _art_cod;
	
	private string _art_nom;
	
	private string _art_uni;
	
	private System.Nullable<decimal> _art_pre;
	
	private System.Nullable<int> _art_stk;
	
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onart_codChanging(string value);
    partial void Onart_codChanged();
    partial void Onart_nomChanging(string value);
    partial void Onart_nomChanged();
    partial void Onart_uniChanging(string value);
    partial void Onart_uniChanged();
    partial void Onart_preChanging(System.Nullable<decimal> value);
    partial void Onart_preChanged();
    partial void Onart_stkChanging(System.Nullable<int> value);
    partial void Onart_stkChanged();
    #endregion
	
	public Articulos()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_art_cod", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string art_cod
	{
		get
		{
			return this._art_cod;
		}
		set
		{
			if ((this._art_cod != value))
			{
				this.Onart_codChanging(value);
				this.SendPropertyChanging();
				this._art_cod = value;
				this.SendPropertyChanged("art_cod");
				this.Onart_codChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_art_nom", DbType="VarChar(30)")]
	public string art_nom
	{
		get
		{
			return this._art_nom;
		}
		set
		{
			if ((this._art_nom != value))
			{
				this.Onart_nomChanging(value);
				this.SendPropertyChanging();
				this._art_nom = value;
				this.SendPropertyChanged("art_nom");
				this.Onart_nomChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_art_uni", DbType="Char(4)")]
	public string art_uni
	{
		get
		{
			return this._art_uni;
		}
		set
		{
			if ((this._art_uni != value))
			{
				this.Onart_uniChanging(value);
				this.SendPropertyChanging();
				this._art_uni = value;
				this.SendPropertyChanged("art_uni");
				this.Onart_uniChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_art_pre", DbType="Decimal(10,2)")]
	public System.Nullable<decimal> art_pre
	{
		get
		{
			return this._art_pre;
		}
		set
		{
			if ((this._art_pre != value))
			{
				this.Onart_preChanging(value);
				this.SendPropertyChanging();
				this._art_pre = value;
				this.SendPropertyChanged("art_pre");
				this.Onart_preChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_art_stk", DbType="Int")]
	public System.Nullable<int> art_stk
	{
		get
		{
			return this._art_stk;
		}
		set
		{
			if ((this._art_stk != value))
			{
				this.Onart_stkChanging(value);
				this.SendPropertyChanging();
				this._art_stk = value;
				this.SendPropertyChanged("art_stk");
				this.Onart_stkChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clientes")]
public partial class Clientes : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _cli_cod;
	
	private string _cli_nom;
	
	private string _cli_tel;
	
	private string _cli_cor;
	
	private string _cli_dir;
	
	private System.Nullable<decimal> _cli_cre;
	
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncli_codChanging(string value);
    partial void Oncli_codChanged();
    partial void Oncli_nomChanging(string value);
    partial void Oncli_nomChanged();
    partial void Oncli_telChanging(string value);
    partial void Oncli_telChanged();
    partial void Oncli_corChanging(string value);
    partial void Oncli_corChanged();
    partial void Oncli_dirChanging(string value);
    partial void Oncli_dirChanged();
    partial void Oncli_creChanging(System.Nullable<decimal> value);
    partial void Oncli_creChanged();
    #endregion
	
	public Clientes()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_cod", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string cli_cod
	{
		get
		{
			return this._cli_cod;
		}
		set
		{
			if ((this._cli_cod != value))
			{
				this.Oncli_codChanging(value);
				this.SendPropertyChanging();
				this._cli_cod = value;
				this.SendPropertyChanged("cli_cod");
				this.Oncli_codChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_nom", DbType="VarChar(35)")]
	public string cli_nom
	{
		get
		{
			return this._cli_nom;
		}
		set
		{
			if ((this._cli_nom != value))
			{
				this.Oncli_nomChanging(value);
				this.SendPropertyChanging();
				this._cli_nom = value;
				this.SendPropertyChanged("cli_nom");
				this.Oncli_nomChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_tel", DbType="Char(8)")]
	public string cli_tel
	{
		get
		{
			return this._cli_tel;
		}
		set
		{
			if ((this._cli_tel != value))
			{
				this.Oncli_telChanging(value);
				this.SendPropertyChanging();
				this._cli_tel = value;
				this.SendPropertyChanged("cli_tel");
				this.Oncli_telChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_cor", DbType="VarChar(30)")]
	public string cli_cor
	{
		get
		{
			return this._cli_cor;
		}
		set
		{
			if ((this._cli_cor != value))
			{
				this.Oncli_corChanging(value);
				this.SendPropertyChanging();
				this._cli_cor = value;
				this.SendPropertyChanged("cli_cor");
				this.Oncli_corChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_dir", DbType="VarChar(30)")]
	public string cli_dir
	{
		get
		{
			return this._cli_dir;
		}
		set
		{
			if ((this._cli_dir != value))
			{
				this.Oncli_dirChanging(value);
				this.SendPropertyChanging();
				this._cli_dir = value;
				this.SendPropertyChanged("cli_dir");
				this.Oncli_dirChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_cre", DbType="Decimal(8,1)")]
	public System.Nullable<decimal> cli_cre
	{
		get
		{
			return this._cli_cre;
		}
		set
		{
			if ((this._cli_cre != value))
			{
				this.Oncli_creChanging(value);
				this.SendPropertyChanging();
				this._cli_cre = value;
				this.SendPropertyChanged("cli_cre");
				this.Oncli_creChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fac_cabe")]
public partial class Fac_cabe : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _fac_num;
	
	private System.Nullable<System.DateTime> _fac_fec;
	
	private string _cli_cod;
	
	private System.Nullable<char> _fac_igv;
	
	private System.Nullable<int> _ven_cod;
	
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onfac_numChanging(string value);
    partial void Onfac_numChanged();
    partial void Onfac_fecChanging(System.Nullable<System.DateTime> value);
    partial void Onfac_fecChanged();
    partial void Oncli_codChanging(string value);
    partial void Oncli_codChanged();
    partial void Onfac_igvChanging(System.Nullable<char> value);
    partial void Onfac_igvChanged();
    partial void Onven_codChanging(System.Nullable<int> value);
    partial void Onven_codChanged();
    #endregion
	
	public Fac_cabe()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_num", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string fac_num
	{
		get
		{
			return this._fac_num;
		}
		set
		{
			if ((this._fac_num != value))
			{
				this.Onfac_numChanging(value);
				this.SendPropertyChanging();
				this._fac_num = value;
				this.SendPropertyChanged("fac_num");
				this.Onfac_numChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_fec", DbType="DateTime")]
	public System.Nullable<System.DateTime> fac_fec
	{
		get
		{
			return this._fac_fec;
		}
		set
		{
			if ((this._fac_fec != value))
			{
				this.Onfac_fecChanging(value);
				this.SendPropertyChanging();
				this._fac_fec = value;
				this.SendPropertyChanged("fac_fec");
				this.Onfac_fecChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cli_cod", DbType="Char(5)")]
	public string cli_cod
	{
		get
		{
			return this._cli_cod;
		}
		set
		{
			if ((this._cli_cod != value))
			{
				this.Oncli_codChanging(value);
				this.SendPropertyChanging();
				this._cli_cod = value;
				this.SendPropertyChanged("cli_cod");
				this.Oncli_codChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_igv", DbType="Char(1)")]
	public System.Nullable<char> fac_igv
	{
		get
		{
			return this._fac_igv;
		}
		set
		{
			if ((this._fac_igv != value))
			{
				this.Onfac_igvChanging(value);
				this.SendPropertyChanging();
				this._fac_igv = value;
				this.SendPropertyChanged("fac_igv");
				this.Onfac_igvChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ven_cod", DbType="Int")]
	public System.Nullable<int> ven_cod
	{
		get
		{
			return this._ven_cod;
		}
		set
		{
			if ((this._ven_cod != value))
			{
				this.Onven_codChanging(value);
				this.SendPropertyChanging();
				this._ven_cod = value;
				this.SendPropertyChanged("ven_cod");
				this.Onven_codChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fac_deta")]
public partial class Fac_deta : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _fac_num;
	
	private string _art_cod;
	
	private System.Nullable<int> _art_can;
	
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onfac_numChanging(string value);
    partial void Onfac_numChanged();
    partial void Onart_codChanging(string value);
    partial void Onart_codChanged();
    partial void Onart_canChanging(System.Nullable<int> value);
    partial void Onart_canChanged();
    #endregion
	
	public Fac_deta()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_num", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string fac_num
	{
		get
		{
			return this._fac_num;
		}
		set
		{
			if ((this._fac_num != value))
			{
				this.Onfac_numChanging(value);
				this.SendPropertyChanging();
				this._fac_num = value;
				this.SendPropertyChanged("fac_num");
				this.Onfac_numChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_art_cod", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string art_cod
	{
		get
		{
			return this._art_cod;
		}
		set
		{
			if ((this._art_cod != value))
			{
				this.Onart_codChanging(value);
				this.SendPropertyChanging();
				this._art_cod = value;
				this.SendPropertyChanged("art_cod");
				this.Onart_codChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_art_can", DbType="Int")]
	public System.Nullable<int> art_can
	{
		get
		{
			return this._art_can;
		}
		set
		{
			if ((this._art_can != value))
			{
				this.Onart_canChanging(value);
				this.SendPropertyChanging();
				this._art_can = value;
				this.SendPropertyChanged("art_can");
				this.Onart_canChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Vendedor")]
public partial class Vendedor : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Ven_cod;
	
	private string _Ven_nom;
	
	private System.Nullable<System.DateTime> _Ven_Fig;
	
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVen_codChanging(int value);
    partial void OnVen_codChanged();
    partial void OnVen_nomChanging(string value);
    partial void OnVen_nomChanged();
    partial void OnVen_FigChanging(System.Nullable<System.DateTime> value);
    partial void OnVen_FigChanged();
    #endregion
	
	public Vendedor()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ven_cod", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Ven_cod
	{
		get
		{
			return this._Ven_cod;
		}
		set
		{
			if ((this._Ven_cod != value))
			{
				this.OnVen_codChanging(value);
				this.SendPropertyChanging();
				this._Ven_cod = value;
				this.SendPropertyChanged("Ven_cod");
				this.OnVen_codChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ven_nom", DbType="VarChar(25)")]
	public string Ven_nom
	{
		get
		{
			return this._Ven_nom;
		}
		set
		{
			if ((this._Ven_nom != value))
			{
				this.OnVen_nomChanging(value);
				this.SendPropertyChanging();
				this._Ven_nom = value;
				this.SendPropertyChanged("Ven_nom");
				this.OnVen_nomChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ven_Fig", DbType="DateTime")]
	public System.Nullable<System.DateTime> Ven_Fig
	{
		get
		{
			return this._Ven_Fig;
		}
		set
		{
			if ((this._Ven_Fig != value))
			{
				this.OnVen_FigChanging(value);
				this.SendPropertyChanging();
				this._Ven_Fig = value;
				this.SendPropertyChanged("Ven_Fig");
				this.OnVen_FigChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

public partial class SPDETAResult
{
	
	private string _ART_COD;
	
	private string _ART_NOM;
	
	private System.Nullable<decimal> _ART_PRE;
	
	private System.Nullable<int> _ART_CAN;
	
	private System.Nullable<decimal> _TOTAL;
	
	public SPDETAResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ART_COD", DbType="Char(5) NOT NULL", CanBeNull=false)]
	public string ART_COD
	{
		get
		{
			return this._ART_COD;
		}
		set
		{
			if ((this._ART_COD != value))
			{
				this._ART_COD = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ART_NOM", DbType="VarChar(30)")]
	public string ART_NOM
	{
		get
		{
			return this._ART_NOM;
		}
		set
		{
			if ((this._ART_NOM != value))
			{
				this._ART_NOM = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ART_PRE", DbType="Decimal(10,2)")]
	public System.Nullable<decimal> ART_PRE
	{
		get
		{
			return this._ART_PRE;
		}
		set
		{
			if ((this._ART_PRE != value))
			{
				this._ART_PRE = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ART_CAN", DbType="Int")]
	public System.Nullable<int> ART_CAN
	{
		get
		{
			return this._ART_CAN;
		}
		set
		{
			if ((this._ART_CAN != value))
			{
				this._ART_CAN = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TOTAL", DbType="Decimal(21,2)")]
	public System.Nullable<decimal> TOTAL
	{
		get
		{
			return this._TOTAL;
		}
		set
		{
			if ((this._TOTAL != value))
			{
				this._TOTAL = value;
			}
		}
	}
}
#pragma warning restore 1591
