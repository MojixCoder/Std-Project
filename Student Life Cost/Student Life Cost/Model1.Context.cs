﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Student_Life_Cost
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StdLifeEntities : DbContext
    {
        public StdLifeEntities()
            : base("name=StdLifeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BankAcc> BankAccs { get; set; }
        public virtual DbSet<Buy> Buys { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
