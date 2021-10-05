using System;

using iLeif.Environments.EnvObjects;
using iLeif.Graphic;
using iLeif.Widgets.AbstractBase;

namespace iLeif.EnvWidgets.EnvWidgetTypes
{
    public class Button : EnvWidget
    {

    }

    internal class ButtonModel : WidgetBaseModel, IEnvButton
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
    }
}
