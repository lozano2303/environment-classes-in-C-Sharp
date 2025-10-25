namespace EnvironmentClasses.models
{
public class Laptop
{
    //atributos de la clase Laptop
    private string Brand { set; get; }

    //constructor
    public Laptop(string brand)
    {
        Brand = brand;
    }

    //metodo
    public void Turn()
    {
        Console.WriteLine($"Encendiendo laptop marca {Brand}.");
    }
}
}