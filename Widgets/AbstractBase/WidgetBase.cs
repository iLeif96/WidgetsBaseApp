namespace iLeif.Widgets.AbstractBase
{
    public abstract class WidgetBase : IWidget
    {
        private IWidgetModel _model;
        private IWidgetController _controller;
        private IWidgetView _view;

        protected WidgetBase(IWidgetModel model, IWidgetController controller, IWidgetView view)
        {
            _model = model;
            _controller = controller;
            _view = view;
        }

        public virtual void Hide() => _view?.Hide();
        public virtual void Show() => _view?.Show();
    }
}
