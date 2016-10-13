using System.Threading.Tasks;

namespace AsyncConsole
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var startCall = DateTime.Now;
            Car car = new Car(CarModel.MercedesC);

            CarDinamics carDinamics = new CarDinamics(car);

            bool response;
            response = CalculateCombustionAsync(carDinamics).Result;
            var endTime = DateTime.Now;
            var timespan = (endTime - startCall).Seconds;
            Console.WriteLine("The call took: {0} seconds", timespan);

            startCall = DateTime.Now;
            car = new Car(CarModel.MercedesC);

            carDinamics = new CarDinamics(car);

            response = CalculateCombustion(carDinamics);
            endTime = DateTime.Now;
            timespan = (endTime - startCall).Seconds;
            Console.WriteLine("The call took: {0} seconds", timespan);
        }

        private static async Task<bool> CalculateCombustionAsync(CarDinamics carDinamics)
        {
            var combustion1 = Task.Run(() => carDinamics.CombustionRatioPerDistance(180).Result);
            var combustion2 = Task.Run(() => carDinamics.CombustionRatioPerDistance(360).Result);
            var combustion3 = Task.Run(() => carDinamics.CombustionRatioPerHoursDrivenAtCirtainSpeed(3, 100).Result);
            var combustion4 = Task.Run(() => carDinamics.CombustionRatioPerHoursDrivenAtCirtainSpeed(8, 80).Result);
            var combustion5 = Task.Run(() => carDinamics.CostPerDistance(1800, 61.5));
            var combustion6 = Task.Run(() => carDinamics.CostPerHoursDrivenAtCertainSpeed(1800, 100, 61.5));

            await Task.WhenAll(combustion1, combustion2, combustion3, combustion4, combustion5, combustion6);

            return true;
        }

        private static bool CalculateCombustion(CarDinamics carDinamics)
        {
            var combustion1 = carDinamics.CombustionRatioPerDistance(180).Result;
            var combustion2 = carDinamics.CombustionRatioPerDistance(360).Result;
            var combustion3 = carDinamics.CombustionRatioPerHoursDrivenAtCirtainSpeed(3, 100).Result;
            var combustion4 = carDinamics.CombustionRatioPerHoursDrivenAtCirtainSpeed(8, 80).Result;
            var combustion5 = carDinamics.CostPerDistance(1800, 61.5).Result;
            var combustion6 = carDinamics.CostPerHoursDrivenAtCertainSpeed(1800, 100, 61.5).Result;

            return true;
        }
    }
}