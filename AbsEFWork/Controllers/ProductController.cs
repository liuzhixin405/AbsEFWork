using BaseEntityFramework.Implementations.Entitys;
using BaseEntityFramework.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseEntityFramework.Controllers
{
    public class ProductController : CustomController<Product>
    {
        public ProductController(IEFCoreService<Product> efCoreService) : base(efCoreService)
        {
        }
    }
}
