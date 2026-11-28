using System;

class Program
{
    static void Main()
    {
        // ---------- SERIE DE PELL ----------
        // Fórmula: cada número = 2 * (el anterior) + (el anterior del anterior)
        Console.WriteLine("Los primeros 15 números de la serie de Pell son:");

        int anteriorDelAnterior = 0;
        int anterior = 1;

        Console.WriteLine(anteriorDelAnterior);
        Console.WriteLine(anterior);

        for (int i = 3; i <= 15; i++)
        {
            int actual = 2 * anterior + anteriorDelAnterior;
            Console.WriteLine(actual);

            anteriorDelAnterior = anterior;
            anterior = actual;
        }

        // ---------- NÚMERO DE ARMSTRONG ----------
        // Un número es de Armstrong si la suma de sus dígitos
        // elevados a la cantidad de dígitos es igual al número.
        // Ejemplo: 153 = 1^3 + 5^3 + 3^3
        Console.WriteLine("Escribe un número para saber si es de Armstrong:");
        int numero = int.Parse(Console.ReadLine());

        // Primero contamos cuántos dígitos tiene
        int copia = numero;
        int cantidadDigitos = 0;

        while (copia > 0)
        {
            copia = copia / 10;
            cantidadDigitos = cantidadDigitos + 1;
        }

        // Ahora sumamos cada dígito elevado a la cantidad de dígitos
        copia = numero;
        int suma = 0;

        while (copia > 0)
        {
            int digito = copia % 10;
            suma = suma + (int)Math.Pow(digito, cantidadDigitos);
            copia = copia / 10;
        }

        if (suma == numero)
        {
            Console.WriteLine("El número " + numero + " es de Armstrong");
        }
        else
        {
            Console.WriteLine("El número " + numero + " NO es de Armstrong");
        }

        // ---------- DÍGITOS DIFERENTES ----------
        Console.WriteLine("Escribe un número para saber si todos sus dígitos son diferentes:");
        int numero2 = int.Parse(Console.ReadLine());

        // Esta lista tiene 10 casillas (una por cada dígito del 0 al 9)
        // Cada casilla es false al principio, que significa "este dígito no ha salido"
        bool[] yaSalio = new bool[10];
        bool todosDiferentes = true;

        copia = numero2;

        while (copia > 0)
        {
            int digito = copia % 10;

            if (yaSalio[digito] == true)
            {
                todosDiferentes = false;
            }

            yaSalio[digito] = true;
            copia = copia / 10;
        }

        if (todosDiferentes)
        {
            Console.WriteLine("El número " + numero2 + " tiene todos sus dígitos diferentes");
        }
        else
        {
            Console.WriteLine("El número " + numero2 + " tiene dígitos repetidos");
        }
    }
}