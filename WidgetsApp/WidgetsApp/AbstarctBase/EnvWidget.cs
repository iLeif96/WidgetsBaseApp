using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Widgets.AbstractBase;

namespace iLeif.EnvWidgets.AbstarctBase
{
    public abstract class EnvWidget : WidgetBase
    {
        internal EnvWidget(EnvWidgetModel model, EnvWidgetController controller, EnvWidgetView view) : base(model, controller, view)
        {

        }
    }
}
