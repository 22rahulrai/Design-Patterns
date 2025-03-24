namespace Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter vehicle type");
            string vehicle = Console.ReadLine();

            Ivehicle type = Vehiclefactory.Getvehicle(vehicle);

            Console.WriteLine(type.Vehicletype());
            Console.WriteLine("No of wheels "+type.Numberofwheels() );

        }
    }
}
