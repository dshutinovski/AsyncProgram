namespace AsyncConsole
{
    public class Car
    {
        public int Weels { get; private set; }

        // ReSharper disable once MemberCanBePrivate.Global
        public int CarLenght { get; private set; }

        public double Weight { get; private set; }

        public int Combustion { get; private set; }

        public bool IsCarStarted { get; private set; }

        public int Width { get; private set; }

        public Manufacturer Manufacturer { get; private set; }

        public VeicleType VeicleType { get; private set; }

        public Car(CarModel carModel)
        {
            ConstructCar(carModel);
        }

        private void ConstructCar(CarModel carModel)
        {
            switch (carModel)
            {
                case CarModel.BMWX3:
                    Weels = 17;
                    CarLenght = 5;
                    Weight = 2;
                    Width = 4;
                    Manufacturer = Manufacturer.BMW;
                    Combustion = 10;
                    VeicleType = VeicleType.SUV;
                    break;
                case CarModel.HondaCivic:
                    Weels = 17;
                    CarLenght = 4;
                    Weight = 1.5;
                    Width = 3;
                    Combustion = 8;
                    Manufacturer = Manufacturer.Honda;
                    VeicleType = VeicleType.HatchBack;
                    break;
                case CarModel.MercedesC:
                    Weels = 17;
                    CarLenght = 4;
                    Weight = 1.5;
                    Width = 3;
                    Combustion = 8;
                    Manufacturer = Manufacturer.Mercedes;
                    VeicleType = VeicleType.Sedan;
                    break;
                case CarModel.SuzukiSwift:
                    Weels = 16;
                    CarLenght = 4;
                    Weight = 1;
                    Combustion = 7;
                    Width = 3;
                    Manufacturer = Manufacturer.Suzuki;
                    VeicleType = VeicleType.HatchBack;
                    break;
            }
        }

        public VeicleType GetVeicleType()
        {
            return VeicleType;
        }

        public Manufacturer GetManufacturer()
        {
            return Manufacturer;
        }

        public void Start()
        {
            IsCarStarted = true;
        }

        public void Stop()
        {
            IsCarStarted = false;
        }
    }
}