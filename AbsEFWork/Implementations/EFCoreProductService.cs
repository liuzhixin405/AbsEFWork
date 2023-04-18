using BaseEntityFramework.Implementations.Entitys;
using BaseEntityFramework.IService;
using BaseEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BaseEntityFramework.Implementations
{
    public class EFCoreProductService : IEFCoreService<Product>
    {
        private readonly ProductDbContext _dbContext;
        public EFCoreProductService(ProductDbContext productDbContext)
        {
            _dbContext = productDbContext;
        }

        public async Task<bool> Add(Product entity)
        {
            _dbContext.Products.Add(entity);
            var result = await _dbContext.SaveChangesAsync();
            return result != 0;
        }

        public Task<bool> Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var result =await _dbContext.Products.ToListAsync();
            return result;
        }

        public Task<Product> GetEntity(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyCollection<Product>> GetList(Expression<Func<Product, bool>> expression)
        {
            var result = await _dbContext.Products.Where(expression).ToListAsync();
            return result.AsReadOnly();
        }

        public Task<PageResult<Product>> GetPageResult<Req>(PageInput<Req> pagInput) where Req : new()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
