/*RANDOM
copy
*/
using System;
class Aula2301                     //metodos de manipulação de vetores e matrizes
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
   //public void Copy(Ar_destino,_a_partir_desta_pos);
   Console.WriteLine("copy");                 //copia vetor inteiro
   Array.Copy(vetor1,vetor2,vetor1.Length);
   foreach(int n in vetor2){
   Console.WriteLine(n);
   }

        }
}