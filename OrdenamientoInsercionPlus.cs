namespace Ordenamiento;
using System.Diagnostics;
class OrdenamientoInsercionPlus
{
    static void Main2(string[] args)
    {
        // la hora de inicio de ejecución
        DateTime startTime = DateTime.Now;

        Console.WriteLine("Hora de inicio de ejecución: {0}", startTime);

        float[] A = { 14, 9, 16, 1, 13, 17 };
        Console.WriteLine("Arreglo desordenado: ");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($" {A[i]} ");

        }
        //Cronómetro
        Stopwatch time1 = new Stopwatch();
        time1.Start();//inicio del cronómetro
        Console.WriteLine("\nComienza ord. por insercion: \n");


        Insercionlineal(A, 6);
        time1.Stop();//fin del cronómetro
        Console.WriteLine($"\n  Tiempo: {time1.Elapsed.TotalMilliseconds}ms");
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
            for (int k = 0; k < n; k++)
            {
                Console.Write($" {A[k]} ");
            }
            Console.WriteLine(" ");
        }
    }
}
