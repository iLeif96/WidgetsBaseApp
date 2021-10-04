
using iLeif.Widgets.Interfaces.Models;

namespace iLeif.Widgets.Classes.Button
{
    public class ButtonModel : IMouseableModel
    {
        public bool IsLeftKeyPressed { get; set; }
        public bool IsRightKeyPressed { get; set; }
        public bool IsMouseHovered { get; set; }
        public double HoveredTime { get; set; }
    }
}
