
using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class ACGroupService : BaseService<ACGroup>
    {
        private readonly USSKanakkeduHTTPClient _http;
        public ACGroupService(USSKanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
