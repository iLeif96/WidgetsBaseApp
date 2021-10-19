using System;

namespace iLeif.Environment
{
    /**
     * An event generated by a widget
     */
    public interface IEvent
    {
        /**
         * @return Event unique identifier
         */
        string getId();

        /**
         * @return Id of a widget related to this event
         */
        Guid GetWidgetId();

        /**
         * Applies this event to widget data
         * @param widget A widget
         */
        //bool Apply(IWidget widget);
    }
}