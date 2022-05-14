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
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        private readonly int[] _ids;

        public UserSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
               new User
               {
                   ID = 1,
                   Name = "SysAdmin",
                   RoleID = _ids[0],
               },
                 new User
                 {
                     ID = 2,
                     Name = "Admin",
                     RoleID = _ids[1],
                 },
                   new User
                   {
                       ID = 3,
                       Name = "Customer",
                       RoleID = _ids[2],
                   }

               );
        }
    }
}
