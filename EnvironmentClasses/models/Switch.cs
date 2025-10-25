namespace EnvironmentClasses.models
{
    public class Switch
    {
        //atributo de la clase Mesa (Switch)
        private string TurnOn { set; get; }

        //constructor
        public Switch(string turnOn)
        {
            TurnOn = turnOn;
        }

        //metodo
        public void LightUpLamps()
        {
            Console.WriteLine($"{TurnOn} las luces");
        }
    }
}