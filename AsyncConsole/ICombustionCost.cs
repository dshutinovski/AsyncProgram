namespace AsyncConsole
{
    using System.Threading.Tasks;

    public interface ICombustionCost
    {
        Task<double> CostPerDistance(int distance, double fuelPrice);

        Task<double> CostPerHoursDrivenAtCertainSpeed(int hours, int speed, double fuelPrice);
    }
}