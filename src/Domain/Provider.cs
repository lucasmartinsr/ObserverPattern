using Domain.Event;
using Domain.TypeEvent;

namespace Domain
{
    public class Provider
    {
        public static void DispareEventRegister()
        {
            DomainEvents.Raise(new RegisterEvent());
        }
        public static void DispareXptoEvent()
        {
            DomainEvents.Raise(new XptoEvent());
        }
    }
}
