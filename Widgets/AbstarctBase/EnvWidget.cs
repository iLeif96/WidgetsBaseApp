
using iLeif.Widgets.AbstractBase;

namespace iLeif.Widgets.AbstarctBase
{
    public abstract class Widget : WidgetBase
    {
        internal Widget(WidgetModel model, WidgetPresenter Presenter, WidgetView view) : base(model, Presenter, view)
        {

        }
    }
}
