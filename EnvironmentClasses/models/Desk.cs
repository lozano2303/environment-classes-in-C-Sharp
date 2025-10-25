namespace EnvironmentClasses.models
{
    public class Desk
    {   
        //atributo
        private string Color { set; get; }

        //Constructor
        public Desk(string color)
        {
            Color = color;
        }
        
        //metodo
        public void Still()
        {
            Console.WriteLine($"Soy un escritorio de color {Color}");
        }
    }
}