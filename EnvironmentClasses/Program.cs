using System;
using EnvironmentClasses.models;

class Program
{
    static void Main()
    {
        //instancias
        Table table = new Table("Rojo");
        table.Still();

        Chair chair = new Chair("Verde", "Metal y Acolchado");
        chair.Still();
    }
}
