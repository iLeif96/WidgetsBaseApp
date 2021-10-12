using System;

using iLeif.Widgets.AbstarctBase;
using iLeif.Graphic;

namespace iLeif.Widgets.WidgetTypes
{
    public class Button : Widget
    {
        public Button(WidgetModel model, WidgetPresenter Presenter, WidgetView view) : base(model, Presenter, view)
        {

        }
    }

    internal class ButtonModel : BaseModel, IButton
    {
        public bool IsPressed { get; set; }
        public Action Command { get; set; }
        public string Text { get; set; }
        public double IcoWidth { get; set; }
        public double IcoHeigth { get; set; }
        public string URL { get; set; }
        public bool IsIcoUsing { get; set; }
        public Size Size { get; set; }
        public bool IsActive { get; set; }
        public bool IsCollapced { get; set; }
        public UId Id { get; }
    }
}
