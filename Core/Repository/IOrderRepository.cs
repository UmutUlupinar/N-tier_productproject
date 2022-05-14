using Core.Models.ProductSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> GetWithByIdAsync(int orderId);
    }
}
