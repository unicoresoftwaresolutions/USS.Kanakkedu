using System;
using System.Collections.Generic;
using System.Text;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class BaseBusiness<T> : IBaseBusiness<T>
    {
        protected readonly IBaseData<T> data;

        public BaseBusiness(IBaseData<T> data)
        {
            this.data = data;
        }
       
        public List<T> GetAll()
        {
            return data.GetAll();
        }
    }
}
