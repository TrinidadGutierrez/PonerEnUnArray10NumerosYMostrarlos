using System;

namespace PonerEnUnArray10NumerosYMostrarlos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            numeros[0] = 3;
            numeros[1] = 5;
            numeros[2] = 6;
            numeros[3] = 14;
            numeros[4] = 28;
            numeros[5] = 39;
            numeros[6] = 23;
            numeros[7] = 32;
            numeros[8] = 37;
            numeros[9] = 398;
           

            int suma = numeros[6] + numeros[7];
            System.Console.WriteLine(suma);

            Console.ReadKey();
        }
    }
}
