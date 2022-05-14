using Core.Models.ProductSide;
using Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private Context context { get => _context as Context; }
        public ProductRepository(Context context) : base(context)
        {
        }

        public async Task<Product> GetWithByIdAsync(int productId)
        {
            return (await context.Products.FirstOrDefaultAsync(s => s.ID == productId))!;
        }
    }
    
    }

