using System;  //metodos argumentos  de entrada por referencia
class Pincipal
{
    static void Main() {
        int num=10;                        //variavel local
        dobrar(ref num);                       //chama o metodo e passa a referencia
        Console.WriteLine ("valor dobrado{0}",num);
        }
    static void dobrar(ref int valor){         //lé o que tiver naquela memoria
        valor*=2;
    }    
}