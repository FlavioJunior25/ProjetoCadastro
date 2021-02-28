using System;
using System.Collections.Generic;
using ProjetoCadastro.Domain.Interfaces.Repositories;
using ProjetoCadastro.Domain.Interfaces.Service;

namespace ProjetoCadastro.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        public IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(TEntity obj)
        {
            _repositoryBase.Add(obj);
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

        public TEntity GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public void Remove(TEntity obj)
        {
            _repositoryBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repositoryBase.Update(obj);
        }
    }
}
