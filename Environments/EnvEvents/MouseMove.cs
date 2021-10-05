namespace iLeif.Environments.EnvEvents
{
package com.kniazkov.widgets.events;

import com.kniazkov.widgets.*;
import com.kniazkov.widgets.lib.UId;

/**
 * The 'mouse move' event
 */
public class MouseMove implements Event {
    private String id;
    private UId widgetId;
    private int X;
    private int Y;

    MouseMove(String id, UId widgetId, int X, int Y) {
        this.id = id;
        this.widgetId = widgetId;
        this.X = X;
        this.Y = Y;
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
        if (model instanceof MouseCoordinatesModel) {
            ((MouseCoordinatesModel) model).setMouseCoordinates(X, Y);
            result = true;
        }
        Controller controller = widget.getController();
        if (controller instanceof MouseMoveController) {
            ((MouseMoveController) controller).onMouseMove(X, Y);
        }
        return result;
    }
}
}