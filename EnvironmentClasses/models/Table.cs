namespace EnvironmentClasses.models
{
    public class Table
    {
        //atributo
        private string Color { get; set; }

        //constructor
        public Table(string color)
        {
            Color = color;
        }

        //metodo
        public void Still()
        {
            Console.WriteLine($"Soy una mesa de color {Color}.");
        }
    }
}