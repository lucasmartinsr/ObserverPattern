using System;
using Domain;

namespace ObserverPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            Provider.DispareEventRegister();
            Provider.DispareXptoEvent();
            Console.ReadKey();
        }
    }
}
