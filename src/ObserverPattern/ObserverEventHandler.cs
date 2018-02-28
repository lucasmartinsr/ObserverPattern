using System;
using Domain.Event;
using Domain.TypeEvent;

namespace ObserverPattern
{
    public class ObserverEventHandler: IEventHandler<XptoEvent>, IEventHandler<RegisterEvent>
    {
        public void Handle(XptoEvent @event)
        {
            Console.WriteLine("Evento Xpto disparado.");
        }

        public void Handle(RegisterEvent @event)
        {
            Console.WriteLine("Evento Register disparado.");
        }
    }
}
