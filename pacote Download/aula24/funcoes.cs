using System;
class Pincipal
{
    static int calcular(){
        int a = 1;
        int b = 2;
        int c = a + b;

        return c;
    }
    public static void tabuada(int numero){
        for (int i=0;i<=10;i++){
         Console.WriteLine("{0} X {1} = {2}",numero,i,(numero * i) );
        }
    }
    static void print(){
        Console.WriteLine("ola pessoal");
    }
    static void Main() {
        print();
        int retorno= calcular();
        Console.WriteLine (retorno);
        Console.WriteLine ("digite a numaro");
        int t=Convert.ToInt32(Console.ReadLine());
         tabuada(t);
        
        }
}