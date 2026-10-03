namespace USS.Kanakkedu.Business.Interface
{
    public interface IBaseBusiness<T>
    {
        List<T> GetAll();

        bool Insert(T item);
        bool Update(T item);
        bool Delete(Guid Id);
    }
}
