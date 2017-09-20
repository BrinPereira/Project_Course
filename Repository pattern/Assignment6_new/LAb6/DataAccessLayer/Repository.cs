using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
     public class Repository<T> : IRepository<T> where T : class
        {

            protected DbContext context;
            protected DbSet<T> dbset;

            public Repository(DbContext datacontext)
            {
                this.context = datacontext;
                dbset = context.Set<T>();
            }

            public void Delete(T entity)
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
                dbset = context.Set<T>();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public IEnumerable<T> GetAll()
            {
                return dbset.ToList();
            }

            public T GetById(int id)
            {
                return dbset.Find(id);
            }

            public T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
            {
                T item = null;
                IQueryable<T> dbQuery = dbset;
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                item = dbQuery
                    .AsNoTracking()
                    .FirstOrDefault(where);
                return item;
            }

            public void Insert(T entity)
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
                dbset = context.Set<T>();
            }

            public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
            {
                return dbset.Where(predicate);
            }

            public void Update(T entity)
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
                dbset = context.Set<T>();
            }


        }
    }
    
