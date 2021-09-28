namespace Practices_280921
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehicle {
        public int Fuel { get; set; }

        public Car(int fuel) {
            Fuel = fuel;
        }

        public void Drive() {
            if (Fuel > 0) {
                System.Console.WriteLine("Driving");
            }
            else {
                System.Console.WriteLine("Not fuel");
            }
        }

        public bool Refuel(int amount) {
            Fuel += amount;
            return true;
        }
    }
}