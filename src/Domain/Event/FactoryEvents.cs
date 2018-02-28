using System.Collections.Generic;

namespace Domain.Event
{
    public static class FactoryEvents
    {
        public static IList<IEventHandler<T>> CreateHandles<T>()
        {
            return FactoryObjects.CreateObjects<IEventHandler<T>>();
        }
    }
}
