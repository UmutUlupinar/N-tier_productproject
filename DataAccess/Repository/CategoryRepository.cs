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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private Context context { get => _context as Context; }
        public CategoryRepository(Context context) : base(context)
        {
        }

        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            return (await context.Categories.Include(s=>s.Products).FirstOrDefaultAsync(c => c.ID == categoryId))!;
        }
    }
    
    }

