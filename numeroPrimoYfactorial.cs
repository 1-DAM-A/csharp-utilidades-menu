using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Escribe un número para saber si es primo:");
        int numero = int.Parse(Console.ReadLine());
        bool esPrimo = true;

        if (numero < 2)
        {
            esPrimo = false;
        }

        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                esPrimo = false;
            }
        }

        if (esPrimo)
        {
            Console.WriteLine("El número " + numero + " es primo");
        }
        else
        {
            Console.WriteLine("El número " + numero + " NO es primo");
        }

        Console.WriteLine("Escribe un número para calcular su factorial (máximo 20):");
        int n = int.Parse(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }
        
        Console.WriteLine("El factorial de " + n + " es " + factorial);
    }
}
