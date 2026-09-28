using System.Security.Cryptography;

namespace Fordonsbesikning;

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle();

        Console.WriteLine("skriv in årtal på bilen");
        vehicle.Year = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Har fordonet giltig försäkring? (Ja/Nej)");
        vehicle.HasInsurance = bool.Parse(Console.ReadLine()!);

        Console.WriteLine(vehicle.CheckInspection());

        
    }
}
