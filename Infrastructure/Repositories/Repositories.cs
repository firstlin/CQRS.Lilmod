﻿using Application.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repositories<T> : IRepository<T> where T : class
{
    private readonly DatabaseContext _dbContext;

    public Repositories(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        return entity;
    }

    public void DeleteAsync(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task<T?> GetById(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public void UpdateAsync(T entity)
    {
        _dbContext.Set<T>().Update(entity);
    }

    // Before Implement Unit Of Work

    //public async Task<T> AddAsync(T entity)
    //{
    //    await _dbContext.Set<T>().AddAsync(entity);
    //    await _dbContext.SaveChangesAsync();
    //    return entity;
    //}

    //public async Task DeleteAsync(T entity)
    //{
    //    _dbContext.Set<T>().Remove(entity);
    //    await _dbContext.SaveChangesAsync();
    //}

    //public async Task<IEnumerable<T>> GetAllAsync()
    //{
    //    return await _dbContext.Set<T>().ToListAsync();
    //}

    //public async Task<T?> GetById(int id)
    //{
    //    return await _dbContext.Set<T>().FindAsync(id);
    //}

    //public async Task UpdateAsync(T entity)
    //{
    //    _dbContext.Set<T>().Update(entity);
    //    await _dbContext.SaveChangesAsync();
    //}
}
