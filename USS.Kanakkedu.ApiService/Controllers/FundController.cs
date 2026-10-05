using Microsoft.AspNetCore.Mvc;
using USS.Base.ApiService.Controllers;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.ApiService.Controllers
{
   
    [ApiController]
    public class FundController : BaseAPIController<Fund>
    {
        public FundController(IFundBusiness business) : base(business)
        {
        }
    }
}
