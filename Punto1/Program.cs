﻿using System.Transactions;

public class Program
{
    private static void Main(string[] args)
    {
        //Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que realiza.

        double v1, v2, v3,totalv, sueldo,comi,prom;
        Console.Write("Ingrese el valor de su sueldo base:");
        sueldo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el valor de la primera venta:");
        v1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el valor de la segunda venta:");
        v2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el valor de la tercera venta:");
        v3 = Convert.ToDouble(Console.ReadLine());

        totalv=(v1 + v2 + v3);
        comi = totalv*0.10;
        sueldo=comi+sueldo;
        prom = comi / 3;
        Console.Write("\nEl valor de la comisión es: " + comi);
        Console.Write("\nEl valor total del suelo es: " + sueldo);
        Console.Write("\nEl valor promedio x comisión es: " + prom);



        if ((v1> v2) && (v2 > v3))
        {
            Console.Write("\nLa máxima venta es la primera:" + v1);
        }
        else if (((v2 > v3) && (v3 > v1)))
        {
            Console.Write("\nLa máxima venta es la segunda " + v2);
        }
        else
        {
            Console.Write("\nLa máxima venta es la tercera" + v3);
        }


        if (totalv>1000000)
      
            Console.Write("\nGano Benecifio");

        else
        {
            Console.Write("\nNo Gano Beneficio");
        }

    }
}