using System.Globalization;

namespace _0414_S3_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors;
            double height;
            CultureInfo culture = new("en-US");

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            Console.Write("Enter a number of floors: ");
            floors = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the desired size of the building: ");
            height = Convert.ToDouble(Console.ReadLine());

            Building idealBuilding = new(floors);
            Building customBuilding = new(floors, height);

            Console.WriteLine("\nBuilding informations:");
            DisplayBuilding(customBuilding);
            Console.WriteLine("\nBuilding informations with size of floor (3m): ");
            DisplayBuilding(idealBuilding);
        }

        static void DisplayBuilding(Building building)
        {
            Console.Write("Number of floors: ");
            Console.WriteLine(building.GetFloorCount());
            Console.Write("Size of building: ");
            Console.WriteLine($"{building.GetSize():N2}m");
            Console.Write("Floor size: ");
            Console.WriteLine($"{building.GetFloorMaxSize():N2}m");
        }
    }
}
