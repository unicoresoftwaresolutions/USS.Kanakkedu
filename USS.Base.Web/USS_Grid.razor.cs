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


        [Parameter]
        public EventCallback OnAdd { get; set; }

        [Parameter]
        public EventCallback<T> OnCancel { get; set; }

        [Parameter]
        public EventCallback<T> OnEdit { get; set; }


        [Parameter]
        public EventCallback<T> OnDelete { get; set; }


        [Parameter]
        public EventCallback<T> OnSave { get; set; }
        public Type type { get; set; }
        
        public USS_Grid()
        {
            type = typeof(T);
            var t1 = type.GetTypeInfo();

            if(t1.IsGenericType)  type = t1.GenericTypeArguments[0];
        }
    }
}
