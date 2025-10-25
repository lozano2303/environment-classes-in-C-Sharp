namespace EnvironmentClasses.models
{
    public class Apprentice
    {   
        //atributos de clase aprendiz (Apprentice)
        private int Age { set; get; }
        private string Name { set; get; }

        //constructor
        public Apprentice(int age, string name)
        {
            Age = age;
            Name = name;
        }

        //metodo
        public void SayHello()
        {
            Console.WriteLine($"Hola mi nombre es {Name} y mi edad es {Age}");
        }

    }
}