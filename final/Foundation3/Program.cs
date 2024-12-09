using System;

class Program
{
    static void Main(string[] args)
    {
        //Event 1//
        Address address1 = new Address("123 Main St", "Springfield", "OH");
        Event event1 = new Lecture("Basics of Genealogical Research", "Learn about basic research techniques for common record types and beginning evidence analysis!", "18 December", "5:00 PM", address1, "James Beaumont", 200);

        Console.WriteLine("Short Description");
        Console.WriteLine(event1.ShortDescription());
        Console.WriteLine("");
        Console.WriteLine("Standard Detail");
        Console.WriteLine(event1.StandardDetail());
        Console.WriteLine("");
        Console.WriteLine("Full Detail");
        Console.WriteLine(event1.FullDetail());
        Console.WriteLine("");

        //Event 2//
        Address address2 = new Address("555 Orchard St","Youngstown","OH");
        Event event2 = new Reception("Ohio Historical Society Gala", "Join us for an evening celebrating local contributions and milestones in the Ohio genealogical community.", "15 March", "6:00 PM", address2, "rsvp.ohiohistoricalsociety@email.com");

        Console.WriteLine("Short Description");
        Console.WriteLine(event2.ShortDescription());
        Console.WriteLine("");
        Console.WriteLine("Standard Detail");
        Console.WriteLine(event2.StandardDetail());
        Console.WriteLine("");
        Console.WriteLine("Full Detail");
        Console.WriteLine(event2.FullDetail());
        Console.WriteLine("");

        //Event 3//
        Address address3 = new Address("495 Heritage Lane","Brown","OH");
        Event event3 = new Outdoor("Pioneer Cemetery Restoration Day","Join us as we clean, preserve, and document headstones at the historic Pioneer Cemetery. Activities include guided tours, workshops from local historians, and a picnic lunch.","3 June","9:00 AM", address3, "overcast");

        Console.WriteLine("Short Description");
        Console.WriteLine(event3.ShortDescription());
        Console.WriteLine("");
        Console.WriteLine("Standard Detail");
        Console.WriteLine(event3.StandardDetail());
        Console.WriteLine("");
        Console.WriteLine("Full Detail");
        Console.WriteLine(event3.FullDetail());
        Console.WriteLine("");

    }
}