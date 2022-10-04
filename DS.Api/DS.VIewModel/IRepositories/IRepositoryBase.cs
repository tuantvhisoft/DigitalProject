using System;
using System.Linq.Expressions;

namespace DS.ViewModel.IRepositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T?> GetByIdAsync(string id);
        Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> expression);
        Task<IReadOnlyList<T>> GetAllAsync();
        IQueryable<T> GetIQueryable();
        Task<IReadOnlyList<T>> GetPagedReponseAsync(int pageNumber, int pageSize);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

