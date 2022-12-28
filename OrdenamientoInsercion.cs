namespace Ordenamiento;
using System.Diagnostics;
class OrdenamientoInsercion
{
    static void Main(string[] args)
    {
        float[] A = { 14, 9, 16, 1, 13, 17 };
        Console.WriteLine("Arreglo desordenado: ");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($" {A[i]} ");

        }

        Insercionlineal(A, 6);
        Console.WriteLine("\nArreglo Ordenado por insercion lineal: ");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($" {A[i]} ");
        }
    }

    static void Insercionlineal(float[] A, int n)
    {
        int i, j;
        bool encontrado;
        float auxiliar;
        for (i = 1; i < n; i++)
        { // A[0], A[1], ..., A[i-1] está ordenado
            auxiliar = A[i];
            j = i - 1;
            encontrado = false;
            while ((j >= 0) && !encontrado)
            {
                if (A[j] > auxiliar)
                { // se mueve dato hacia la derecha para la inserción
                    A[j + 1] = A[j];
                    j--;
                }
                else
                {
                    encontrado = true;
                }
            }
            A[j + 1] = auxiliar;

        }
    }
}


