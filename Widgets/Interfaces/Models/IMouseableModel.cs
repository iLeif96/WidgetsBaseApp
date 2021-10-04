namespace iLeif.Widgets.Interfaces.Models
{
    public interface IMouseableModel : IWidgetModel
    {
        bool IsLeftKeyPressed { get; set; }
        bool IsRightKeyPressed { get; set; }
        bool IsMouseHovered { get; set; }
        double HoveredTime { get; set; }
    }
}
