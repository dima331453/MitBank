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

namespace login2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MitBankDB")]
	public partial class MitBankDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public MitBankDBDataContext() : 
				base(global::login2.Properties.Settings.Default.MitBankDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MitBankDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MitBankDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MitBankDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MitBankDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CompaniesView> CompaniesViews
		{
			get
			{
				return this.GetTable<CompaniesView>();
			}
		}
		
		public System.Data.Linq.Table<CustomersView> CustomersViews
		{
			get
			{
				return this.GetTable<CustomersView>();
			}
		}
		
		public System.Data.Linq.Table<HistoryTransactionView> HistoryTransactionViews
		{
			get
			{
				return this.GetTable<HistoryTransactionView>();
			}
		}
		
		public System.Data.Linq.Table<IndividualsView> IndividualsViews
		{
			get
			{
				return this.GetTable<IndividualsView>();
			}
		}
		
		public System.Data.Linq.Table<UserAccountsView> UserAccountsViews
		{
			get
			{
				return this.GetTable<UserAccountsView>();
			}
		}
		
		public System.Data.Linq.Table<UsernamesView> UsernamesViews
		{
			get
			{
				return this.GetTable<UsernamesView>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CompaniesView")]
	public partial class CompaniesView
	{
		
		private int _ID;
		
		private int _CustomerID;
		
		private int _IndividualID;
		
		private int _CIF;
		
		private string _Name;
		
		private string _Address;
		
		public CompaniesView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int NOT NULL")]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this._CustomerID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndividualID", DbType="Int NOT NULL")]
		public int IndividualID
		{
			get
			{
				return this._IndividualID;
			}
			set
			{
				if ((this._IndividualID != value))
				{
					this._IndividualID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CIF", DbType="Int NOT NULL")]
		public int CIF
		{
			get
			{
				return this._CIF;
			}
			set
			{
				if ((this._CIF != value))
				{
					this._CIF = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomersView")]
	public partial class CustomersView
	{
		
		private int _ID;
		
		private int _CustomerType;
		
		public CustomersView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerType", DbType="Int NOT NULL")]
		public int CustomerType
		{
			get
			{
				return this._CustomerType;
			}
			set
			{
				if ((this._CustomerType != value))
				{
					this._CustomerType = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HistoryTransactionView")]
	public partial class HistoryTransactionView
	{
		
		private int _ID;
		
		private System.Nullable<int> _CustomerID;
		
		private System.Nullable<int> _UserAccountID;
		
		private System.Nullable<int> _TypeTransaction;
		
		private System.Nullable<System.DateTime> _DateTransaction;
		
		public HistoryTransactionView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int")]
		public System.Nullable<int> CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this._CustomerID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserAccountID", DbType="Int")]
		public System.Nullable<int> UserAccountID
		{
			get
			{
				return this._UserAccountID;
			}
			set
			{
				if ((this._UserAccountID != value))
				{
					this._UserAccountID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeTransaction", DbType="Int")]
		public System.Nullable<int> TypeTransaction
		{
			get
			{
				return this._TypeTransaction;
			}
			set
			{
				if ((this._TypeTransaction != value))
				{
					this._TypeTransaction = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTransaction", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateTransaction
		{
			get
			{
				return this._DateTransaction;
			}
			set
			{
				if ((this._DateTransaction != value))
				{
					this._DateTransaction = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IndividualsView")]
	public partial class IndividualsView
	{
		
		private int _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Email;
		
		private string _CNP;
		
		private System.DateTime _Birthday;
		
		public IndividualsView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CNP", DbType="NVarChar(13) NOT NULL", CanBeNull=false)]
		public string CNP
		{
			get
			{
				return this._CNP;
			}
			set
			{
				if ((this._CNP != value))
				{
					this._CNP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="Date NOT NULL")]
		public System.DateTime Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this._Birthday = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserAccountsView")]
	public partial class UserAccountsView
	{
		
		private int _ID;
		
		private System.Nullable<int> _BankPacket;
		
		private string _AccountNumber;
		
		private System.DateTime _ValabilityUntil;
		
		private string _Currency;
		
		private double _Sold;
		
		private System.Nullable<int> _AccountCustomerID;
		
		public UserAccountsView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BankPacket", DbType="Int")]
		public System.Nullable<int> BankPacket
		{
			get
			{
				return this._BankPacket;
			}
			set
			{
				if ((this._BankPacket != value))
				{
					this._BankPacket = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountNumber", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string AccountNumber
		{
			get
			{
				return this._AccountNumber;
			}
			set
			{
				if ((this._AccountNumber != value))
				{
					this._AccountNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValabilityUntil", DbType="Date NOT NULL")]
		public System.DateTime ValabilityUntil
		{
			get
			{
				return this._ValabilityUntil;
			}
			set
			{
				if ((this._ValabilityUntil != value))
				{
					this._ValabilityUntil = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Currency", DbType="NVarChar(3) NOT NULL", CanBeNull=false)]
		public string Currency
		{
			get
			{
				return this._Currency;
			}
			set
			{
				if ((this._Currency != value))
				{
					this._Currency = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sold", DbType="Float NOT NULL")]
		public double Sold
		{
			get
			{
				return this._Sold;
			}
			set
			{
				if ((this._Sold != value))
				{
					this._Sold = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountCustomerID", DbType="Int")]
		public System.Nullable<int> AccountCustomerID
		{
			get
			{
				return this._AccountCustomerID;
			}
			set
			{
				if ((this._AccountCustomerID != value))
				{
					this._AccountCustomerID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UsernamesView")]
	public partial class UsernamesView
	{
		
		private int _ID;
		
		private int _UserType;
		
		private string _Username;
		
		public UsernamesView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="Int NOT NULL")]
		public int UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this._UserType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(101) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
