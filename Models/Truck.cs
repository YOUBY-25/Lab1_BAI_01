namespace Lab1_BAI_01.Models
{
    public class Truck : Transport
    {
        public Truck(double speed, string model, int passengers)
            : base(speed, model, passengers)
        {
        }

        public override string GetInfo()
        {
            return $"Truck: {Model}, Speed: {AverageSpeed}";
        }

        public override double CalculateFuelConsumption(double distance)
        {
            return distance * 0.2;
        }
    }
}