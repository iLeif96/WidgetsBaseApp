namespace iLeif.MVP
{
    public interface IPresenter
    {
        void OnInit();

        void OnModelUpdate();
        void OnViewUpdate();

        void AddView(IView view);
        void AttachModel(IModel model);
    }
}