﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoyalKeyDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LoyalKeyDBEntities : DbContext
    {
        public LoyalKeyDBEntities()
            : base("name=LoyalKeyDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Reward> Rewards { get; set; }
        public virtual DbSet<RewardDescription> RewardDescriptions { get; set; }
        public virtual DbSet<RewardType> RewardTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserBalance> UserBalances { get; set; }
    }
}
