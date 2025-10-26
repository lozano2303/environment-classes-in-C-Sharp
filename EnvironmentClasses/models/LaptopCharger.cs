namespace EnvironmentClasses.models
{
    public class LaptopCharger
    {
        public string Brand { get; set; }
        public int Wattage { get; set; }

        public LaptopCharger(string brand, int wattage)
        {
            Brand = brand;
            Wattage = wattage;
        }

        public void Charge()
        {
            Console.WriteLine($"Cargando la laptop con el cargador {Brand} de {Wattage}W.");
        }
    }
}