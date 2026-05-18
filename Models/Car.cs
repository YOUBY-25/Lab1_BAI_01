namespace Lab1_BAI_01.Models
{
    public class Car : Transport
    {
        public Car(double speed, string model, int passengers)
            : base(speed, model, passengers)
        {
        }

        public override string GetInfo()
        {
            return $"Car: {Model}, Speed: {AverageSpeed}";
        }

        public override double CalculateFuelConsumption(double distance)
        {
            return distance * 0.08;
        }
    }
}