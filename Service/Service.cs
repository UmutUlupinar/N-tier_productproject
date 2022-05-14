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
    public class Service<T> : IService<T> where T : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<T> _repo;

        public Service(IUnitOfWork unitOfWork, IRepository<T> repo)
        {
            _unitOfWork = unitOfWork;
            _repo = repo;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }
    }
}
