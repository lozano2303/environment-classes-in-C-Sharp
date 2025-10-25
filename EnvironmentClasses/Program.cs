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

        Laptop laptop = new Laptop("HP");
        laptop.Turn();

        Tv tv = new Tv("LG");
        tv.Turn();

        AirConditioning air = new AirConditioning("LG");
        air.Turn();

        Mouse mouse = new Mouse("Negro");
        mouse.Drag();

        Keyboard key = new Keyboard("Negro");
        key.Write();

        TvStand stand = new TvStand("Hierro");
        stand.Static();

        VideoCable video = new VideoCable(2);
        video.HowLongIs();

        Apprentice apprentice = new Apprentice(19, "Cristofer");
        apprentice.SayHello();

    }
}
