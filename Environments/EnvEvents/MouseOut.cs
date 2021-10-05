namespace iLeif.Environments.EnvEvents
{
package com.kniazkov.widgets.events;

import com.kniazkov.widgets.*;
import com.kniazkov.widgets.lib.UId;

/**
 * The 'mouse out' event
 */
public class MouseOut implements Event {
    private String id;
    private UId widgetId;

    MouseOut(String id, UId widgetId) {
        this.id = id;
        this.widgetId = widgetId;
    }

    @Override
    public String getId() {
        return id;
    }

    @Override
    public UId getWidgetId() {
        return widgetId;
    }

    @Override
    public boolean apply(Widget widget) {
        boolean result = false;
        Model model = widget.getModel();
        if (model instanceof ClickModel) {
            ((ClickModel) model).setMouseOverFlag(false);
            result = true;
        }
        Controller controller = widget.getController();
        if (controller instanceof MouseEventsController) {
            ((MouseEventsController) controller).onMouseOut();
        }
        return result;
    }
}
}