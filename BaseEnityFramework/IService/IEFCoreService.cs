using BaseEntityFramework.Models;
using System.Linq.Expressions;

namespace BaseEntityFramework.IService
{
    public interface IEFCoreService<T> where T:IEntity
    {
        Task<bool> Add(T entity) ;
        Task<bool> Delete(T entity);
        Task<bool> Update(T entity);
        Task<IReadOnlyCollection<T>> GetList(Expression<Func<T,bool>> expression) ;
        Task<PageResult<T>> GetPageResult<Req>(PageInput<Req> pagInput) where Req:new();
        Task<T> GetEntity(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAll();
    }
}
