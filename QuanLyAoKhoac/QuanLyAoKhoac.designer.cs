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

namespace QuanLyAoKhoac
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLBANAO")]
	public partial class QuanLyAoKhoacDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCauHinh(CauHinh instance);
    partial void UpdateCauHinh(CauHinh instance);
    partial void DeleteCauHinh(CauHinh instance);
    partial void InsertChiTiet(ChiTiet instance);
    partial void UpdateChiTiet(ChiTiet instance);
    partial void DeleteChiTiet(ChiTiet instance);
    partial void InsertDanhMucSP(DanhMucSP instance);
    partial void UpdateDanhMucSP(DanhMucSP instance);
    partial void DeleteDanhMucSP(DanhMucSP instance);
    partial void InsertDatHang(DatHang instance);
    partial void UpdateDatHang(DatHang instance);
    partial void DeleteDatHang(DatHang instance);
    partial void InsertLienHe(LienHe instance);
    partial void UpdateLienHe(LienHe instance);
    partial void DeleteLienHe(LienHe instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    #endregion
		
		public QuanLyAoKhoacDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLBANAOConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyAoKhoacDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyAoKhoacDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyAoKhoacDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyAoKhoacDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CauHinh> CauHinhs
		{
			get
			{
				return this.GetTable<CauHinh>();
			}
		}
		
		public System.Data.Linq.Table<ChiTiet> ChiTiets
		{
			get
			{
				return this.GetTable<ChiTiet>();
			}
		}
		
		public System.Data.Linq.Table<DanhMucSP> DanhMucSPs
		{
			get
			{
				return this.GetTable<DanhMucSP>();
			}
		}
		
		public System.Data.Linq.Table<DatHang> DatHangs
		{
			get
			{
				return this.GetTable<DatHang>();
			}
		}
		
		public System.Data.Linq.Table<LienHe> LienHes
		{
			get
			{
				return this.GetTable<LienHe>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CauHinh")]
	public partial class CauHinh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _IdCauHinh;
		
		private string _TenBien;
		
		private string _GiaTri;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdCauHinhChanging(long value);
    partial void OnIdCauHinhChanged();
    partial void OnTenBienChanging(string value);
    partial void OnTenBienChanged();
    partial void OnGiaTriChanging(string value);
    partial void OnGiaTriChanged();
    #endregion
		
		public CauHinh()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCauHinh", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long IdCauHinh
		{
			get
			{
				return this._IdCauHinh;
			}
			set
			{
				if ((this._IdCauHinh != value))
				{
					this.OnIdCauHinhChanging(value);
					this.SendPropertyChanging();
					this._IdCauHinh = value;
					this.SendPropertyChanged("IdCauHinh");
					this.OnIdCauHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBien", DbType="NVarChar(50)")]
		public string TenBien
		{
			get
			{
				return this._TenBien;
			}
			set
			{
				if ((this._TenBien != value))
				{
					this.OnTenBienChanging(value);
					this.SendPropertyChanging();
					this._TenBien = value;
					this.SendPropertyChanged("TenBien");
					this.OnTenBienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaTri", DbType="NVarChar(50)")]
		public string GiaTri
		{
			get
			{
				return this._GiaTri;
			}
			set
			{
				if ((this._GiaTri != value))
				{
					this.OnGiaTriChanging(value);
					this.SendPropertyChanging();
					this._GiaTri = value;
					this.SendPropertyChanged("GiaTri");
					this.OnGiaTriChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTiet")]
	public partial class ChiTiet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaCt;
		
		private string _HinhAnhSmall;
		
		private System.Nullable<long> _MaSp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaCtChanging(string value);
    partial void OnMaCtChanged();
    partial void OnHinhAnhSmallChanging(string value);
    partial void OnHinhAnhSmallChanged();
    partial void OnMaSpChanging(System.Nullable<long> value);
    partial void OnMaSpChanged();
    #endregion
		
		public ChiTiet()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaCt", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaCt
		{
			get
			{
				return this._MaCt;
			}
			set
			{
				if ((this._MaCt != value))
				{
					this.OnMaCtChanging(value);
					this.SendPropertyChanging();
					this._MaCt = value;
					this.SendPropertyChanged("MaCt");
					this.OnMaCtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnhSmall", DbType="NVarChar(MAX)")]
		public string HinhAnhSmall
		{
			get
			{
				return this._HinhAnhSmall;
			}
			set
			{
				if ((this._HinhAnhSmall != value))
				{
					this.OnHinhAnhSmallChanging(value);
					this.SendPropertyChanging();
					this._HinhAnhSmall = value;
					this.SendPropertyChanged("HinhAnhSmall");
					this.OnHinhAnhSmallChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSp", DbType="BigInt")]
		public System.Nullable<long> MaSp
		{
			get
			{
				return this._MaSp;
			}
			set
			{
				if ((this._MaSp != value))
				{
					this.OnMaSpChanging(value);
					this.SendPropertyChanging();
					this._MaSp = value;
					this.SendPropertyChanged("MaSp");
					this.OnMaSpChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DanhMucSP")]
	public partial class DanhMucSP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDm;
		
		private string _TenDm;
		
		private System.Nullable<int> _TrangThai;
		
		private System.Nullable<int> _ViTri;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDmChanging(int value);
    partial void OnMaDmChanged();
    partial void OnTenDmChanging(string value);
    partial void OnTenDmChanged();
    partial void OnTrangThaiChanging(System.Nullable<int> value);
    partial void OnTrangThaiChanged();
    partial void OnViTriChanging(System.Nullable<int> value);
    partial void OnViTriChanged();
    #endregion
		
		public DanhMucSP()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDm", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDm
		{
			get
			{
				return this._MaDm;
			}
			set
			{
				if ((this._MaDm != value))
				{
					this.OnMaDmChanging(value);
					this.SendPropertyChanging();
					this._MaDm = value;
					this.SendPropertyChanged("MaDm");
					this.OnMaDmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDm", DbType="NVarChar(MAX)")]
		public string TenDm
		{
			get
			{
				return this._TenDm;
			}
			set
			{
				if ((this._TenDm != value))
				{
					this.OnTenDmChanging(value);
					this.SendPropertyChanging();
					this._TenDm = value;
					this.SendPropertyChanged("TenDm");
					this.OnTenDmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrangThai", DbType="Int")]
		public System.Nullable<int> TrangThai
		{
			get
			{
				return this._TrangThai;
			}
			set
			{
				if ((this._TrangThai != value))
				{
					this.OnTrangThaiChanging(value);
					this.SendPropertyChanging();
					this._TrangThai = value;
					this.SendPropertyChanged("TrangThai");
					this.OnTrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ViTri", DbType="Int")]
		public System.Nullable<int> ViTri
		{
			get
			{
				return this._ViTri;
			}
			set
			{
				if ((this._ViTri != value))
				{
					this.OnViTriChanging(value);
					this.SendPropertyChanging();
					this._ViTri = value;
					this.SendPropertyChanged("ViTri");
					this.OnViTriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMucSP_SanPham", Storage="_SanPhams", ThisKey="MaDm", OtherKey="MaDm")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.DanhMucSP = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.DanhMucSP = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DatHang")]
	public partial class DatHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _IDDatHang;
		
		private System.Nullable<long> _MaHang;
		
		private System.Nullable<int> _Soluong;
		
		private string _TenKhach;
		
		private string _SoDT;
		
		private string _DiaChi;
		
		private string _Size;
		
		private System.Nullable<int> _TinhTrang;
		
		private string _Notes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDDatHangChanging(long value);
    partial void OnIDDatHangChanged();
    partial void OnMaHangChanging(System.Nullable<long> value);
    partial void OnMaHangChanged();
    partial void OnSoluongChanging(System.Nullable<int> value);
    partial void OnSoluongChanged();
    partial void OnTenKhachChanging(string value);
    partial void OnTenKhachChanged();
    partial void OnSoDTChanging(string value);
    partial void OnSoDTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnTinhTrangChanging(System.Nullable<int> value);
    partial void OnTinhTrangChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    #endregion
		
		public DatHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDatHang", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long IDDatHang
		{
			get
			{
				return this._IDDatHang;
			}
			set
			{
				if ((this._IDDatHang != value))
				{
					this.OnIDDatHangChanging(value);
					this.SendPropertyChanging();
					this._IDDatHang = value;
					this.SendPropertyChanged("IDDatHang");
					this.OnIDDatHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHang", DbType="BigInt")]
		public System.Nullable<long> MaHang
		{
			get
			{
				return this._MaHang;
			}
			set
			{
				if ((this._MaHang != value))
				{
					this.OnMaHangChanging(value);
					this.SendPropertyChanging();
					this._MaHang = value;
					this.SendPropertyChanged("MaHang");
					this.OnMaHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluong", DbType="Int")]
		public System.Nullable<int> Soluong
		{
			get
			{
				return this._Soluong;
			}
			set
			{
				if ((this._Soluong != value))
				{
					this.OnSoluongChanging(value);
					this.SendPropertyChanging();
					this._Soluong = value;
					this.SendPropertyChanged("Soluong");
					this.OnSoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhach", DbType="NVarChar(MAX)")]
		public string TenKhach
		{
			get
			{
				return this._TenKhach;
			}
			set
			{
				if ((this._TenKhach != value))
				{
					this.OnTenKhachChanging(value);
					this.SendPropertyChanging();
					this._TenKhach = value;
					this.SendPropertyChanged("TenKhach");
					this.OnTenKhachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDT", DbType="VarChar(MAX)")]
		public string SoDT
		{
			get
			{
				return this._SoDT;
			}
			set
			{
				if ((this._SoDT != value))
				{
					this.OnSoDTChanging(value);
					this.SendPropertyChanging();
					this._SoDT = value;
					this.SendPropertyChanged("SoDT");
					this.OnSoDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(MAX)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="NChar(10)")]
		public string Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Int")]
		public System.Nullable<int> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="NVarChar(MAX)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LienHe")]
	public partial class LienHe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _IDLienHe;
		
		private System.Nullable<long> _MaHang;
		
		private string _TenKhach;
		
		private string _SoDT;
		
		private string _Email;
		
		private string _DiaChi;
		
		private string _NgayLienHe;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDLienHeChanging(long value);
    partial void OnIDLienHeChanged();
    partial void OnMaHangChanging(System.Nullable<long> value);
    partial void OnMaHangChanged();
    partial void OnTenKhachChanging(string value);
    partial void OnTenKhachChanged();
    partial void OnSoDTChanging(string value);
    partial void OnSoDTChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnNgayLienHeChanging(string value);
    partial void OnNgayLienHeChanged();
    #endregion
		
		public LienHe()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLienHe", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long IDLienHe
		{
			get
			{
				return this._IDLienHe;
			}
			set
			{
				if ((this._IDLienHe != value))
				{
					this.OnIDLienHeChanging(value);
					this.SendPropertyChanging();
					this._IDLienHe = value;
					this.SendPropertyChanged("IDLienHe");
					this.OnIDLienHeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHang", DbType="BigInt")]
		public System.Nullable<long> MaHang
		{
			get
			{
				return this._MaHang;
			}
			set
			{
				if ((this._MaHang != value))
				{
					this.OnMaHangChanging(value);
					this.SendPropertyChanging();
					this._MaHang = value;
					this.SendPropertyChanged("MaHang");
					this.OnMaHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhach", DbType="NVarChar(MAX)")]
		public string TenKhach
		{
			get
			{
				return this._TenKhach;
			}
			set
			{
				if ((this._TenKhach != value))
				{
					this.OnTenKhachChanging(value);
					this.SendPropertyChanging();
					this._TenKhach = value;
					this.SendPropertyChanged("TenKhach");
					this.OnTenKhachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDT", DbType="VarChar(MAX)")]
		public string SoDT
		{
			get
			{
				return this._SoDT;
			}
			set
			{
				if ((this._SoDT != value))
				{
					this.OnSoDTChanging(value);
					this.SendPropertyChanging();
					this._SoDT = value;
					this.SendPropertyChanged("SoDT");
					this.OnSoDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(MAX)")]
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
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(MAX)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLienHe", DbType="VarChar(MAX)")]
		public string NgayLienHe
		{
			get
			{
				return this._NgayLienHe;
			}
			set
			{
				if ((this._NgayLienHe != value))
				{
					this.OnNgayLienHeChanging(value);
					this.SendPropertyChanging();
					this._NgayLienHe = value;
					this.SendPropertyChanged("NgayLienHe");
					this.OnNgayLienHeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _MaSp;
		
		private string _TenSp;
		
		private string _MaSo;
		
		private string _TenCt;
		
		private System.Nullable<double> _Gia;
		
		private System.Nullable<double> _GiaNiemYet;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<int> _TrangThai;
		
		private string _HinhAnh;
		
		private string _Color;
		
		private string _Size;
		
		private string _MoTaChiTiet;
		
		private string _UuDai;
		
		private System.Nullable<int> _MaDm;
		
		private System.Nullable<int> _XuHuong;
		
		private EntityRef<DanhMucSP> _DanhMucSP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSpChanging(long value);
    partial void OnMaSpChanged();
    partial void OnTenSpChanging(string value);
    partial void OnTenSpChanged();
    partial void OnMaSoChanging(string value);
    partial void OnMaSoChanged();
    partial void OnTenCtChanging(string value);
    partial void OnTenCtChanged();
    partial void OnGiaChanging(System.Nullable<double> value);
    partial void OnGiaChanged();
    partial void OnGiaNiemYetChanging(System.Nullable<double> value);
    partial void OnGiaNiemYetChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnTrangThaiChanging(System.Nullable<int> value);
    partial void OnTrangThaiChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnMoTaChiTietChanging(string value);
    partial void OnMoTaChiTietChanged();
    partial void OnUuDaiChanging(string value);
    partial void OnUuDaiChanged();
    partial void OnMaDmChanging(System.Nullable<int> value);
    partial void OnMaDmChanged();
    partial void OnXuHuongChanging(System.Nullable<int> value);
    partial void OnXuHuongChanged();
    #endregion
		
		public SanPham()
		{
			this._DanhMucSP = default(EntityRef<DanhMucSP>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSp", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long MaSp
		{
			get
			{
				return this._MaSp;
			}
			set
			{
				if ((this._MaSp != value))
				{
					this.OnMaSpChanging(value);
					this.SendPropertyChanging();
					this._MaSp = value;
					this.SendPropertyChanged("MaSp");
					this.OnMaSpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSp", DbType="NVarChar(MAX)")]
		public string TenSp
		{
			get
			{
				return this._TenSp;
			}
			set
			{
				if ((this._TenSp != value))
				{
					this.OnTenSpChanging(value);
					this.SendPropertyChanging();
					this._TenSp = value;
					this.SendPropertyChanged("TenSp");
					this.OnTenSpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSo", DbType="NChar(10)")]
		public string MaSo
		{
			get
			{
				return this._MaSo;
			}
			set
			{
				if ((this._MaSo != value))
				{
					this.OnMaSoChanging(value);
					this.SendPropertyChanging();
					this._MaSo = value;
					this.SendPropertyChanged("MaSo");
					this.OnMaSoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenCt", DbType="NVarChar(MAX)")]
		public string TenCt
		{
			get
			{
				return this._TenCt;
			}
			set
			{
				if ((this._TenCt != value))
				{
					this.OnTenCtChanging(value);
					this.SendPropertyChanging();
					this._TenCt = value;
					this.SendPropertyChanged("TenCt");
					this.OnTenCtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Float")]
		public System.Nullable<double> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaNiemYet", DbType="Float")]
		public System.Nullable<double> GiaNiemYet
		{
			get
			{
				return this._GiaNiemYet;
			}
			set
			{
				if ((this._GiaNiemYet != value))
				{
					this.OnGiaNiemYetChanging(value);
					this.SendPropertyChanging();
					this._GiaNiemYet = value;
					this.SendPropertyChanged("GiaNiemYet");
					this.OnGiaNiemYetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrangThai", DbType="Int")]
		public System.Nullable<int> TrangThai
		{
			get
			{
				return this._TrangThai;
			}
			set
			{
				if ((this._TrangThai != value))
				{
					this.OnTrangThaiChanging(value);
					this.SendPropertyChanging();
					this._TrangThai = value;
					this.SendPropertyChanged("TrangThai");
					this.OnTrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="NVarChar(MAX)")]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="NVarChar(MAX)")]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="NChar(10)")]
		public string Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTaChiTiet", DbType="NVarChar(MAX)")]
		public string MoTaChiTiet
		{
			get
			{
				return this._MoTaChiTiet;
			}
			set
			{
				if ((this._MoTaChiTiet != value))
				{
					this.OnMoTaChiTietChanging(value);
					this.SendPropertyChanging();
					this._MoTaChiTiet = value;
					this.SendPropertyChanged("MoTaChiTiet");
					this.OnMoTaChiTietChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UuDai", DbType="NVarChar(MAX)")]
		public string UuDai
		{
			get
			{
				return this._UuDai;
			}
			set
			{
				if ((this._UuDai != value))
				{
					this.OnUuDaiChanging(value);
					this.SendPropertyChanging();
					this._UuDai = value;
					this.SendPropertyChanged("UuDai");
					this.OnUuDaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDm", DbType="Int")]
		public System.Nullable<int> MaDm
		{
			get
			{
				return this._MaDm;
			}
			set
			{
				if ((this._MaDm != value))
				{
					if (this._DanhMucSP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDmChanging(value);
					this.SendPropertyChanging();
					this._MaDm = value;
					this.SendPropertyChanged("MaDm");
					this.OnMaDmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XuHuong", DbType="Int")]
		public System.Nullable<int> XuHuong
		{
			get
			{
				return this._XuHuong;
			}
			set
			{
				if ((this._XuHuong != value))
				{
					this.OnXuHuongChanging(value);
					this.SendPropertyChanging();
					this._XuHuong = value;
					this.SendPropertyChanged("XuHuong");
					this.OnXuHuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMucSP_SanPham", Storage="_DanhMucSP", ThisKey="MaDm", OtherKey="MaDm", IsForeignKey=true)]
		public DanhMucSP DanhMucSP
		{
			get
			{
				return this._DanhMucSP.Entity;
			}
			set
			{
				DanhMucSP previousValue = this._DanhMucSP.Entity;
				if (((previousValue != value) 
							|| (this._DanhMucSP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DanhMucSP.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._DanhMucSP.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaDm = value.MaDm;
					}
					else
					{
						this._MaDm = default(Nullable<int>);
					}
					this.SendPropertyChanged("DanhMucSP");
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
