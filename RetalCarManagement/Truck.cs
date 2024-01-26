using Name;

namespace RetalCarManagement
{
    class Truck : Vehicle
    {
        private double numberOfTons;

        public Truck()
        {
        }

        public Truck(string? numberPlates, string? nameVehicle, int capacity, DateTime dateTime, int degreeStandards, double numberOfTons) : base(numberPlates, nameVehicle, capacity, dateTime, degreeStandards)
        {
            this.NumberOfTons = numberOfTons;
        }
        public double NumberOfTons { get => numberOfTons; set => numberOfTons = value; }

        public override void Input()
        {
            base.Input();
            NumberOfTons = InputData("Enter number of tons: ", double.Parse);
        }
        public override void Output()
        {
            base.Output();
            System.Console.WriteLine("Number of tons: " + NumberOfTons);
        }
    }
}