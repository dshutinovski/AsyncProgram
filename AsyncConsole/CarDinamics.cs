namespace AsyncConsole
{
    using System.Threading;
    using System.Threading.Tasks;

    public class CarDinamics : ICombustion, ICombustionCost
    {
        public CarDinamics(Car car)
        {
            Car = car;
        }

        private Car Car { get; set; }

        public async Task<double> CombustionRatioPerDistance(int distance)
        {
            await Task.Run(() => Thread.Sleep(2000));
            return CalculateCombustionRatioBasedOnDistance(distance);
        }

        public async Task<double> CombustionRatioPerHoursDrivenAtCirtainSpeed(int hours, int speed)
        {
            await Task.Run(() => Thread.Sleep(3000));
            return CalculateCombustionRatioBasedOnHoursDrivenAtCirtainSpeed(hours, speed);
        }

        public async Task<double> CostPerDistance(int distance, double fuelPrice)
        {
            await Task.Run(() => Thread.Sleep(1500));
            return CalculateCostForParticularDistance(distance, fuelPrice);
        }

        public async Task<double> CostPerHoursDrivenAtCertainSpeed(int hours, int speed, double fuelPrice)
        {
            await Task.Run(() => Thread.Sleep(1500));
            return CalculateCostPerHoursDrivenAtCertainSpeed(hours, speed, fuelPrice);
        }

        private double CalculateCombustionRatioBasedOnDistance(int distance)
        {
            return (double)distance / 100 * (double)Car.Combustion;
        }

        private double CalculateCombustionRatioBasedOnHoursDrivenAtCirtainSpeed(int hours, int speed)
        {
            return hours * (double)speed / 100 * Car.Combustion;
        }

        private double CalculateCostForParticularDistance(int distance, double fuelPrice)
        {
            return (double)distance / 100 * (double)Car.Combustion * fuelPrice;
        }

        private double CalculateCostPerHoursDrivenAtCertainSpeed(int hours, int speed, double fuelPrice)
        {
            return hours * (double)speed / 100 * Car.Combustion * fuelPrice;
        }
    }
}