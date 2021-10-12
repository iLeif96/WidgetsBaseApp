using iLeif.ironments;
using iLeif.Graphic;
using iLeif.Widgets.AbstractBase;

namespace iLeif.Widgets.AbstarctBase
{
    public abstract class WidgetModel : BaseModel, IModel
    {
        public UId Id { get; } = UId.Generate();
        public bool IsActive { get; set; } = true;
        public bool IsCollapced { get; set; } = false;

        public abstract Size Size { get; set; }
    }
}
