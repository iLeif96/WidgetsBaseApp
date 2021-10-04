using iLeif.MVC;

namespace iLeif.Widgets
{
    public interface IWidget : IMVC
    {
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
