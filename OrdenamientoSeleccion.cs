namespace Ordenamiento;
using System.Diagnostics;
class OrdenamientoSeleccion
{
    static void Main(string[] args)
    {
        float[] A = { 51, 21, 39, 80, 36 };
        Console.WriteLine("Arreglo desordenado: ");

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" {A[i]} ");

        }
        Seleccion(A, A.Length);

        Console.WriteLine("\nArreglo Ordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" {A[i]} ");
        }

    }

    static void Seleccion(float []A, int n)
    {
        int i, j, indiceMenor;
        float auxiliar;
        for (i = 0; i < n - 1; i++)
        {
            indiceMenor = i; // posición del menor
            for (j = i + 1; j < n; j++)
            {
                if (A[j] < A[indiceMenor])
                {
                    indiceMenor = j; // nueva posición del menor
                }
            }
            auxiliar = A[indiceMenor]; // intercambia posiciones
            A[indiceMenor] = A[i];
            A[i] = auxiliar;
        }
    }

}




