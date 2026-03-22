namespace Application.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(string Id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity entity);
        Task DeleteByIdAsync(string Id);
    }
}