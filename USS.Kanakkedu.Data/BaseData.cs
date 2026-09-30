using System;
using System.Collections.Generic;
using System.Text;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;
using Microsoft.EntityFrameworkCore;
namespace USS.Kanakkedu.Data
{
    public class BaseData<T> : IBaseData<T> where T : class
    {
        protected readonly KanakkeduDBContext db;
        public BaseData(KanakkeduDBContext dBContext)
        {
            db = dBContext;
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
    }
}
