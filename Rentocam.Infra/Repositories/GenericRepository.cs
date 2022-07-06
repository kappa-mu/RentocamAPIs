using Rentocam.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rentocam.Infra.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        protected RentocamContext context;

        public GenericRepository(RentocamContext context)
        {
            this.context = context;

        }
        public virtual T Add(T entity)
        {
            return context.Add(entity).Entity;
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate).ToList();
        }

        public virtual T Get(Guid id)
        {
            return context.Find<T>(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>().AsQueryable().ToList();
        }

        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            return context.Update(entity).Entity;
        }
    }
}
