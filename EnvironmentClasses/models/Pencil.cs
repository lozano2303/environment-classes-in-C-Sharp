namespace EnvironmentClasses.models
{
    public class Pencil
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        public Pencil(string brand, string color)
        {
            Brand = brand;
            Color = color;
        }

        public void Draw()
        {
            Console.WriteLine($"Dibujando un diagrama de clases con un lápiz {Color} de la marca {Brand}.");
        }
    }
}