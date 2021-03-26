using Affix.DataContracts.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Affix.Data
{
    public sealed class AppointmentDbContext : DbContext
    {
        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options): base(options)
        {
                
        }
        public DbSet<CatalogueEntity> CatalogueMasters { get; set; }
        public DbSet<AffixEntity> AffixSettingMasters { get; set; }
        public DbSet<OrganizationEntity>OrganizationMasters { get; set; }
        public DbSet<CountryEntity> CountryMasters { get; set; }
        public DbSet<StateEntity>StateMasters { get; set; }

    }
}
