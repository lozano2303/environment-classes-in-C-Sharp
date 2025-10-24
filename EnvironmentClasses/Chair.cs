public class Chair
{
    //atributos de la clase silla (Chair)
    private string Color { get; set; }
    private string Material { get; set; }

    //constructor
    public Chair(string color, string material)
    {
        Color = color;
        Material = material;
    }

    //metodo
    public void Still()
    {
        Console.WriteLine($"Soy una silla de color {Color} que esta hecha de {Material}.");
    }
}