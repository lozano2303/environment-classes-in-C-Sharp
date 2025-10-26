namespace EnvironmentClasses.models
{
    public class Phone
    {
        public string Brand { get; set; }

        public Phone(string brand)
        {
            Brand = brand;
        }

        public void Call()
        {
            Console.WriteLine($"El telefono de la marca {Brand} esta sonando, RING RING!");
        }
    }
}