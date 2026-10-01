using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.ApiService.Controllers
{    
    [ApiController]
    public class JournalTypeController : BaseAPIController<JournalType>
    {
        public JournalTypeController(IJournalTypeBusiness business) : base(business)
        {
        }
    
    }
}
