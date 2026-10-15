
using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class ACYearService : BaseService<ACYear>
    {
        private readonly USSKanakkeduHTTPClient _http;
        public ACYearService(USSKanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
