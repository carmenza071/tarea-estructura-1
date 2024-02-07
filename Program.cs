using System;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        int sumaEsquinas = SumarEsquinas(matriz);
        Console.WriteLine("La suma de las esquinas de la matriz es: " + sumaEsquinas);
    }

    static int SumarEsquinas(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        if (filas < 2 || columnas < 2)
        {
            throw new ArgumentException("La matriz debe tener al menos 2 filas y 2 columnas.");
        }

        int suma = matriz[0, 0] + matriz[0, columnas - 1] + matriz[filas - 1, 0] + matriz[filas - 1, columnas - 1];

        return suma;
    }
}


