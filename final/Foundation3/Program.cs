using System;
namespace foundation3;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Someplace", "NY", "USA");
        Address address3 = new Address("789 Winter Wy", "Middletown", "ID", "USA");

        Outdoor event1 = new Outdoor("Party", "Outdoor rave", "11/2", "11pm", address1, "sunny");
        Lecture event2 = new Lecture("Bridges", "A memoir", "Tomorrow", "12:30pm", address2, "Kyle", "123 people");
        Reception event3 = new Reception("Wedding", "Celebrate a wedding with us", "4/1", "1:45pm", address3, "RSVP: 4 people");


        Console.WriteLine(event1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(event1.FullDetails());
        Console.WriteLine();
        Console.WriteLine(event1.ShortDescription());
        Console.WriteLine();

        Console.WriteLine(event2.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(event2.FullDetails());
        Console.WriteLine();
        Console.WriteLine(event2.ShortDescription());
        Console.WriteLine();

        Console.WriteLine(event3.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(event3.FullDetails());
        Console.WriteLine();
        Console.WriteLine(event3.ShortDescription());
        Console.WriteLine();
    }
}