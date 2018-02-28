namespace Domain.Event
{
    /// <summary>
    /// Provides logic for raising and handling domain events.
    /// </summary>
    public static class DomainEvents
    {
        /// <summary>
        /// Indicates the event.
        /// </summary>
        public static void Raise<T>(T eventArgs)
        {
            foreach (var handle in FactoryEvents.CreateHandles<T>())
            {
                handle.Handle(eventArgs);
            }
        }
    }
}
