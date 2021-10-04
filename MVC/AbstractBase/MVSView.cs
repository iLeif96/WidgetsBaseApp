namespace iLeif.MVC.AbstractBase
{
    public abstract class MVSView : IView
    {
        public abstract void Hide();
        public abstract void Show();
        public abstract void ShowButton();
        public abstract void ShowContainer();
        public abstract void ShowEntity();
        public abstract void ShowText();
    }
}
