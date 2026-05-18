namespace Lab1_BAI_01.Models
{
    public class Bicycle : Transport
    {
        public Bicycle(double speed, string model, int passengers)
            : base(speed, model, passengers)
        {
        }

        public override string GetInfo()
        {
            return $"Bicycle: {Model}, Speed: {AverageSpeed}";
        }

        public override double CalculateFuelConsumption(double distance)
        {
            return 0;
        }
    }
}