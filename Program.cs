namespace Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter vehicle type");
            string vehicle = Console.ReadLine();

            Ivehiclefactory factory = Vehicle_factory_creator.Getvehicleactory(vehicle);
            Ivehicle type = factory.Createvehicle();

            Console.WriteLine(type.Vehicletype());
            Console.WriteLine("No of wheels "+type.Numberofwheels() );

        }
    }
}
