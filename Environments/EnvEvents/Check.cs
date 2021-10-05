namespace iLeif.Environments.EnvEvents
{

/**
 * The "check" event
 */
public class Check : IEvent {
    private String id;
    private UId widgetId;
    private boolean checked;

    Check(String id, UId widgetId, boolean checked) {
        this.id = id;
        this.widgetId = widgetId;
        this.checked = checked;
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
        if (model instanceof BooleanModel) {
            ((BooleanModel) model).setBooleanValue(checked);
            result = true;
        }
        Controller controller = widget.getController();
        if (controller instanceof ClickController) {
            ((ClickController) controller).onClick();
        }
        return result;
    }
}
}