
using Microsoft.AspNetCore.Mvc;
using USS.Base.ApiService.Controllers;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.ApiService.Controllers
{
   
    [ApiController]
    public class ACGroupController : BaseAPIController<ACGroup>
    {
        public ACGroupController(IACGroupBusiness business) : base(business)
        {
        }
    }
}
