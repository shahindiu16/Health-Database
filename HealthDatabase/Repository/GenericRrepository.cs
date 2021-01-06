using HealthDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthDatabase.Repository
{
    public class GenericRrepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ModelContext _context;
        public GenericRrepository(ModelContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        //public void Delete(int id)
        //{
        //    //_context.Set<T>(id).Remove( id);
        //}

        public async Task<IEnumerable<T>> GetT()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetTById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetTById(long id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> SaveAsync(T entity)
        {
            await _context.SaveChangesAsync();
            return entity;
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
