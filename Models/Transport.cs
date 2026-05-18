using Lab1_BAI_01.Interfaces;

namespace Lab1_BAI_01.Models
{
    public class Transport : ITransport
    {
        protected double averageSpeed;
        protected string model = "";
        protected int passengers;

        public double AverageSpeed
        {
            get => averageSpeed;
            set
            {
                if (value > 0)
                    averageSpeed = value;
            }
        }

        public string Model
        {
            get => model;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    model = value;
            }
        }

        public int Passengers
        {
            get => passengers;
            set
            {
                if (value >= 0)
                    passengers = value;
            }
        }

        // Parent constructor
        public Transport(double speed, string model, int passengers)
        {
            AverageSpeed = speed;
            Model = model;
            Passengers = passengers;
        }

        // Virtual method
        public virtual string GetInfo()
        {
            return $"Model: {Model}, Speed: {AverageSpeed}";
        }

        // Interface methods
        public virtual double CalculateFuelConsumption(double distance)
        {
            return 0;
        }

        public double CalculateTravelTime(double distance)
        {
            return distance / AverageSpeed;
        }

        // Overloaded method
        public double CalculateTravelTime(double distance, double extraHours)
        {
            return (distance / AverageSpeed) + extraHours;
        }
    }
}