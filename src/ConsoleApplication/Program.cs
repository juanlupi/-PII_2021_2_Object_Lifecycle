//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {

        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            for (int i = 0; i < 100; i++)
            {
                Train train = new Train("train");
            }
            ///train.StartEngines();
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            Console.WriteLine(Train.Count);
            Console.WriteLine($"¿Las dos variables apuntan al mismo objeto? {t1 == t2}"); ///Se imprimirá False en la consola. Esto es porque los objetos referenciados por ambas variables son diferentes, son objetos distintos, cada uno ocupando un espacio diferente en el heap de la memoria.
            Console.WriteLine($"¿Las dos variables apuntan al mismo objeto? {t2 == t3}"); /// También imprimirá falso porque los objetos referenciados por ambas variables son diferentes, son objetos distintos, cada uno ocupando un espacio diferente en el heap de la memoria.   

        }
    }
}