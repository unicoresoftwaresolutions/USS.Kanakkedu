
using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class JournalService : BaseService<Journal>
    {
        private readonly USSKanakkeduHTTPClient _http;
        public JournalService(USSKanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
