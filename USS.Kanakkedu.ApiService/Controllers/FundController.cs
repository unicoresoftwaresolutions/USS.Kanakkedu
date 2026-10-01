using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;
using USS.Kanakkedu.Business.Interface;

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
