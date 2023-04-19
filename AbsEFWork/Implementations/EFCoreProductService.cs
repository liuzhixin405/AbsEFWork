using BaseEnityFramework.DefaultImplement;
using BaseEntityFramework.Implementations.Entitys;
using BaseEntityFramework.IService;
using BaseEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BaseEntityFramework.Implementations
{
    public class EFCoreProductService : DefaultEfCoreService<ProductDbContext,Product>
    {
        private readonly ProductDbContext _dbContext;

        public EFCoreProductService(ProductDbContext context) : base(context)
        {
        }

        public Task<bool> Add(Product entity)
        {
          return base.Add(entity);
        }

        public Task<bool> Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            var result = base.GetAll();
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
