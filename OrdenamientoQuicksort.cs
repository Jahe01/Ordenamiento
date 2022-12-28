namespace Ordenamiento;
using System.Diagnostics;
class OrdenamientoQuicksort
{
    static void Main3(string[] args)
    {
        float[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24 };
        Console.WriteLine("Arreglo desordenado: ");

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" {A[i]} ");

        }
        Console.WriteLine("\nPasadas:");
        QuickSort(A, 0, A.Length - 1);

        Console.WriteLine("\nArreglo Ordenado por Quicksort: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" {A[i]} ");
        }
        

    }

    static void QuickSort(float[] a, int primero, int ultimo)
    {
        int i, j, central;
        float pivote;
        central = (primero + ultimo) / 2;
        pivote = a[central];
        i = primero;
        j = ultimo;
        do
        {
            while (a[i] < pivote) i++;
            while (a[j] > pivote) j--;
            if (i <= j)
            {
                float tmp;
                tmp = a[i];
                a[i] = a[j];
                a[j] = tmp; /* intercambia a[i] con a[j] */
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
            QuickSort(a, primero, j); /* mismo proceso con sublista izquierda */
        if (i < ultimo)
            QuickSort(a, i, ultimo); /* mismo proceso con sublista derecha */
    }

}


