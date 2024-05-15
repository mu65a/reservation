using System;
namespace reservation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Flight Reservation System!");

            //user entered name

            Console.WriteLine("Enter your first and last name:"); 
            string name = Console.ReadLine();

            // user entered the date of travel
            Console.WriteLine("Enter the day you want to travel: ");
            string travelDayInput = Console.ReadLine();
            DateTime travelDay;
            while (!DateTime.TryParse(travelDayInput, out travelDay))
            {
                Console.Write("Invalid date format. Please enter the day you want to travel: ");
                travelDayInput = Console.ReadLine();
            }

            //user entered the country that he wants
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
                case "uae":
                    Console.WriteLine("Filght Number: UA554, Departure: 15:40");
                    Console.WriteLine("Filght Number: UA530, Departure: 18:00");
                    break;
                case "hong kong":
                    Console.WriteLine("Filght Number: HO302, Departure: 02:30");
                    Console.WriteLine("Filght Number: HO303, Departure: 20:00");
                    break;
                case "china":
                    Console.WriteLine("Filght Number: CH100, Departure: 03:00");
                    Console.WriteLine("Filght Number: CH103, Departure: 07:00");
                    break;
                case "spian":
                    Console.WriteLine("Filght Number: SP610, Departure: 10:00");
                    Console.WriteLine("Filght Number: SP615, Departure: 13:30");
                    break;
                case "ksa":
                    Console.WriteLine("Filght Number: KS705, Departure: 22:00");
                    Console.WriteLine("Filght Number: KS707, Departure: 04:15");
                    break;
                default:
                    Console.WriteLine("No flights available to the specified destination today.");
                    break;
            }
            Console.WriteLine("Thank you for using our service"+ name !);
            Console.ReadKey();
        }
    }
}
