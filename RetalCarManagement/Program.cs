using Name;

namespace RetalCarManagement;

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Truck();
        vehicle.Input();
        vehicle.Output();
    }
}
