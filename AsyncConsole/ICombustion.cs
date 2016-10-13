namespace AsyncConsole
{
    using System.Threading.Tasks;

    public interface ICombustion
    {
        Task<double> CombustionRatioPerDistance(int distance);

        Task<double> CombustionRatioPerHoursDrivenAtCirtainSpeed(int hours, int speed);
    }
}