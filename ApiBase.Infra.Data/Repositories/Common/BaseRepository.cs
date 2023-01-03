using ApiBase.Domain.Common;
using ApiBase.Domain.Interfaces.Repositories.Common;
using ApiBase.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBase.Infra.Data.Repositories.Common
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApiBaseContext _apiBaseContext;

        public BaseRepository(ApiBaseContext apiBaseContext)
        {
            _apiBaseContext = apiBaseContext;
        }

        public void Delete(int id)
        {
            _apiBaseContext.Set<TEntity>().Remove(Find(id));
            _apiBaseContext.SaveChanges();
        }

        public TEntity Find(long id)
        {
            return _apiBaseContext.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _apiBaseContext.Set<TEntity>().AsEnumerable();
        }

        public void Insert(TEntity entity)
        {
            _apiBaseContext.Set<TEntity>().Add(entity);
            _apiBaseContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _apiBaseContext.Entry(entity).State = EntityState.Modified;
            _apiBaseContext.SaveChanges();
        }
    }
}
