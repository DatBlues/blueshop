﻿
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace DatShop.Data.Infrastructure
{
    public interface IRepository<T> where T :class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
        void Delete(int id);

        void DeleteMulti(Expression<Func<T, bool>> where);

        T GetSingleById(int id);
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] include = null);
        IQueryable<T> GetAll(string[] include = null);
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);
        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index=0, int size= 50, string[] includes= null);
        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}
