using EasyNow.BusinessObject.DataAccess.Entities;
using System;
using System.Linq;
using EasyNow.BusinessObject.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace EasyNow.BusinessObject.Abstractions
{
    public abstract class BaseBo<TKey,TEntity>:IBo where TEntity: BaseEntity<TKey> where TKey : struct, IComparable<TKey>
    {
        public IServiceProvider ServiceProvider { get; set; }

        protected EasyNowContext<TKey> DbContext => ServiceProvider.GetService<EasyNowContext<TKey>>();

        public virtual TEntity Add(TEntity entity)
        {
            var entityEntry = DbContext.Add(entity);
            DbContext.SaveChanges();
            return entityEntry.Entity;
        }

        public virtual TEntity Delete(TKey id)
        {
            var entity = DbContext.Set<TEntity>().FirstOrDefault(e => e.Id.Equals(id));
            if (entity == null)
            {
                return null;
            }

            DbContext.Set<TEntity>().Remove(entity);
            DbContext.SaveChanges();
            return entity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            var entityEntry = DbContext.Attach(entity);
            DbContext.SaveChanges();
            return entityEntry.Entity;
        }
    }
}
