using System.Text;

namespace Name
{
    class Vehicle
    {
        private string? numberPlates;
        private string? nameVehicle;
        private int capacity;
        private DateTime dateTime;
        private int degreeStandards;

        public string? NumberPlates { get => numberPlates; set => numberPlates = value; }
        public string? NameVehicle { get => nameVehicle; set => nameVehicle = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public int DegreeStandards { get => degreeStandards; set => degreeStandards = value; }

        public Vehicle(string? numberPlates, string? nameVehicle, int capacity, DateTime dateTime, int degreeStandards)
        {
            this.NumberPlates = numberPlates;
            this.NameVehicle = nameVehicle;
            this.Capacity = capacity;
            this.DateTime = dateTime;
            this.DegreeStandards = degreeStandards;
        }
        public Vehicle() {}
        public T InputData<T>(string promptMessage, Func<string, T> parseFunc) {
            while (true)
            {
                System.Console.WriteLine(promptMessage);
                string input = Console.ReadLine() ?? "";
                try
                {
                    return parseFunc(input);
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Invalid input. Please enter a valid {0}", typeof(T).Name);
                }
            }
        }
        public virtual void Input() {
            NumberPlates = InputData("Enter number plates: ", input => input ?? "");
            NameVehicle = InputData("Enter name vehicle: ", input => input ?? "");
            Capacity = InputData("Enter capacity: ", int.Parse);
            DateTime = InputData("Enter inspection date (yyyy-MM-dd): ", DateTime.Parse);
            DegreeStandards = InputData("Enter degree standart", int.Parse);
        }
        public virtual void Output() {
            Console.WriteLine("_______________ Information number plates {0}___________________", NumberPlates);
            Console.WriteLine("Number Plates: " + numberPlates);
            Console.WriteLine("Model Name: " + NameVehicle);
            Console.WriteLine("Capacity: " + Capacity + " kg");
            Console.WriteLine("Inspection Date: " + DateTime.ToString("yyyy-MM-dd"));
            Console.WriteLine("License Standard: " + DegreeStandards);            
        }
    }
}
