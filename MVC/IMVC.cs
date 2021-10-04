namespace iLeif.MVC
{
    public interface IMVC
    {
        ///<summary>
        ///  An unique member identifier
        ///</summary>
        UId GetId();

        ///<summary>
        ///A model that contains member data
        ///</summary>
        IModel GetModel();

        ///<summary>
        /// widget representation
        ///</summary>
        IView GetView();

        ///<summary>
        /// A controller that controls this member
        ///</summary>
        IController GetController();

        /// <summary>
        /// Sets another controller to the member
        /// <param name="controller">Another controller </param>
        ///</summary>
        void SetController(IController controller);
    }
}
