using System;
using System.Collections.Generic;
//using BrunaDolavaleSocialNetwork.Domain.Entities;
using System.Text;

namespace BrunaDolavaleSocialNetwork.Application.Interfaces
{
    public interface IBaseAppService<T> where T : class
    {
        void Add(T obj);

        T GetById(int id);

        IEnumerable<T> GetAll();

        void Update(T obj);

        void Remove(T obj);

        void Dispose();
    }
}
