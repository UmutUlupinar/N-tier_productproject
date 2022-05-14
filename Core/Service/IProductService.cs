using Core.Models.ProductSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface IProductService : IService<Product>
    {
        Task<Product> GetWithByIdAsync(int productId);
    }
}
