using CMS.Data.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {
            this.Database.CreateIfNotExists();
        }

        public DbSet<Site> Sites { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<SiteFolder> SiteFolders { get; set; }
        public DbSet<SitePage> SitePages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DataContext>(new CreateDatabaseIfNotExists<DataContext>());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
