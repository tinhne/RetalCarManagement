using System.Text;
using Name;

namespace RetalCarManagement
{
    class VehicalManagement
    {
        Dictionary<string, Vehicle> list = new Dictionary<string, Vehicle> ();

        public void EnterInfo() {
            while (true)
            {
                System.Console.WriteLine("Choose type vehicle to enter (H: Truck, D: TouristCar or Q: Back to menu:)");
                string? typeVehicle = Console.ReadLine()?.ToUpper();
                if (typeVehicle == "Q") break;
                switch (typeVehicle)
                {
                    case "H":
                        Truck truck = new Truck();
                        truck.Input();

                        if (truck.NumberPlates != null)
                        {
                            list[truck.NumberPlates] = truck;
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid input: NumberPlates cannot be null.");
                        };
                        break;
                    case "Q":
                        TouristCar touristCar = new TouristCar();
                        touristCar.Input();
                        if (touristCar.NumberPlates != null)
                        {
                            list[touristCar.NumberPlates] = touristCar;
                        } else
                        {
                            System.Console.WriteLine("Invalid input: NumberPlates cannot be null");
                        }
                        break;
                    default:
                        System.Console.WriteLine("Invalid input, please enter again!");
                        break;
                }
            }
        }  
        public Vehicle? Search(string numberPlates) {
            if (list.ContainsKey(numberPlates))
            {
                return list[numberPlates];
            } else {
                return null;
            }
        }
        public void Delete(string numberPlates) {
            this.list.Remove(numberPlates);
        }
        public void Show() {
            while (true)
            {
                System.Console.WriteLine("Select task: ");
                System.Console.WriteLine("1. Enter vehicle:");
                System.Console.WriteLine("2. Search vehicle:");
                System.Console.WriteLine("3. Delete vehicle:");
                System.Console.WriteLine("4. Show list: ");
                System.Console.WriteLine("0. End");
                int choose = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}