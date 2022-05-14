using Core.Models.UserSide;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seed.UserSide
{
    public class RoleSeed : IEntityTypeConfiguration<Role>
    {
        private readonly int[] _ids;

        public RoleSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(new Role
            {
                ID = _ids[0],
                Name = "SysAdmin",
            },
            new Role
            {
                ID = _ids[1],
                Name = "Admin",
            },
            new Role
            {
                ID = _ids[2],
                Name = "Customer",
            });         
             
        }
    }
}
