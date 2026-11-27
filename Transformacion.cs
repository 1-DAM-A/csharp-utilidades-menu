using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 1. Repetir dos strings las veces que indique el usuario
        Console.Write("Introduce el primer texto: ");
        string texto1 = Console.ReadLine() ?? "";

        Console.Write("Introduce el segundo texto: ");
        string texto2 = Console.ReadLine() ?? "";

        Console.Write("¿Cuántas veces quieres repetirlos?: ");
        int repeticiones = int.Parse(Console.ReadLine() ?? "1");

        Console.WriteLine($"Resultado 1: {RepetirDosStrings(texto1, texto2, repeticiones)}");

        // 2. Repetir cada letra de un string (NBA -> NNBBAA)
        string siglas = "NBA";
        Console.WriteLine($"Resultado 2 ({siglas}): {RepetirCadaLetra(siglas)}");

        // 3. Borrar del primer string las apariciones del segundo
        string frase = "Hola mundo, el mundo es grande";
        string aBorrar = "mundo";
        Console.WriteLine($"Resultado 3: {BorrarApariciones(frase, aBorrar)}");
    }

    // 1. Repite ambos strings concatenados el número de veces indicado
    static string RepetirDosStrings(string s1, string s2, int veces)
    {
        if (veces <= 0) return string.Empty;

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < veces; i++)
        {
            sb.Append(s1);
            sb.Append(s2);
        }

        return sb.ToString();
    }

    // 2. Duplica cada carácter de la cadena
    static string RepetirCadaLetra(string texto)
    {
        StringBuilder sb = new StringBuilder(texto.Length * 2);

        foreach (char c in texto)
        {
            sb.Append(c);
            sb.Append(c);
        }

        return sb.ToString();
    }

    // 3. Elimina todas las apariciones del segundo string dentro del primero
    static string BorrarApariciones(string textoPrincipal, string subcadenaABorrar)
    {
        if (string.IsNullOrEmpty(subcadenaABorrar)) return textoPrincipal;

        return textoPrincipal.Replace(subcadenaABorrar, string.Empty);
    }
}