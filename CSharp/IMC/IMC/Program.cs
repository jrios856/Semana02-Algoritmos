using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Ingrese su altura (m): ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("IMC: " + imc);

        if (imc < 18.5)
            Console.WriteLine("Bajo peso");
        else if (imc < 25)
            Console.WriteLine("Peso normal");
        else if (imc < 30)
            Console.WriteLine("Sobrepeso");
        else
            Console.WriteLine("Obesidad");
    }
}