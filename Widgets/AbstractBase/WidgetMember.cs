using iLeif.MVC.AbstractBase;
using iLeif.MVC;

namespace iLeif.Widgets.AbstractBase
{
    public abstract class WidgetMember : MVCMember, IWidget
    {
        protected IWidgetEnvironment _env;
        protected WidgetMember(IModel model, IController controller, IView view, IWidgetEnvironment env) : base(model, controller, view)
        {
            _env = env;
        }

        public IWidgetEnvironment GetEnvironment() => _env;
        public void SetEnvironment(IWidgetEnvironment env) => _env = env;

        public virtual void Hide() => _view?.Hide();
        public virtual void Show() => _view?.Show();
    }
}
