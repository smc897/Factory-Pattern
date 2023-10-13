namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of wheels: ");
            String? str = Console.ReadLine();
            int numWheels = Int32.Parse(str);
            VehicleFactory.GetVehicle(numWheels).Drive();
        }
    }
}
