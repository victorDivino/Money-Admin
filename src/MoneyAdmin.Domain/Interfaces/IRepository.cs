﻿using MoneyAdmin.Domain.Core.Models;
using System;
using System.Threading.Tasks;

namespace MoneyAdmin.Domain.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        T GetById(Guid id);
        void Save();
    }
}