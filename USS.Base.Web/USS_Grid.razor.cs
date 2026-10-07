using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace USS.Base.Web
{
    public partial class USS_Grid<T>
    {
        [Parameter]
        public List<T> Values { get; set; }

        [Parameter]
        public string Title { get; set; }

        public TypeInfo type { get; set; }
        public USS_Grid()
        {
            type = typeof(T).GetTypeInfo();

            type.d
        }
    }
}
