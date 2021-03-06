﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MorilDataServer.services.database.models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MorilDataDB")]
	public partial class OrderModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    #endregion
		
		public OrderModelDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MorilDataDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OrderModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrderModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrderModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrderModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderId;
		
		private string _CompanyId;
		
		private string _CompanyName;
		
		private string _Headline;
		
		private string _PriorityNumber;
		
		private string _ContactPerson;
		
		private string _Person;
		
		private System.Nullable<System.DateTime> _DateCreated;
		
		private System.Nullable<System.DateTime> _Deadline;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnCompanyIdChanging(string value);
    partial void OnCompanyIdChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnHeadlineChanging(string value);
    partial void OnHeadlineChanged();
    partial void OnPriorityNumberChanging(string value);
    partial void OnPriorityNumberChanged();
    partial void OnContactPersonChanging(string value);
    partial void OnContactPersonChanged();
    partial void OnPersonChanging(string value);
    partial void OnPersonChanged();
    partial void OnDateCreatedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateCreatedChanged();
    partial void OnDeadlineChanging(System.Nullable<System.DateTime> value);
    partial void OnDeadlineChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Order()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyId", DbType="NVarChar(50)")]
		public string CompanyId
		{
			get
			{
				return this._CompanyId;
			}
			set
			{
				if ((this._CompanyId != value))
				{
					this.OnCompanyIdChanging(value);
					this.SendPropertyChanging();
					this._CompanyId = value;
					this.SendPropertyChanged("CompanyId");
					this.OnCompanyIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(50)")]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Headline", DbType="NVarChar(50)")]
		public string Headline
		{
			get
			{
				return this._Headline;
			}
			set
			{
				if ((this._Headline != value))
				{
					this.OnHeadlineChanging(value);
					this.SendPropertyChanging();
					this._Headline = value;
					this.SendPropertyChanged("Headline");
					this.OnHeadlineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PriorityNumber", DbType="NVarChar(50)")]
		public string PriorityNumber
		{
			get
			{
				return this._PriorityNumber;
			}
			set
			{
				if ((this._PriorityNumber != value))
				{
					this.OnPriorityNumberChanging(value);
					this.SendPropertyChanging();
					this._PriorityNumber = value;
					this.SendPropertyChanged("PriorityNumber");
					this.OnPriorityNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactPerson", DbType="NVarChar(50)")]
		public string ContactPerson
		{
			get
			{
				return this._ContactPerson;
			}
			set
			{
				if ((this._ContactPerson != value))
				{
					this.OnContactPersonChanging(value);
					this.SendPropertyChanging();
					this._ContactPerson = value;
					this.SendPropertyChanged("ContactPerson");
					this.OnContactPersonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Person", DbType="NVarChar(50)")]
		public string Person
		{
			get
			{
				return this._Person;
			}
			set
			{
				if ((this._Person != value))
				{
					this.OnPersonChanging(value);
					this.SendPropertyChanging();
					this._Person = value;
					this.SendPropertyChanged("Person");
					this.OnPersonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Deadline", DbType="DateTime")]
		public System.Nullable<System.DateTime> Deadline
		{
			get
			{
				return this._Deadline;
			}
			set
			{
				if ((this._Deadline != value))
				{
					this.OnDeadlineChanging(value);
					this.SendPropertyChanging();
					this._Deadline = value;
					this.SendPropertyChanged("Deadline");
					this.OnDeadlineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(400)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
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
}
#pragma warning restore 1591
