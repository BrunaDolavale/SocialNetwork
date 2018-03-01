using System;
using System.Collections.Generic;
using BrunaDolavaleSocialNetwork.Application.Interfaces;
using BrunaDolavaleSocialNetwork.Domain.Interfaces.Services;

namespace BrunaDolavaleSocialNetwork.Application
{
    public class BaseAppService<T> : IDisposable, IBaseAppService<T> where T : class
    {
        private readonly IBaseService<T> service;

        public BaseAppService(IBaseService<T> baseService)
        {
            service = baseService;
        }

        public void Add(T obj)
        {
            service.Add(obj);
        }

        public void Dispose()
        {
            service.Dispose();
        }

        public IEnumerable<T> GetAll()
        {
            return service.GetAll();
        }

        public T GetById(int id)
        {
            return service.GetById(id);
        }

        public void Remove(T obj)
        {
            service.Remove(obj);
        }

        public void Update(T obj)
        {
            service.Update(obj);
        }
    }
}
