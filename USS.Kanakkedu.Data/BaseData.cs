using Microsoft.EntityFrameworkCore;
using USS.Kanakkedu.Data.Interface;
namespace USS.Kanakkedu.Data
{
    public class BaseData<T> : IBaseData<T> where T : class
    {
        protected readonly KanakkeduDBContext db;
        protected readonly DbSet<T> entity;
        public BaseData(KanakkeduDBContext dBContext)
        {
            db = dBContext;
            entity = db.Set<T>();
        }


        public List<T> GetAll()
        {
            return entity.ToList();
        }

        public bool Insert(T item)
        {
            entity.Add(item);
            db.SaveChanges();
            return true;
        }

        public bool Update(T item)
        {
            entity.Update(item);
            db.SaveChanges();
            return true;
        }


        public bool Delete(Guid Id)
        {
            var d = entity.Find(Id);
            if (d != null) entity.Remove(d);
            db.SaveChanges();
            return true;
        }
    }
}
