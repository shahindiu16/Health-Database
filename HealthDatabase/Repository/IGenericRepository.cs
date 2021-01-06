using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthDatabase.Models;

namespace HealthDatabase.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetT();
        Task<T> GetTById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetTById(long id);
        Task<T> SaveAsync(T entity);
        //Task GetById(long id);
    }
}
