using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;

namespace USS.Kanakkedu.ApiService.Controllers
{
    public class BaseAPIController<T> : ControllerBase
    {

        protected readonly IBaseBusiness<T> business;
        public BaseAPIController(IBaseBusiness<T> business)
        {
            this.business = business;
        }
        public List<T> GetAll()
        {
            return business.GetAll();
        }
    }
}
