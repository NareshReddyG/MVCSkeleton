using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Models.Entity.Mapping
{
    public class HomeMap : EntityTypeConfiguration<Home>
    {
        public HomeMap()
        {
            // Primary Key
            this.HasKey(t => t.HomeId);
            // Table & Column Mappings
            this.ToTable("Home");
            this.Property(t => t.HomeId).HasColumnName("HomeId");
            this.Property(t => t.HomeText).HasColumnName("HomeText");
        }
    }
}
