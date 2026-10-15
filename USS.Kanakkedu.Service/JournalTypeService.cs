using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class JournalTypeService : BaseService<JournalType>
    {
        public JournalTypeService(USSKanakkeduHTTPClient http): base(http.client)
        {
            
        }
    }
}
