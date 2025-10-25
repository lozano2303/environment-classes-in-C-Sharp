namespace EnvironmentClasses.models
{
    public class TvStand
    {   
        //atributo de la clase TvStand
        private string Material { get; set; }

        //constructor
        public TvStand(string material)
        {
            Material = material;
        }

        //metodo
        public void Static()
        {
            Console.WriteLine($"Hago de soporte para el Tv, estoy hecho de {Material}");
        }

    }
}