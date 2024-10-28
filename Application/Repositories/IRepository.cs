namespace Application.Repositories;

public interface IRepository<T>
{
    public Task<IEnumerable<T>> GetAllAsync();
    public Task<T?> GetById(int id);
    public Task<T> AddAsync(T entity);
    public void UpdateAsync(T entity);
    public void DeleteAsync(T entity);

    // Before Implement Unit Of Work

    //public Task UpdateAsync(T entity);
    //public Task DeleteAsync(T entity);
}
