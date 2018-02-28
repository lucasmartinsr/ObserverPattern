using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Event
{
    public static class FactoryObjects
    {
        private static readonly IDictionary<Type, IList<Type>> Implementation = new ConcurrentDictionary<Type, IList<Type>>();

        public static IList<T> CreateObjects<T>()
        {
            Type typeInterface = typeof(T);
            IList<Type> typeImplementation;

            if (!Implementation.TryGetValue(typeInterface, out typeImplementation))
            {
                typeImplementation = new List<Type>();

                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    foreach (var tipo in asm.GetTypes())
                    {
                        if (typeInterface.IsAssignableFrom(tipo))
                            typeImplementation.Add(tipo);
                    }
                }

                Implementation[typeInterface] = typeImplementation;
            }

            return typeImplementation.Select(tipo => (T)Activator.CreateInstance(tipo)).ToList();
        }
    }
}
