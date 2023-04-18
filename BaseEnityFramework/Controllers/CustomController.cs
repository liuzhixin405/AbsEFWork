using BaseEntityFramework.IService;
using BaseEntityFramework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using HttpPutAttribute = Microsoft.AspNetCore.Mvc.HttpPutAttribute;

namespace BaseEntityFramework
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public abstract class CustomController<T> : ControllerBase where T : IEntity
    {
        private readonly IEFCoreService<T> _efCoreService;
        public CustomController(IEFCoreService<T> efCoreService)
        {
            _efCoreService = efCoreService;
        }

        [HttpPost]
        public Task Add(T request)
        {
           return _efCoreService.Add(request);
        }
        [HttpPut]
        public Task Update(T request)
        {
            return _efCoreService.Update(request);
        }

        [HttpGet]
        public Task<IReadOnlyCollection<T>> GetList(Expression<Func<T,bool>> request)
        {
            return _efCoreService.GetList(request);
        }

        [HttpGet("GetAll")]
        public Task<IEnumerable<T>> GetAll()
        {
            return _efCoreService.GetAll();
        }
    }
}
