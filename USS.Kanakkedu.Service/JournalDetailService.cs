
using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class JournalDetailService : BaseService<JournalDetail>
    {
        private readonly USSKanakkeduHTTPClient _http;
        public JournalDetailService(USSKanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
