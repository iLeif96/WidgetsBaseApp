
using iLeif.Widgets.AbstractBase;
using iLeif.Widgets.Interfaces;

namespace iLeif.Widgets.Classes.Button
{
    public class ButtonWidget : WidgetMember, IClickableWidget
    {
        public ButtonWidget(IWidgetModel model, IWidgetController controller, IWidgetView view) : base(model, controller, view)
        {

        }
    }
}
