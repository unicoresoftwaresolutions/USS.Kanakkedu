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

        [Parameter]
        public bool IsAction { get; set; }
        public Type type { get; set; }
        public USS_Grid()
        {
            type = typeof(T);
            var t1 = type.GetTypeInfo();

            if(t1.IsGenericType)  type = t1.GenericTypeArguments[0];
        }
    }
}
