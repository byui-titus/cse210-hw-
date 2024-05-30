using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak St", "Metropolis", "NY", "USA");
        Address address3 = new Address("789 Pine St", "Gotham", "CA", "USA");

        // Create events
        Lecture lecture = new Lecture("C# Programming", "An advanced lecture on C# programming.", new DateTime(2024, 6, 15), "10:00 AM", address1, "Dr. John Smith", 50);
        Reception reception = new Reception("Company Annual Gala", "An evening of networking and celebration.", new DateTime(2024, 7, 20), "7:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun outdoor gathering with food and games.", new DateTime(2024, 8, 5), "12:00 PM", address3, "Sunny and warm");

        // Store events in a list
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Display event details
        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("\n===============================\n");
        }
    }
}