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
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).UseIdentityColumn();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(200);
            builder.ToTable("Users");
        }
    }
}
