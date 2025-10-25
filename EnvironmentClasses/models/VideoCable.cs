namespace EnvironmentClasses.models
{
    public class VideoCable
    {   
        //atributo de la clase VideoCable
        private int LongCable { set; get; }

        //constructor
        public VideoCable(int longCable)
        {
            LongCable = longCable;
        }

        //metodo
        public void HowLongIs()
        {
            Console.WriteLine($"Soy un cable de video y mido {LongCable} metros de largo.");
        }
    }
}