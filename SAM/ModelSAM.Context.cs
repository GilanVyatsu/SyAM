﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SAMEntities : DbContext
    {
        public SAMEntities()
            : base("name=SAMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Catalog> Catalog { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Demand> Demand { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Supply> Supply { get; set; }
    }
}
