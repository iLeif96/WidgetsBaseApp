
using iLeif.Widgets.AbstarctBase;

namespace iLeif.Widgets.WidgetTypes
{
    public class CheckBox : Widget
    {
        public CheckBox(WidgetModel model, WidgetPresenter Presenter, WidgetView view) : base(model, Presenter, view)
        {

        }

        private bool IsChecked { get; set; }
    }

    internal class CheckBoxModel : WidgetBaseModel
    {

    }
}
