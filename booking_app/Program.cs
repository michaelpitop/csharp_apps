using System;
using System.Collections.Generic;

class Booking
{
    static void Main()
    {
        Dictionary<string, int> bookings = new Dictionary<string, int>();

        while (true)
        {
            Console.WriteLine("Enter command (book, cancel, list, quit):");
            string command = Console.ReadLine() ?? string.Empty;

            if (command == "book")
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Enter number of seats:");
                int seats = int.Parse(Console.ReadLine() ?? string.Empty);

                if (bookings.ContainsKey(name))
                {
                    Console.WriteLine("Error: name already booked");
                }
                else
                {
                    bookings.Add(name, seats);
                    Console.WriteLine("Booked {0} seats for {1}", seats, name);
                }
            }
            else if (command == "cancel")
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine() ?? string.Empty;

                if (!bookings.ContainsKey(name))
                {
                    Console.WriteLine("Error: name not found");
                }
                else
                {
                    int seats = bookings[name];
                    bookings.Remove(name);
                    Console.WriteLine("Cancelled {0} seats for {1}", seats, name);
                }
            }
            else if (command == "list")
            {
                Console.WriteLine("Bookings:");
                foreach (KeyValuePair<string, int> booking in bookings)
                {
                    Console.WriteLine("{0}: {1} seats", booking.Key, booking.Value);
                }
            }
            else if (command == "quit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Error: unknown command");
            }
        }
    }
}
