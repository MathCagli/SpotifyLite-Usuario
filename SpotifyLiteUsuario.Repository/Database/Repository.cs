﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SpotifyLiteUsuario.CrossCutting.Repository;
using SpotifyLiteUsuario.Repository.Context;
using System.Data;
using System.Linq.Expressions;

namespace SpotifyLiteUsuario.Repository.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> Query { get; set; }
        protected DbContext Context { get; set; }

        public Repository(SpotifyUsuarioContext context)
        {
            this.Context = context;
            this.Query = Context.Set<T>();
        }

        public async Task<IDbContextTransaction> CreateTransaction()
        {
            return await this.Context.Database.BeginTransactionAsync();
        }

        public async Task<IDbContextTransaction> CreateTransaction(IsolationLevel isolation)
        {
            return await this.Context.Database.BeginTransactionAsync(isolation);
        }

        public async Task Delete(T entity)
        {
            this.Query.Remove(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAllByCriteria(Expression<Func<T, bool>> expression)
        {
            return await this.Query.Where(expression).ToListAsync();
        }

        public async Task<T> FindOneByCriteria(Expression<Func<T, bool>> expression)
        {
            return await this.Query.FirstOrDefaultAsync(expression);
        }

        public async Task<T> Get(string id)
        {
            return await this.Query.FindAsync(new Guid(id));
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.Query.ToListAsync();
        }

        public async Task Save(T entity)
        {
            this.Query.Add(entity);
            this.Context.SaveChanges();
        }

        public async Task Update(T entity)
        {
            this.Query.Update(entity);
            await this.Context.SaveChangesAsync();

        }
    }
}