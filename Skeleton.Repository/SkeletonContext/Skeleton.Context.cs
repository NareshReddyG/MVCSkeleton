
using Skeleton.Models.Entity;
using Skeleton.Models.Entity.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Repository.SkeletonContextPartial
{
    public class SkeletonDBContext : DbContext
    {
        static SkeletonDBContext()
        {
            Database.SetInitializer<SkeletonDBContext>(null);
        }

        public SkeletonDBContext() : base("Name=OkItEntities")
        {

        }
        public DbSet<Home> Home { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HomeMap());

        }
    }
}
