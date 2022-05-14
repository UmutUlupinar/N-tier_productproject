using Core.Models.ProductSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface IOrderService : IService<Order>
    {
        Task<Order> GetWithByIdAsync(int orderId);
    }
}
