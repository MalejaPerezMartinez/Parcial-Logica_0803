using System;

internal class Program
{
    public static void Main(string[] args)
    {
        //Un tren sale de la estación “A” a las 10:00 AM y viaja a una velocidad constante de 80 km/h. Un segundo tren sale de la misma estación a las 11:00 AM y viaja en la misma dirección a una velocidad constante de 100 km/h. ¿A qué hora el segundo tren alcanzará al primer tren? Mostrar esta hora en pantalla

        double horaa,horab,vela,velb;
        Console.Write("Ingrese los dos primeros dígitos en horario militar");
        Console.Write("Ingrese la hora de salida del tren A:") ;
        horaa=Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la hora de salida del tren B:");
        horab = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese solo números enteros positivos para la velocidad");
        Console.Write("Ingrese la velocidad de salida del tren A:");
        vela=Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la velocidad de salida del tren B:");
        velb = Convert.ToDouble(Console.ReadLine());

    }
}