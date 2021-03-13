/*RANDOM
GetValue
indexOf/LastindexOf
*/
using System;
class Aula2304                     //metodos de manipulação de vetores e matrizes
{
    static void Main() {
     int[] vetor1=new int[5];
     int[] vetor2=new int[5];
     int[] vetor3=new int[5];
     int[,] matriz=new int[2,5]{{11,22,00,44,55,},{66,77,88,99,00}};

    Random random=new Random();
    for(int i=0;i<vetor1.Length;i++){
       vetor1[i]=random.Next(50);
    }
        Console.WriteLine ("Elementos do vetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
      Console.WriteLine("----------------------------------------------");

        //public object GetValue(long indice);
   Console.WriteLine("GetValue");                 //busca em um indice e traz seu valor
   int Valor0=Convert.ToInt32(vetor1.GetValue(3));
   int Valor1=Convert.ToInt32(matriz.GetValue(1,3));
   Console.WriteLine("valor da posição 3 vetor1 {0}",Valor0);
   Console.WriteLine("valor da posição 3 matriz {0}",Valor1);
   Console.WriteLine("----------------------------------------------");

   //public static int IndexOf(dimenção);
   Console.WriteLine("IndexOf");          //traz o indice do primeiro valor que voce procura
   int Indice1=Array.IndexOf(vetor1,3);
   Console.WriteLine("primeiro indice do vetor com este valor é: {0}",Indice1);
   Console.WriteLine("----------------------------------------------");

   //public static int LastIndexOf(dimenção);
   Console.WriteLine("LastIndexOf");          //traz o indice do ultimo valor que voce procura
   int Indice2=Array.LastIndexOf(vetor1,3);
   Console.WriteLine("ultimo indice do vetor com este valor é: {0}",Indice2);
   Console.WriteLine("----------------------------------------------");
        }
}