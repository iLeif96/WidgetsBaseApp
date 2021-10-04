using iLeif.MVC.AbstractBase;
using iLeif.MVC;

namespace iLeif.Widgets.AbstractBase
{
    public abstract class WidgetMember : MVCMember, IWidget
    {
        protected WidgetMember(IModel model, IController controller, IView view) : base(model, controller, view)
        {

        }

        public virtual void Hide() => _view?.Hide();
        public virtual void Show() => _view?.Show();
    }
}
