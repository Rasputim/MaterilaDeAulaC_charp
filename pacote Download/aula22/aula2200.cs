using System;
class Aula2200                          //estruturas de repetição loop foreach
{
    static void Main() {
       int[] num=new int[3]{11,22,33};
       for(int i=0;i<num.Length;i++){ //length é o tamanha o de um arrey indeterminado
       Console.WriteLine ("Imprimindo posições do arrey: {0}",num[i]);
       }
        Console.WriteLine ("fim");
        //-------------------------------------------------------------
        foreach(int n in num){        //facilita leitura de vetores independente do tamanho
            Console.WriteLine ("Imprimindo posições do arrey foreach: {0}",n);
        }
        }
}