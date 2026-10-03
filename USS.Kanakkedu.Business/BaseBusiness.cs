using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;

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

        public bool Insert(T item)
        {
            return data.Insert(item);
        }

        public bool Update(T item)
        {
            return data.Update(item);
        }

        public bool Delete(Guid Id)
        {
            return data.Delete(Id);
        }

    }
}
