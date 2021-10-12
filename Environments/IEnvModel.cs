
using iLeif.Widgets;

namespace iLeif.Environments
{
    public interface IEnvModel : IWidgetModel
    {
        UId Id { get; }
        Graphic.Size Size { get; set; }
        bool IsActive { get; set; }
        bool IsCollapced { get; set; }
    }
}
