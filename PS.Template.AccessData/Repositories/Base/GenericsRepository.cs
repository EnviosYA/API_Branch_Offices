using Microsoft.EntityFrameworkCore;
using PS.Template.API.Entities;
using PS.Template.Domain.Commands;
using System.Collections.Generic;

namespace PS.Template.AccessData.Repositories
{
    public class GenericsRepository<E> : IGenericsRepository<E> where E : class
    {
        private readonly SucursalDBContext _context;
        public GenericsRepository(SucursalDBContext dbContext)
        {
            _context = dbContext;
        }

        public virtual void Add(E entity) 
        {
            _context.Add(entity);
        }
        public virtual void AddRange(IEnumerable<E> entity)
        {
            _context.Set<E>().AddRange(entity);
        }
        public virtual void Delete(E entity)
        {
            _context.Set<E>().Attach(entity);
            _context.Set<E>().Remove(entity);
        }

        public virtual void Delete(int id)
        {
            E entity = FindById(id);
            Delete(entity);
        }
        public virtual void DeleteRange(IEnumerable<E> entity)
        {
            _context.Set<E>().RemoveRange(entity);
        }

        public virtual void Edit(E entity)
        {
            _context.Set<E>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void EditRange(IEnumerable<E> entity)
        {
            _context.Set<E>().UpdateRange(entity);
        }

        public virtual E FindById(int id)
        {
            return _context.Set<E>().Find(id);
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }
    }
}
