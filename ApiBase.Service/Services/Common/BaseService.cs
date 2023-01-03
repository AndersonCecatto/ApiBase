using ApiBase.Domain.Common;
using ApiBase.Domain.Interfaces.Repositories.Common;
using ApiBase.Domain.Interfaces.Services.Common;
using System.Collections.Generic;

namespace ApiBase.Service.Services.Common
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        protected readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public TEntity Add(TEntity entity)
        {
            _baseRepository.Insert(entity);
            return entity;
        }

        public void Delete(int id) => _baseRepository.Delete(id);

        public virtual IEnumerable<TEntity> GetAll() => _baseRepository.GetAll();

        public TEntity GetById(int id) => _baseRepository.Find(id);

        public TEntity Update(TEntity entity)
        {
            _baseRepository.Update(entity);
            return entity;
        }
    }
}
