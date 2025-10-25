namespace EnvironmentClasses.models
{
    public class Locker
    {   
        //atributos de la clase Locker
        private string Security { set; get; }
        private string Material { set; get; }

        //constructor
        public Locker(string security, string material)
        {
            Security = security;
            Material = material;
        }

        //metodo
        public void Lock()
        {
            Console.WriteLine($"Soy un locker seguro hecho en {Material}, con un nivel de seguridad {Security}.");
        }
    }
}