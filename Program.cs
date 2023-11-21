using System; 
using System.Collections.Generic;

class Program{ 

static void Main( string [] args ){

int[] arreglo = {3,4,1,5,2};
BubbleSort(arreglo);
}


static void BubbleSort(int[] arr)
    {
        int a = arr.Length;
        for (int i = 0; i < a - 1; i++)
        {
            for (int s = 0; s < a - i - 1; s++)
            {
                
                if (arr[s] > arr[s + 1])
                {
                  
                    int inter = arr[s];
                    arr[s] = arr[s + 1];
                    arr[s + 1] = inter;
                }
            }
        }
    }

}





 