using iLeif.MVC;

namespace iLeif.Widgets
{
    public interface IWidget : IMVC
    {
        IWidgetEnvironment GetEnvironment();
        void SetEnvironment(IWidgetEnvironment env);

        ///<summary>
        /// Hides the member
        ///</summary>
        void Hide();

        /// <summary>
        ///Shows the member
        ///</summary>
        void Show();
    }
}
