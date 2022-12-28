namespace Ordenamiento;
using System.Diagnostics;
class OrdenamientoQuicksortPlus
{
    static void Main(string[] args)
    {
        // la hora de inicio de ejecución
        DateTime startTime = DateTime.Now;
        Console.WriteLine("Hora de inicio de ejecución: {0}", startTime);

        float[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24 };
        Console.WriteLine("\nArreglo desordenado: ");

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" {A[i]} ");

        }
        //Cronómetro
        Stopwatch time1 = new Stopwatch();
        time1.Start();//inicio del cronómetro
        Console.WriteLine("\nComienza ord. por Quicksort: \n");
        QuickSort(A, 0, A.Length - 1);
        time1.Stop();//fin del cronómetro
        Console.WriteLine($"\n  Tiempo: {time1.Elapsed.TotalMilliseconds}ms");

        Console.WriteLine("\nArreglo Ordenado por Quicksort:\n");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" {A[i]} ");
        }
        Console.WriteLine(" ");
    }

    static void QuickSort(float[] a, int primero, int ultimo)
    {
        if (primero < ultimo)
        {
            int pivotIndex = Particion(a, primero, ultimo);
            // Imprimimos la pasada actual
            foreach (float element in a)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            QuickSort(a, primero, pivotIndex - 1);
            QuickSort(a, pivotIndex + 1, ultimo);
        }
    }


    static int Particion(float[] a, int primero, int ultimo)
    {
        float pivot = a[ultimo];
        int i = primero - 1;

        for (int j = primero; j < ultimo; j++)
        {
            if (a[j] <= pivot)
            {
                i++;
                Swap(a, i, j);
            }
        }
        Swap(a, i + 1, ultimo);
        return i + 1;
    }

    static void Swap(float[] a, int i, int j)
    {
        float temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    }

}




