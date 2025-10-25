namespace EnvironmentClasses.models
{
    public class PowerCable
    {   
        //atributo de la clase PowerCable
        private int LongCable { set; get; }

        //constructor
        public PowerCable(int longCable)
        {
            LongCable = longCable;
        }

        //metodo
        public void HowLongIs()
        {
            Console.WriteLine($"Soy un cable de poder y mido {LongCable} metros de largo.");
        }
    }
}