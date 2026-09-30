using System;
using System.Collections.Generic;
using System.Text;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class JournalTypeBusiness : BaseBusiness<JournalType>, IJournalTypeBusiness
    {
        public JournalTypeBusiness(IJournalTypeData data) : base(data)
        {
        }
    }
}
