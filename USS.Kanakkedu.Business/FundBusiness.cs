using System;
using System.Collections.Generic;
using System.Text;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;
using USS.Kanakkedu.Business.Interface;

namespace USS.Kanakkedu.Business
{
    public class FundBusiness : BaseBusiness<Fund>, IFundBusiness
    {
        public FundBusiness(IFundData data) : base(data)
        {

        }
    }
}
