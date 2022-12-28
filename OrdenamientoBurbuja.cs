namespace Ordenamiento;
using System.Diagnostics;
class OrdenamientoBurbuja
{
       static void Mains5(string[] args)
    {
        float[] A = {50, 20, 40, 80, 30 };
        Console.WriteLine("Arreglo desordenado: ");

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" {A[i]} ");

        }
        Burbuja(A, A.Length);


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
            }
        }


    }
}