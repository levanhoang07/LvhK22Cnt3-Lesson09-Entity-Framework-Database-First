﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lvh_K22CNT3_Lesson09_Entity_Framework_Database_First.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LvhK22CNT3Lesson09DbEntities : DbContext
    {
        public LvhK22CNT3Lesson09DbEntities()
            : base("name=LvhK22CNT3Lesson09DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<lvhKhoa> lvhKhoas { get; set; }
        public virtual DbSet<lvhMonHoc> lvhMonHocs { get; set; }
        public virtual DbSet<lvhSinhVien> lvhSinhViens { get; set; }
        public virtual DbSet<lvhKetqua> lvhKetquas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}