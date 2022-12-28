namespace Ordenamiento;
using System.Diagnostics;
class OrdenamientoSeleccionPlus
{
    static void Main(string[] args)
    {
        // la hora de inicio de ejecución
        DateTime startTime = DateTime.Now;
        Console.WriteLine("Hora de inicio de ejecución: {0}", startTime);

        float[] A = { 51, 21, 39, 80, 36 };
        Console.WriteLine("Arreglo desordenado: ");

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" {A[i]} ");

        }

        
        Console.Write("\nComienza ord. por seleccion: ".PadRight(36));
        Console.Write("cambio".PadRight(20));
        Console.Write("pasada\n");
        Stopwatch time1 = new Stopwatch();
        time1.Start();//inicio del cronómetro 
        Seleccion(A, A.Length);
        time1.Stop();//fin del cronómetro
        Console.WriteLine($"     Tiempo: {time1.Elapsed.TotalMilliseconds}ms");
        Console.WriteLine("\nArreglo Ordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" {A[i]} ");
        }
    }

    static void Seleccion(float[] A, int n)
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
            for (int k = 0; k < n; k++)
            {
                Console.Write($" {A[k]} ");

            }
            Console.Write("".PadRight(13));
            Console.Write($" {A[indiceMenor]}".PadRight(6));
            Console.Write($" {A[i]} ".PadRight(17));
            Console.WriteLine($" {i} ");
            Console.WriteLine("  ");
        }
    }
}


