

using PYHDATA.NETFramework.Models;
using System.Data.Entity.ModelConfiguration;

namespace PYHDATA.NETFramework.Data.Configurations
{
    public class ItemConfiguration : EntityTypeConfiguration<Item>
    {
        public ItemConfiguration()
        {
            Property(x => x.Name).IsRequired().IsUnicode().HasMaxLength(250);
            Property(x => x.Desciption).IsUnicode().HasMaxLength(500);
            Property(x => x.CateogryName).IsRequired().IsUnicode().HasMaxLength(250);
            Property(x => x.ImageUrl).IsUnicode().HasMaxLength(250);
        }
    }
}
