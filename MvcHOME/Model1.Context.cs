﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcHOME
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Hom> HomItems { get; set; }
        public DbSet<Cold_Water> Cold_WaterНабор { get; set; }
        public DbSet<Hot_Water> Hot_WaterНабор { get; set; }
        public DbSet<Electricity> ElectricityНабор { get; set; }
        public DbSet<Tarrif> TarrifНабор { get; set; }
        public DbSet<Sewage> SewageНабор { get; set; }
        public DbSet<Benefit> Benefit { get; set; }
        public DbSet<Gas> GasНабор { get; set; }
        public DbSet<Limits> LimitsНабор { get; set; }
    }
}
