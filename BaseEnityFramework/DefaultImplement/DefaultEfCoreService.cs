using BaseEntityFramework.IService;
using BaseEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseEnityFramework.DefaultImplement
{
    public class DefaultEfCoreService<Context, T> : IEFCoreService<T> where T : class,IEntity where Context : DbContext
    {
        private readonly Context _context;
        public DefaultEfCoreService(Context context)
        {
            _context = context;
        }
        public async Task<bool> Add(T entity)
        {
            _context.Add(entity);
           var result =await _context.SaveChangesAsync();
            return result != 0;
        }

        public Task<bool> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public Task<T> GetEntity(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<T>> GetList(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<T>> GetPageResult<Req>(PageInput<Req> pagInput) where Req : new()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
