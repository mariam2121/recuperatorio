using System;
using System.Collections.Generic;

class Segunda
{
    static void Main(string [] args)
    {
     
        List<List<int>> matriz = new List<List<int>>
        {
            new List<int> {9,8,7},
            new List<int> {6,5,4},
            new List<int> {3,2,1}
        };

        int resultado = SumarBordes(matriz);
        Console.WriteLine("al sumar los bordes el resultado es " + resultado);
    }

    
        static int SumarBordes(List<List<int>> matriz)
    {
        if (matriz.Count == 0 || matriz.Count != matriz[0].Count)
        {

        }

        int suma = 0;
        int a = matriz.Count;

   
        suma += SumarLista(matriz[0]);

    
        suma += SumarLista(matriz[a - 1]);

    
        for (int i = 1; i < a - 1; i++)
        {
            suma += matriz[i][0];
        }

        for (int i = 1; i < a - 1; i++)
        {
            suma += matriz[i][a - 1];
        }

        return suma;
    }
    static int SumarLista(List<int> lista)
    {
        int suma = 0;
        foreach (int elemento in lista)
        {
            suma += elemento;
        }
        return suma;
    }
}
 