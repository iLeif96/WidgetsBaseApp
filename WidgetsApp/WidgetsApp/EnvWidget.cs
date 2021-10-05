using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.MVC;
using iLeif.Widgets.AbstractBase;

namespace iLeif.WidgetsApp
{
    public abstract class EnvWidget : WidgetBase
    {
        private EnvWidget(IEnvWidgetModel model, IController controller, IView view) : base(model, controller, view)
        {

        }

        public abstract EnvWidget GetWidget();
        public abstract EnvWidget GetWidget(IEnvWidgetModel model, IController controller, IView view);
    }
}
