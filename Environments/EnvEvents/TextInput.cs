namespace iLeif.Environments.EnvEvents
{
/**
 * The "text input" event
 */
public class TextInput implements Event {
    private String id;
    private UId widgetId;
    private String text;

    TextInput(String id, UId widgetId, String text) {
        this.id = id;
        this.widgetId = widgetId;
        this.text = text;
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
        if (model instanceof TextModel) {
            ((TextModel) model).setText(text);
            result = true;
        }
        Controller controller = widget.getController();
        if (controller instanceof  TextController) {
            ((TextController) controller).onTextInput(text);
        }
        return result;
    }
}
}