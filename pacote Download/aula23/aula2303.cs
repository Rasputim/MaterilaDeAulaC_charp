/*RANDOM
GetLenght(pulou a explicação)
GetLowBond
GetUppBond
*/
using System;
class Aula2303                     //metodos de manipulação de vetores e matrizes
{
    static void Main() {
     int[] vetor1=new int[5];
     int[] vetor2=new int[5];
     int[] vetor3=new int[5];
     int[,] matriz=new int[2,5]{{11,22,00,44,55,},{66,77,88,99,100}};

    Random random=new Random();
    for(int i=0;i<vetor1.Length;i++){
       vetor1[i]=random.Next(50);
    }
        Console.WriteLine ("Elementos do vetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        //public int GetLength(dimenção);
   Console.WriteLine("GetLength");                 //discre a quantidade de elementos de um vetor
   long qtdeElementosVetor=vetor1.GetLength(0);
   long qtdeElementosMatriz=matriz.GetLength(1);
   Console.WriteLine("Quantidade de elementos do vetor {0}",qtdeElementosVetor);
   Console.WriteLine("Quantidade de elementos da dimenção D1 matriz {0}",qtdeElementosMatriz);
   Console.WriteLine("----------------------------------------------");

   //public int GetLowerBound(dimenção);
   Console.WriteLine("GetLowerBound");          //encontra o menor indice de uma detreminada dimenção no caso 0
   int MenorIndiceVetor=vetor1.GetLowerBound(0);
   int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
   Console.WriteLine("Menor indice do vetor {0}",MenorIndiceVetor);
   Console.WriteLine("Menor indice da matriz dimenção D1 {0}",MenorIndiceMatriz_D1);
   Console.WriteLine("----------------------------------------------");

   //public int GetUpperBound(dimenção);
   Console.WriteLine("GetUpperBound");          //encontra o maior indice de uma detreminada dimenção no caso 4
   int MaiorIndiceVetor=vetor1.GetUpperBound(0);
   int MaiorIndiceMatriz_D1=matriz.GetUpperBound(1);
   Console.WriteLine("Maior indice do vetor {0}",MaiorIndiceVetor);
   Console.WriteLine("Maior indice da matriz dimenção D1 {0}",MaiorIndiceMatriz_D1);
   Console.WriteLine("----------------------------------------------");
        }
}