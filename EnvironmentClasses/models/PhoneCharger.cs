namespace EnvironmentClasses.models
{
    public class PhoneCharger
    {
        public string Brand { get; set; }
        public int Wattage { get; set; }

        public PhoneCharger(string brand, int wattage)
        {
            Brand = brand;
            Wattage = wattage;
        }

        public void Charge()
        {
            Console.WriteLine($"Cargando el teléfono con el cargador {Brand} de {Wattage}W.");
        }
    }
}