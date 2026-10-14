using System;
using System.Collections.Generic;
using System.Text;
using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class FundService : BaseService<Fund>
    {
        private readonly KanakkeduHTTPClient _http;
        public FundService(KanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
