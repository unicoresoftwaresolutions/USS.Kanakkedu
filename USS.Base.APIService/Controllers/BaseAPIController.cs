using Microsoft.AspNetCore.Mvc;
using USS.Base.Business.Interface;

namespace USS.Base.ApiService.Controllers
{
    
    [Route("API/[controller]")]
    public class BaseAPIController<T> : ControllerBase
    {

        protected readonly IBaseBusiness<T> business;
        public BaseAPIController(IBaseBusiness<T> business)
        {
            this.business = business;
        }

        [HttpGet]
        public List<T> GetAll()
        {
            return business.GetAll();
        }

        [HttpPost]
        public bool Insert(T item)
        {
            return business.Insert(item);
        }

        [HttpPut]
        public bool Update(T item)
        {
            return business.Update(item);
        }

        [HttpDelete("{Id}")]
        public bool Delete(Guid Id)
        {
            return business.Delete(Id);
        }
    }
}
