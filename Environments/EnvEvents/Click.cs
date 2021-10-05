namespace iLeif.Environments.EnvEvents
{
/**
 * The "click" event
 */
public class Click implements Event {
    private String id;
    private UId widgetId;
    private int count;

    Click(String id, UId widgetId, int count) {
        this.id = id;
        this.widgetId = widgetId;
        this.count = count;
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
            ((ClickModel) model).setClickCount(count);
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