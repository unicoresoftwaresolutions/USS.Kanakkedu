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

        public T Insert(T item)
        {

            db.Set<T>().Add(item);
            db.SaveChanges();
            return item;
        }

        public T Update(T item)
        {
            db.Set<T>().Update(item);
            db.SaveChanges();
            return item;
        }


        public bool Delete(T item)
        {
            try
            {
                db.Set<T>().Remove(item);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
    }
}
