using System;

class Program
{
    static void Main()
    {
        // ---------- SEGUNDOS A HORAS, MINUTOS Y SEGUNDOS ----------
        Console.WriteLine("Escribe un número de segundos:");
        int totalSegundos = int.Parse(Console.ReadLine());

        // 1 hora = 3600 segundos
        // Dividir entre 3600 nos da las horas completas
        int horas = totalSegundos / 3600;

        // Con % sacamos lo que sobra después de quitar las horas
        int resto = totalSegundos % 3600;

        // 1 minuto = 60 segundos
        int minutos = resto / 60;

        // Lo que sobra al quitar los minutos son los segundos
        int segundos = resto % 60;

        Console.WriteLine(totalSegundos + " segundos son " + horas + " hora(s), " + minutos + " minuto(s) y " + segundos + " segundo(s)");
    }
}