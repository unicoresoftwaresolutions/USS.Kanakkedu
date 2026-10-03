namespace USS.Kanakkedu.Data.Interface
{
    public interface IBaseData<T> 
    {
        List<T> GetAll();
        bool Insert(T item);
        bool Update(T item);
        bool Delete(Guid Id);
    }
}
