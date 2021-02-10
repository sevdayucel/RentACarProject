using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            TContext context1 = new TContext();
            using (TContext context = context1)
            {
                var addedEntity = context1.Entry(entity);
                addedEntity.State = EntityState.Added;
                context1.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context1 = new TContext())
            {
                var deletedEntity = context1.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context1.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context1 = new TContext())
            {
                return context1.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context1 = new TContext())
            {
                return filter == null
                    ? context1.Set<TEntity>().ToList()
                    : context1.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context1=new TContext())
            {
                var updatedEntity = context1.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context1.SaveChanges();

            }
        }
    }
}