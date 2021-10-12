namespace iLeif.Widgets
{
    public interface IPresenter
    {
        void OnInit();

        void OnModelUpdate();
        void OnViewUpdate();
    }
}