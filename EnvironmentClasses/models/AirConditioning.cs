namespace EnvironmentClasses.models
{
    public class AirConditioning
    {
        //atributos de la clase aire acondicionado (AirConditioning)
        private string Brand { set; get; }

        //constructor
        public AirConditioning(string brand)
        {
            Brand = brand;
        }

        //metodo
        public void Turn()
        {
            Console.WriteLine($"Encendiendo aire acondicionado marca {Brand}.");
        }
    }
}