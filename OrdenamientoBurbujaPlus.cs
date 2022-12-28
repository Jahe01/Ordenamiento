namespace Ordenamiento;
using System;
using System.Diagnostics;

class OrdenamientoBurbujaPlus
{
        static void Main6(string[] args)
    {
        // la hora de inicio de ejecución
        DateTime startTime = DateTime.Now;
        Console.WriteLine("Hora de inicio de ejecución: {0}", startTime);

        float[] A = { 50, 20, 40, 80, 30 };
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" {A[i]} ");

        }

        Console.Write("\nComienza Burbuja: ".PadRight(27));
        Console.Write("cambio".PadRight(18));
        Console.Write("pasada\n");
        //Cronómetro
        Stopwatch time1 = new Stopwatch();
        time1.Start();//inicio del cronómetro 
        Burbuja(A, A.Length);
        time1.Stop();//fin del cronómetro
        Console.WriteLine($"     Tiempo: {time1.Elapsed.TotalMilliseconds}ms");

        Console.WriteLine("\nArreglo Ordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" {A[i]} ");
        }
    }
    static void Burbuja(float[] A, int n)
    {
        int i;
        float auxiliar;
        for (i = 0; i < n - 1; i++)
        {             //n–1 pasadas
            for (int j = 0; j < n - 1 - i; j++)
            { // burbujeo de datos
                if (A[j] > A[j + 1])
                {          //comparación de elementos contiguos para intercambio
                    auxiliar = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = auxiliar;
                }
                for (int k = 0; k < n; k++)
                {
                    Console.Write($" {A[k]} ");
                }
                Console.Write("".PadRight(5));
                Console.Write($" {A[j]}".PadRight(5));
                Console.Write($" {A[j + 1]} ".PadRight(15));
                Console.WriteLine($" {i} ");
                Console.WriteLine("  ");
            }
        }
    }

}


