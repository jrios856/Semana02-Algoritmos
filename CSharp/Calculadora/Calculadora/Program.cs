using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer numero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione una opcion:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Resultado: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("Resultado: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("Resultado: " + (num1 * num2));
                break;
            case 4:
                if (num2 != 0)
                    Console.WriteLine("Resultado: " + (num1 / num2));
                else
                    Console.WriteLine("Error: No se puede dividir entre 0");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}