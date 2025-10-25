using System;
using EnvironmentClasses.models;

class Program
{
    static void Main()
    {
        // Instancias de las clases (objetos)

        //instancia de Table
        Table table = new Table("Rojo");
        table.Still();

        //instancia de Chair
        Chair chair = new Chair("Verde", "Metal y Acolchado");
        chair.Still();

        //instancia de Laptop
        Laptop laptop = new Laptop("HP");
        laptop.Turn();

        //instancia de Tv
        Tv tv = new Tv("LG");
        tv.Turn();

        //instancia de AirConditioning
        AirConditioning air = new AirConditioning("LG");
        air.Turn();

        //instancia de Mouse
        Mouse mouse = new Mouse("Negro");
        mouse.Drag();

        //instancia de Keyboard
        Keyboard key = new Keyboard("Negro");
        key.Write();

        //instancia de TvStand
        TvStand stand = new TvStand("Hierro");
        stand.Static();

        //instancia de VideoCable
        VideoCable video = new VideoCable(2);
        video.HowLongIs();

        //instancia de Apprentice
        Apprentice apprentice = new Apprentice(19, "Cristofer");
        apprentice.SayHello();

        //instancia de Instructor
        Instructor instructor = new Instructor(45, "alfonso");
        instructor.SayHello();

        //instancia de el Switch
        Switch switchh = new Switch("Encender");
        switchh.LightUpLamps();

        //instancia de Lamp
        Lamp lamp = new Lamp("Encendido");
        lamp.TurnOn();

        //instancia de Locker
        Locker locker = new Locker("Alto", "Hierro");
        locker.Lock();

    }
}
