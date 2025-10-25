namespace EnvironmentClasses.models
{
    public class Lamp
    {   
        //atributos de la clase Lamp
        private string Light { set; get; }

        //constructor
        public Lamp(string light)
        {
            Light = light;
        }
        
        //metodo
        public void TurnOn()
        {
            Console.WriteLine($"He {Light}, ahora ilumino a todos.");
        }

    }
}