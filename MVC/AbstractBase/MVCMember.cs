namespace iLeif.MVC.AbstractBase
{
    public abstract class MVCMember : IMVC
    {
        protected readonly UId _id;

        protected IModel _model;
        protected IController _controller;
        protected IView _view;

        protected MVCMember(IModel model, IController controller, IView view)
        {
            _id = UId.Generate();
            _model = model;
            _controller = controller;
            _view = view;
        }

        public IController GetController() => _controller;
        public UId GetId() => _id;
        public IModel GetModel() => _model;
        public IView GetView() => _view;
        public virtual void SetController(IController controller) => _controller = controller;
    }
}
