namespace EnvironmentClasses.models
{
    public class Mouse
    {   
        //atributos de la clase Mouse
        private string Color { set; get; }

        //constructor
        public Mouse(string color)
        {
            Color = color;
        }
        
        //metodo
        public void Drag()
        {
            Console.WriteLine($"Arrastrando mouse color {Color}");
        }
    }
}