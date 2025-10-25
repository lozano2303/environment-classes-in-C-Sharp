namespace EnvironmentClasses.models
{
    public class Instructor
    {   
        //atributos de clase aprendiz (Instructor)
        private int Age { set; get; }
        private string Name { set; get; }

        //constructor
        public Instructor(int age, string name)
        {
            Age = age;
            Name = name;
        }

        //metodo
        public void SayHello()
        {
            Console.WriteLine($"Hola, soy el instructor {Name} y mi edad es {Age}");
        }

    }
}