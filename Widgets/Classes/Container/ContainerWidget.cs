
using System.Collections.Generic;

using iLeif.MVC;
using iLeif.Widgets.AbstractBase;
using iLeif.Widgets.Interfaces;

namespace iLeif.Widgets.Classes.Container
{
    public class ContainerWidget : WidgetMember, ICompositeWidget
    {

        public Dictionary<UId, IWidget> Children { get; } = new Dictionary<UId, IWidget>();

        public ContainerWidget(IModel model, IController controller, IView view) : base(model, controller, view)
        {

        }

        public void AddChild(IWidget widget) => Children.Add(widget.GetId(), widget);
        public void RemoveChild(UId widgetId) => Children.Remove(widgetId);
        public void RemoveChildren() => Children.Clear();
    }
}
