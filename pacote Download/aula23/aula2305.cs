/*RANDOM
GetValue
indexOf/LastindexOf
Reverse
SetValue
Sort
*/
using System;
class Aula2305                     //metodos de manipulação de vetores e matrizes
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

        //public void Copy(Ar_destino,_a_partir_desta_pos);
   Console.WriteLine("copy");                 //copia vetor inteiro
   Array.Copy(vetor1,vetor2,vetor1.Length);
   foreach(int n in vetor2){
   Console.WriteLine(n);
   }
      Console.WriteLine("----------------------------------------------");
      
        //public static void Reverse(array);
   Console.WriteLine("Reverse");                 //inverte a ordem dos elementos 
   Array.Reverse(vetor1);
   foreach(int n in vetor1){
            Console.WriteLine(n);
        }
   Console.WriteLine("----------------------------------------------");

   //public void SetValue(object valor,long pos);
   Console.WriteLine("SetValue");                 //Permite setar um valor em um indice no caso valor 99 na primeira posicao indice 0
   vetor2.SetValue(99,0);
  for(int i=0;i<vetor2.Length;i++){
            vetor2.SetValue(0,i);
        }
   Console.WriteLine("vetor2");
foreach(int n in vetor2){
            Console.WriteLine(n);
        }
   Console.WriteLine("----------------------------------------------");

   //public static void Sort(array);
   Console.WriteLine("Sort");                 //O Sorte aruma os elementos em ordem cresente 
   Array.Sort(vetor1);
  Array.Sort(vetor2);
  Console.WriteLine("vetor 1"); 
   foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("vetor 2"); 
   foreach(int n in vetor2){
            Console.WriteLine(n);
        }
   Console.WriteLine("----------------------------------------------");
        }
}