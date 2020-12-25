﻿using StuHubSystem.Core.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace StuHubSystem.Contract
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        IQueryable<T> FindAll(Expression<Func<T, bool>>? predicate = null);

        Task<T> FindByIdAsync(int id, CancellationToken cancellationToken);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        Task SaveChangesAsync(CancellationToken cancellationToken);
    }
}
