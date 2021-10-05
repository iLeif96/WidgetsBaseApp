using System;

using iLeif.Environments.EnvObjects;
using iLeif.Graphic;
using iLeif.MVC;
using iLeif.Widgets.AbstractBase;

namespace WidgetsApp.EnvWidgetTypes
{
    public class Button : EnvWidget
    {
        private Button(IModel model, IController controller, IView view) : base(model, controller, view)
        {

        }
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
