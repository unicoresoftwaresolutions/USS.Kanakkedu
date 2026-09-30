using System;
using System.Collections.Generic;
using System.Text;

namespace USS.Kanakkedu.Data.Interface
{
    public interface ICRUD<T>
    {
        List<T> GetAll();
    }
}
