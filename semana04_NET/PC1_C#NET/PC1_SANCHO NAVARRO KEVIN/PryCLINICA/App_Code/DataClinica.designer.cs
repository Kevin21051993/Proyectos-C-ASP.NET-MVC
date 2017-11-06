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



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BDCLINICA")]
public partial class DataClinicaDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Definiciones de métodos de extensibilidad
  partial void OnCreated();
  partial void InsertCitas(Citas instance);
  partial void UpdateCitas(Citas instance);
  partial void DeleteCitas(Citas instance);
  partial void InsertMedicos(Medicos instance);
  partial void UpdateMedicos(Medicos instance);
  partial void DeleteMedicos(Medicos instance);
  partial void Inserttabesp(tabesp instance);
  partial void Updatetabesp(tabesp instance);
  partial void Deletetabesp(tabesp instance);
  #endregion
	
	public DataClinicaDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BDCLINICAConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClinicaDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClinicaDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClinicaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClinicaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Citas> Citas
	{
		get
		{
			return this.GetTable<Citas>();
		}
	}
	
	public System.Data.Linq.Table<Medicos> Medicos
	{
		get
		{
			return this.GetTable<Medicos>();
		}
	}
	
	public System.Data.Linq.Table<tabesp> tabesp
	{
		get
		{
			return this.GetTable<tabesp>();
		}
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spAdiCita")]
	public int spAdiCita([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(4)")] string codMed, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(40)")] string nomPac, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> tipo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,1)")] System.Nullable<decimal> pago)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codMed, nomPac, tipo, pago);
		return ((int)(result.ReturnValue));
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Citas")]
public partial class Citas : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _nrocita;
	
	private string _codmed;
	
	private string _nompac;
	
	private System.Nullable<int> _tipo;
	
	private System.Nullable<decimal> _pago;
	
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnrocitaChanging(int value);
    partial void OnnrocitaChanged();
    partial void OncodmedChanging(string value);
    partial void OncodmedChanged();
    partial void OnnompacChanging(string value);
    partial void OnnompacChanged();
    partial void OntipoChanging(System.Nullable<int> value);
    partial void OntipoChanged();
    partial void OnpagoChanging(System.Nullable<decimal> value);
    partial void OnpagoChanged();
    #endregion
	
	public Citas()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nrocita", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int nrocita
	{
		get
		{
			return this._nrocita;
		}
		set
		{
			if ((this._nrocita != value))
			{
				this.OnnrocitaChanging(value);
				this.SendPropertyChanging();
				this._nrocita = value;
				this.SendPropertyChanged("nrocita");
				this.OnnrocitaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codmed", DbType="Char(4)")]
	public string codmed
	{
		get
		{
			return this._codmed;
		}
		set
		{
			if ((this._codmed != value))
			{
				this.OncodmedChanging(value);
				this.SendPropertyChanging();
				this._codmed = value;
				this.SendPropertyChanged("codmed");
				this.OncodmedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nompac", DbType="VarChar(40)")]
	public string nompac
	{
		get
		{
			return this._nompac;
		}
		set
		{
			if ((this._nompac != value))
			{
				this.OnnompacChanging(value);
				this.SendPropertyChanging();
				this._nompac = value;
				this.SendPropertyChanged("nompac");
				this.OnnompacChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipo", DbType="Int")]
	public System.Nullable<int> tipo
	{
		get
		{
			return this._tipo;
		}
		set
		{
			if ((this._tipo != value))
			{
				this.OntipoChanging(value);
				this.SendPropertyChanging();
				this._tipo = value;
				this.SendPropertyChanged("tipo");
				this.OntipoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pago", DbType="Decimal(8,1)")]
	public System.Nullable<decimal> pago
	{
		get
		{
			return this._pago;
		}
		set
		{
			if ((this._pago != value))
			{
				this.OnpagoChanging(value);
				this.SendPropertyChanging();
				this._pago = value;
				this.SendPropertyChanged("pago");
				this.OnpagoChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Medicos")]
public partial class Medicos : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _codmed;
	
	private string _codes;
	
	private string _nombre;
	
	private System.Nullable<int> _colegiatura;
	
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodmedChanging(string value);
    partial void OncodmedChanged();
    partial void OncodesChanging(string value);
    partial void OncodesChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OncolegiaturaChanging(System.Nullable<int> value);
    partial void OncolegiaturaChanged();
    #endregion
	
	public Medicos()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codmed", DbType="Char(4) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string codmed
	{
		get
		{
			return this._codmed;
		}
		set
		{
			if ((this._codmed != value))
			{
				this.OncodmedChanging(value);
				this.SendPropertyChanging();
				this._codmed = value;
				this.SendPropertyChanged("codmed");
				this.OncodmedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codes", DbType="Char(3)")]
	public string codes
	{
		get
		{
			return this._codes;
		}
		set
		{
			if ((this._codes != value))
			{
				this.OncodesChanging(value);
				this.SendPropertyChanging();
				this._codes = value;
				this.SendPropertyChanged("codes");
				this.OncodesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(40)")]
	public string nombre
	{
		get
		{
			return this._nombre;
		}
		set
		{
			if ((this._nombre != value))
			{
				this.OnnombreChanging(value);
				this.SendPropertyChanging();
				this._nombre = value;
				this.SendPropertyChanged("nombre");
				this.OnnombreChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_colegiatura", DbType="Int")]
	public System.Nullable<int> colegiatura
	{
		get
		{
			return this._colegiatura;
		}
		set
		{
			if ((this._colegiatura != value))
			{
				this.OncolegiaturaChanging(value);
				this.SendPropertyChanging();
				this._colegiatura = value;
				this.SendPropertyChanged("colegiatura");
				this.OncolegiaturaChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tabesp")]
public partial class tabesp : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _code;
	
	private string _nome;
	
	private System.Nullable<decimal> _costo;
	
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodeChanging(string value);
    partial void OncodeChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OncostoChanging(System.Nullable<decimal> value);
    partial void OncostoChanged();
    #endregion
	
	public tabesp()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_code", DbType="Char(3) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string code
	{
		get
		{
			return this._code;
		}
		set
		{
			if ((this._code != value))
			{
				this.OncodeChanging(value);
				this.SendPropertyChanging();
				this._code = value;
				this.SendPropertyChanged("code");
				this.OncodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(25)")]
	public string nome
	{
		get
		{
			return this._nome;
		}
		set
		{
			if ((this._nome != value))
			{
				this.OnnomeChanging(value);
				this.SendPropertyChanging();
				this._nome = value;
				this.SendPropertyChanged("nome");
				this.OnnomeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_costo", DbType="Decimal(6,1)")]
	public System.Nullable<decimal> costo
	{
		get
		{
			return this._costo;
		}
		set
		{
			if ((this._costo != value))
			{
				this.OncostoChanging(value);
				this.SendPropertyChanging();
				this._costo = value;
				this.SendPropertyChanged("costo");
				this.OncostoChanged();
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
#pragma warning restore 1591