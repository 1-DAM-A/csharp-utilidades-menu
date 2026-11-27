using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Comprobar palíndromo
        string palabra = "Reconocer";
        Console.WriteLine($"¿'{palabra}' es palíndromo?: {EsPalindromo(palabra)}");

        // 2. Mayúsculas y minúsculas
        string nombre = "Marco";
        MostrarMayusculasYMinusculas(nombre);

        // 3. Contar ocurrencias de una letra
        string texto = "Entornos de Desarrollo";
        char letra = 'o';
        Console.WriteLine($"La letra '{letra}' aparece {ContarOcurrencias(texto, letra)} veces.");
    }

    // 1. Devuelve true si el string es un palíndromo (ignora mayúsculas y espacios)
    static bool EsPalindromo(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto)) return false;

        string limpio = texto.Replace(" ", "").ToLower();
        string invertido = new string(limpio.Reverse().ToArray());

        return limpio == invertido;
    }

    // 2. Escribe el nombre en mayúsculas y en minúsculas
    static void MostrarMayusculasYMinusculas(string nombre)
    {
        Console.WriteLine($"Mayúsculas: {nombre.ToUpper()}");
        Console.WriteLine($"Minúsculas: {nombre.ToLower()}");
    }

    // 3. Devuelve el número de ocurrencias de una letra (distingue o no mayúsculas según prefieras)
    static int ContarOcurrencias(string texto, char letra)
    {
        int contador = 0;
        char letraBuscada = char.ToLower(letra);

        foreach (char c in texto.ToLower())
        {
            if (c == letraBuscada)
            {
                contador++;
            }
        }

        return contador;
    }
}