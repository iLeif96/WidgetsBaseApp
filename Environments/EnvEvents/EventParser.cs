namespace iLeif.Environments.EnvEvents
{
package com.kniazkov.widgets.events;

import com.kniazkov.json.JsonObject;
import com.kniazkov.widgets.lib.UId;

/**
 * Parses events from JSON objects
 */
public class EventParser {
    /**
     * Parses events from JSON objects
     * @param obj An object
     * @return An event
     */
    public static IEvent parse(JsonObject obj) {
        String id = obj.get("id").stringValue();
        UId widgetId = UId.parse(obj.get("widgetId").stringValue());
        if (!widgetId.valid())
            return null;
        String type = obj.get("type").stringValue();
        switch (type) {
            case "text input": {
                String text = obj.get("text").stringValue();
                return new TextInput(id, widgetId, text);
            }
            case "click": {
                int count = obj.get("count").intValue();
                return new Click(id, widgetId, count);
            }
            case "check": {
                boolean checked = obj.get("checked").booleanValue();
                return new Check(id, widgetId, checked);
            }
            case "mouse down":
                return new MouseDown(id, widgetId);
            case "mouse up":
                return new MouseUp(id, widgetId);
            case "mouse over":
                return new MouseOver(id, widgetId);
            case "mouse out":
                return new MouseOut(id, widgetId);
            case "mouse move": {
                int X = obj.get("X").intValue();
                int Y = obj.get("Y").intValue();
                return new MouseMove(id, widgetId, X, Y);
            }
            case "file selected": {
                String fileName = obj.get("fileName").stringValue();
                int fileSize = obj.get("fileSize").intValue();
                return new FileSelected(id, widgetId, fileName, fileSize);
            }
        }
        return null;
    }
}
}