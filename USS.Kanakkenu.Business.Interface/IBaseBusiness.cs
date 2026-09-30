using System;
using System.Collections.Generic;
using System.Text;
using USS.Kanakkedu.Data.Interface;

namespace USS.Kanakkedu.Business.Interface
{
    public interface IBaseBusiness<T>
    {
        List<T> GetAll();
    }
}
