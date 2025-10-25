namespace EnvironmentClasses.models
{
    public class Table
    {
        //atributo de la clase Mesa (Table)
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