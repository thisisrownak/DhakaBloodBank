﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDRownakJahanTanjil_296627.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MDRownakJahanTanjil_296627Entities : DbContext
    {
        public MDRownakJahanTanjil_296627Entities()
            : base("name=MDRownakJahanTanjil_296627Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BloodGroup> BloodGroups { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
    }
}
