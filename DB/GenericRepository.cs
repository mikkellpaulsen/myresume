using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DB
{
    public class GenericRepository<Entity> where Entity : class
    {
        private DbSet<Entity> dbSet;
        private CvContext context;

        public GenericRepository(CvContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Entity>();
        }

        public IEnumerable<Entity> Get(
            Expression<Func<Entity, bool>> filter = null,
            Func<IQueryable<Entity>, IOrderedQueryable<Entity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<Entity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public Entity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public void Add(Entity entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(object id)
        {
            Entity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public void Delete(Entity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public void Update(Entity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}

