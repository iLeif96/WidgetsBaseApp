
using iLeif.ironments;
using iLeif.Widgets;
using iLeif.Widgets.AbstarctBase;
using iLeif.Widgets.WidgetTypes;

namespace iLeif.WidgetsApp
{
    public class WidgetFactory
    {

        public Widget CreateWidget(Iironment , WidgetTypesEnum WidgetType)
        {
            Widget eWidget;
            switch (WidgetType)
            {
                case WidgetTypesEnum.Button:
                    eWidget = new Button();
                    .AddButton(eWidget.GetModels() as IButton);
                    break;
            }
        }

        public Widget CreateWidget(Iironment , WidgetTypesEnum WidgetType, WidgetPresenter Presenter)
        {
            Widget widget = CreateWidget(, WidgetType);
            widget.AddView(Presenter);
        }
    }
}
