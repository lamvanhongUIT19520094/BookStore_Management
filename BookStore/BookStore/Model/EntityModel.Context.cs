﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStore.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MYDATABASE_Entities : DbContext
    {
        public MYDATABASE_Entities()
            : base("name=MYDATABASE_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BAOCAOCONGNO> BAOCAOCONGNOes { get; set; }
        public virtual DbSet<BAOCAOTON> BAOCAOTONs { get; set; }
        public virtual DbSet<CHUCNANG> CHUCNANGs { get; set; }
        public virtual DbSet<CT_BCCN> CT_BCCN { get; set; }
        public virtual DbSet<CT_BCT> CT_BCT { get; set; }
        public virtual DbSet<CT_HD> CT_HD { get; set; }
        public virtual DbSet<CT_PNS> CT_PNS { get; set; }
        public virtual DbSet<DAUSACH> DAUSACHes { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<NHOMNGUOIDUNG> NHOMNGUOIDUNGs { get; set; }
        public virtual DbSet<PHIEUNHAPSACH> PHIEUNHAPSACHes { get; set; }
        public virtual DbSet<PHIEUTHUTIEN> PHIEUTHUTIENs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<THAMSO> THAMSOes { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
        public virtual DbSet<HinhAnhSach> HinhAnhSaches { get; set; }
    }
}
