﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interface
{
    public interface IRepositoryInterface<T> where T: BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Predicate<T> predicate);
        List<T> GetAll(Predicate<T> predicate);

    }
}
