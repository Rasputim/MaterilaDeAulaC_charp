using System;  //metodos passagem por valor e passagem por referencia
/* Metodos são conjuntos de intruções que podem ser
 chamados pelo programa a qualquer instante metodos
  podem reseber parametros de entrada  ou retornar vaores
*/
class aula2400             //metodo parece com função
{
    static void Main() { 
          int v1,v2,r;
        ola();//metodo sem entrada
        Console.WriteLine("Digite primeiro numero");
        v1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite segundo numero");
        v2=Convert.ToInt32(Console.ReadLine());
        r=soma(v1,v2);
         Console.WriteLine ("A soma de {0} e {1} é: {2}",v1,v2,r);
        
        }
    static void ola(){  //metodo sem entrada e void indica sem retornos
        Console.WriteLine ("Primeiro metodo");
        Console.WriteLine ("curso C#");
    }
    static int soma(int n1,int n2){    //n1 n2 são os dois argumentos
        int res=n1+n2;
        return res;                   //retorno

    }
}