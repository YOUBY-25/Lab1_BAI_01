namespace Lab1_BAI_01.Interfaces
{
    // Interface for transport methods
    interface ITransport
    {
        // Calculates fuel consumption
        double CalculateFuelConsumption(double distance);

        // Calculates travel time
        double CalculateTravelTime(double distance);
    }
}