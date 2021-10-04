using System.Collections.Generic;

using iLeif.MVC;

namespace iLeif.Widgets.Interfaces
{
    public interface ICompositeWidget : IWidget
    {
        Dictionary<UId, IWidget> Children { get; }
        void AddChild(IWidget widget);
        void RemoveChild(UId widgetId);
        void RemoveChildren();
    }
}
