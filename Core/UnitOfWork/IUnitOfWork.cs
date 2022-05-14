using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository product { get; }
        ICategoryRepository category { get; }

        IOrderRepository order { get; }
        Task CommitAsync();
        void Commit();
    }
}
