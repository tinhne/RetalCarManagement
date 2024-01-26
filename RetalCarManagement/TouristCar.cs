// 2. Lớp Xe Du Lich: Thừa kế từ lớp Xe
// a. Bao gồm các trường cuả lớp xe, bổ sung thêm trường Số chỗ ngồi (int)
// b. Bao gồm phương thức của lớp Xe. Bổ sung vào phương thức Nhập() và Xuất() số chỗ ngồi 
using Name;

namespace RetalCarManagement
{
    class TouristCar : Vehicle
    {
        private int numberOfSeats;
        public TouristCar(){}
        public TouristCar(string? numberPlates, string? nameVehicle, int capacity, DateTime dateTime, int degreeStandards, int numberOfSeats) 
        : base(numberPlates, nameVehicle, capacity, dateTime, degreeStandards)
        {
            this.NumberOfSeats = numberOfSeats;
        }
        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }
        public override void Input() {
            base.Input();
            numberOfSeats = InputData("Enter number of seats: ", int.Parse);
        }
        public override void Output()
        {
            base.Output();
            System.Console.WriteLine("Number of seats: " + NumberOfSeats);
        }
    }
}