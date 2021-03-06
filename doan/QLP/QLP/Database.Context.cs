﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLPhimEntities : DbContext
    {
        public QLPhimEntities()
            : base("name=QLPhimEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CaChieu> CaChieux { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<Ghe> Ghes { get; set; }
        public virtual DbSet<LichChieu> LichChieux { get; set; }
        public virtual DbSet<NhomNhanVien> NhomNhanViens { get; set; }
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }
        public virtual DbSet<XuatChieu> XuatChieux { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
    
        public virtual ObjectResult<spCheckDangNhap_Result> spCheckDangNhap(string idDangNhap, string matKhau)
        {
            var idDangNhapParameter = idDangNhap != null ?
                new ObjectParameter("IdDangNhap", idDangNhap) :
                new ObjectParameter("IdDangNhap", typeof(string));
    
            var matKhauParameter = matKhau != null ?
                new ObjectParameter("MatKhau", matKhau) :
                new ObjectParameter("MatKhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCheckDangNhap_Result>("spCheckDangNhap", idDangNhapParameter, matKhauParameter);
        }
    
        public virtual ObjectResult<Nullable<bool>> spCheckTrangThai(string idDangNhap)
        {
            var idDangNhapParameter = idDangNhap != null ?
                new ObjectParameter("IdDangNhap", idDangNhap) :
                new ObjectParameter("IdDangNhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("spCheckTrangThai", idDangNhapParameter);
        }
    
        public virtual int spDeleteDangNhapByIdDangNhap(string idDangNhap)
        {
            var idDangNhapParameter = idDangNhap != null ?
                new ObjectParameter("IdDangNhap", idDangNhap) :
                new ObjectParameter("IdDangNhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteDangNhapByIdDangNhap", idDangNhapParameter);
        }
    
        public virtual int spInsertDangNhap(string idDangNhap, string matKhau, string ten, Nullable<int> nhomNhanVienID, Nullable<bool> trangThai)
        {
            var idDangNhapParameter = idDangNhap != null ?
                new ObjectParameter("IdDangNhap", idDangNhap) :
                new ObjectParameter("IdDangNhap", typeof(string));
    
            var matKhauParameter = matKhau != null ?
                new ObjectParameter("MatKhau", matKhau) :
                new ObjectParameter("MatKhau", typeof(string));
    
            var tenParameter = ten != null ?
                new ObjectParameter("Ten", ten) :
                new ObjectParameter("Ten", typeof(string));
    
            var nhomNhanVienIDParameter = nhomNhanVienID.HasValue ?
                new ObjectParameter("NhomNhanVienID", nhomNhanVienID) :
                new ObjectParameter("NhomNhanVienID", typeof(int));
    
            var trangThaiParameter = trangThai.HasValue ?
                new ObjectParameter("TrangThai", trangThai) :
                new ObjectParameter("TrangThai", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertDangNhap", idDangNhapParameter, matKhauParameter, tenParameter, nhomNhanVienIDParameter, trangThaiParameter);
        }
    
        public virtual int spUpdateDangNhap_MatKhau(string idDangNhap, string matKhau)
        {
            var idDangNhapParameter = idDangNhap != null ?
                new ObjectParameter("IdDangNhap", idDangNhap) :
                new ObjectParameter("IdDangNhap", typeof(string));
    
            var matKhauParameter = matKhau != null ?
                new ObjectParameter("MatKhau", matKhau) :
                new ObjectParameter("MatKhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateDangNhap_MatKhau", idDangNhapParameter, matKhauParameter);
        }
    }
}
