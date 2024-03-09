using System;

internal class Program
{
    public static void Main(string[] args)
    {
        //Un tren sale de la estación “A” a las 10:00 AM y viaja a una velocidad constante de 80 km/h. Un segundo tren sale de la misma estación a las 11:00 AM y viaja en la misma dirección a una velocidad constante de 100 km/h. ¿A qué hora el segundo tren alcanzará al primer tren? Mostrar esta hora en pantalla

        // solicitar datos
        double horaa,horab,vela,velb,dif;
        Console.Write("Ingrese los dos primeros dígitos en horario militar");
        Console.Write("\nIngrese la hora de salida del tren A:") ;
        horaa=Convert.ToDouble(Console.ReadLine());
        Console.Write("\nIngrese la hora de salida del tren B:");
        horab = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nIngrese solo números enteros positivos para la velocidad");
        Console.Write("\nIngrese la velocidad de salida del tren A:");
        vela=Convert.ToDouble(Console.ReadLine());
        Console.Write("\nIngrese la velocidad de salida del tren B:");
        velb = Convert.ToDouble(Console.ReadLine());
        // Convertir de horas a minutos

        horaa = horaa * 60;// Convertir a minutos
        horaa = horab * 60;
        dif= horab-horaa;// diferencia en tiempo tren B vs Tren A
        double distancia = dif / (60 * vela);// Distancia entre los dos trenes
        double alcanzar = distancia / (vela * velb);// Tiempo que tomara en alcanzar Tren A a B
        double tiempt = horab + alcanzar;// minutos totales en alcanzar

        // Conversion de minutos a horas y fraccion de hora



    }
}