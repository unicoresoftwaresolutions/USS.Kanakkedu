
using Microsoft.AspNetCore.Mvc;
using USS.Base.ApiService.Controllers;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.ApiService.Controllers
{
   
    [ApiController]
    public class LedgerController : BaseAPIController<Ledger>
    {
        public LedgerController(ILedgerBusiness business) : base(business)
        {
        }
    }
}
