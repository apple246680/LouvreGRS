﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LouvreGRS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LouvreGRS_ANMEntities : DbContext
    {
        public LouvreGRS_ANMEntities()
            : base("name=LouvreGRS_ANMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountData> AccountDatas { get; set; }
        public virtual DbSet<CollectibleData> CollectibleDatas { get; set; }
        public virtual DbSet<ExhibitionActivityData> ExhibitionActivityDatas { get; set; }
        public virtual DbSet<FreeQualification> FreeQualifications { get; set; }
        public virtual DbSet<GroupRegistration> GroupRegistrations { get; set; }
        public virtual DbSet<GroupRegistrationVisitor> GroupRegistrationVisitors { get; set; }
        public virtual DbSet<HallData> HallDatas { get; set; }
        public virtual DbSet<HallWithStaff> HallWithStaffs { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<PackageItinerary> PackageItineraries { get; set; }
        public virtual DbSet<RoomData> RoomDatas { get; set; }
        public virtual DbSet<StaffData> StaffDatas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TravelAgencyData> TravelAgencyDatas { get; set; }
        public virtual DbSet<TravelAgencyUserData> TravelAgencyUserDatas { get; set; }
    }
}
