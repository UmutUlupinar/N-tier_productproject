using Core.Repository;
using Core.UnitOfWork;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;

        public UnitOfWork(Context context)
        {
            _context = context;
        }

        public IProductRepository product => _productRepository ??=
            new ProductRepository(_context);

        public ICategoryRepository category => _categoryRepository ??=
            new CategoryRepository(_context);

        public IOrderRepository order => throw new NotImplementedException();

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
