namespace iLeif.Widgets.AbstractBase
{
    public abstract class BasePresenter : IPresenter
    {
        public abstract void OnInit();
        public abstract void OnModelUpdate();
        public abstract void OnViewUpdate();
    }
}
