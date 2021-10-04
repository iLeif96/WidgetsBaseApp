using System;

namespace iLeif.Widgets.AbstractBase
{
    public abstract class WidgetView : IWidgetView
    {
        public void Hide() => throw new NotImplementedException();
        public void Show() => throw new NotImplementedException();
        public void ShowButton() => throw new NotImplementedException();
        public void ShowContainer() => throw new NotImplementedException();
        public void ShowEntity() => throw new NotImplementedException();
        public void ShowText() => throw new NotImplementedException();
    }
}
