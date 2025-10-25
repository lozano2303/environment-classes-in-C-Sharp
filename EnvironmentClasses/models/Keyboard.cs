namespace EnvironmentClasses.models
{
    public class Keyboard
    {
        //atributos de la clase Teclado (Keyboard)
        private string Color { set; get; }

        //constructor
        public Keyboard(string color)
        {
            Color = color;
        }
        
        //metodo
        public void Write()
        {
            Console.WriteLine($"Escribiendo en teclado color {Color}");
        }    
    }
}