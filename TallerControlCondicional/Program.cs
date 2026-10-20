using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un numero entero: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(CheckNumber(numero));
    }

    static string CheckNumber(int numero)
    {
        if (numero > 0)
            return "El numero es positivo";
        else if (numero < 0)
            return "El numero es negativo";
        else
            return "El numero es cero";
    }
}
