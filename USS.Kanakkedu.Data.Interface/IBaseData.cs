using System;
using System.Collections.Generic;
using System.Text;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data.Interface
{
    public interface IBaseData<T> 
    {
        List<T> GetAll();
    }
}
