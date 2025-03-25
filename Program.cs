namespace Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car=new Carbuilder().SetEngine("V8").SetSeats(4).AddGPS().AddAirbags().Build();
            car.specification();
        }
    }
}
