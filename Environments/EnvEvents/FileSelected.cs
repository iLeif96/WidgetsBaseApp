namespace iLeif.Environments.EnvEvents
{
package com.kniazkov.widgets.events;

import com.kniazkov.widgets.*;
import com.kniazkov.widgets.lib.UId;

/**
 * The "file selected" event
 */
public class FileSelected implements Event {
    private String id;
    private UId widgetId;
    private String fileName;
    private int fileSize;

    FileSelected(String id, UId widgetId, String fileName, int fileSize) {
        this.id = id;
        this.widgetId = widgetId;
        this.fileName = fileName;
        this.fileSize = fileSize;
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
        boolean result = true;
        /*
        Model model = widget.getModel();
        if (model instanceof TextModel) {
            ((TextModel) model).setText(text);
            result = true;
        }
         */
        Controller controller = widget.getController();
        if (controller instanceof  FileSelectorController) {
            ((FileSelectorController) controller).onFileSelect(fileName, fileSize);
        }
        return result;
    }
}
}