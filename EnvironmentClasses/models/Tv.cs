namespace EnvironmentClasses.models
{
    public class Tv
{
    //atributos de la clase Tv
    private string Brand { set; get; }

    //constructor
    public Tv(string brand)
    {
        Brand = brand;
    }

    //metodo
    public void Turn()
    {
        Console.WriteLine($"Encendiendo el tv marca {Brand}.");
    }
}
}
