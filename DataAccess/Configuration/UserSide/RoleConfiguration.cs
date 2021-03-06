using Core.Models.UserSide;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration.UserSide
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).UseIdentityColumn();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
            builder.ToTable("Roles");
        }
    }
}
