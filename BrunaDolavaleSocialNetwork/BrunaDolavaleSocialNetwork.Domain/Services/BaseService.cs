using BrunaDolavaleSocialNetwork.Domain.Interfaces.Repositories;
using BrunaDolavaleSocialNetwork.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunaDolavaleSocialNetwork.Domain.Services
{
   public class BaseService<T> : IDisposable, IBaseService<T> where T : class
        {
            private readonly IBaseRepository<T> repository;

            public BaseService(IBaseRepository<T> baseRepository)
            {
                repository = baseRepository;
            }

            public void Add(T obj)
            {
                repository.Add(obj);
            }

            public IEnumerable<T> GetAll()
            {
                return repository.GetAll();
            }

            public T GetById(int id)
            {
                return repository.GetById(id);
            }

            public void Remove(T obj)
            {
                repository.Remove(obj);
            }

            public void Update(T obj)
            {
                repository.Update(obj);
            }

            public void Dispose()
            {
                repository.Dispose();
            }
        }
}
