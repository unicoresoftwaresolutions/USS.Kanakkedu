namespace USS.Kanakkedu.Web.Components.Pages
{
    public class BaseModel<T> where T : new()
    {
        public T data { get; set; }
        public T EditData { get; set; }
        public bool IsEdit { get; set; }
    }
}
