public class Program
{
    private static void Main(string[] args)
    {
        //Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que realiza.

        double v1, v2, v3,totalv, sueldo,comi;
        Console.Write("Ingrese el valor de su sueldo base:");
        sueldo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el valor de la primera venta:");
        v1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el valor de la segunda venta:");
        v2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el valor de la primera venta:");
        v3 = Convert.ToDouble(Console.ReadLine());

        totalv=(v1 + v2 + v3);
        comi = totalv*0.10;
        sueldo=comi+sueldo;

        if(totalv>1000000)
      
            Console.Write("Gano Benecifio");

        else
        {
            Console.Write("No Gano Beneficio");
        }

    }
}