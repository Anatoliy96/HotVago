using HotVagoDAL.DAO.Context;
using HotVagoDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoDAL.DAO
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> 
        where TEntity : Common
    {
        protected readonly HotVagoContext context;

        public GenericRepository()
            : this(new HotVagoContext())
        {

        }
        public GenericRepository(HotVagoContext context)
        {
            this.context = context;
        }
       
        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return context.Set<TEntity>().Where(expression);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetByID(int ID)
        {
            return context.Set<TEntity>().Find(ID);
        }

        public void Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
        }
    }
}
