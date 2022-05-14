using Core.Models.ProductSide;
using Core.Repository;
using Core.Service;
using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repo) : base(unitOfWork, repo)
        {
        }

        public async Task<Product> GetWithByIdAsync(int productId)
        {
            return await _unitOfWork.product.GetWithByIdAsync(productId);
        }
    }



}

