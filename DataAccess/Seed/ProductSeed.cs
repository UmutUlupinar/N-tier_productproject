using Core.Models.ProductSide;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seed
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    ID = 1,
                    Name = "pen",
                    CategoryID = _ids[0],
                },

                  new Product
                  {
                      ID = 2,
                      Name = "eraser",
                      CategoryID = _ids[0],
                  },

                    new Product
                    {
                        ID = 3,
                        Name = "sweatshirt",
                        CategoryID = _ids[1],
                    },

                      new Product
                      {
                          ID = 4,
                          Name = "jean",
                          CategoryID = _ids[2],
                      }

                );
        }
    }
}
