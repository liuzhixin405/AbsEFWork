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
    }
}
