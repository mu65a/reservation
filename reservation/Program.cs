using System;
namespace reservation
{



    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Flight Reservation System!");

            
            Console.WriteLine("Enter your first and last name:"); //name
            string name = Console.ReadLine();

            // Get the day of travel
            Console.WriteLine("Enter the day you want to travel (dd/mm/yyyy): ");
            string travelDayInput = Console.ReadLine();
            DateTime travelDay;
            while (!DateTime.TryParse(travelDayInput, out travelDay))
            {
                Console.Write("Invalid date format. Please enter the day you want to travel (dd/mm/yyyy): ");
                travelDayInput = Console.ReadLine();
            }

            // Get the destination
            Console.WriteLine("Enter your destination country: ");
            string destination = Console.ReadLine().ToLower();

            // Display the flight schedule based on the destination
            Console.WriteLine($"Searching for available flights to {destination} on {travelDay.ToShortDateString()}...");

            switch (destination)
            {
                case "japan":
                    Console.WriteLine("Flight Number: JP123, Departure: 14:30");
                    Console.WriteLine("Flight Number: JP456, Departure: 17:45");
                    break;
                case "usa":
                    Console.WriteLine("Flight Number: US789, Departure: 09:00");
                    Console.WriteLine("Flight Number: US101, Departure: 22:00");
                    break;
                // Add more cases for other destinations as needed
                default:
                    Console.WriteLine("No flights available to the specified destination today.");
                    break;
            }

            Console.WriteLine($"Thank you for using our service {name} !");
            Console.ReadKey();
        }
    }
}
