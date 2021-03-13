using System;  //metodos argumentos de entrada ou saida "out"
class Pincipal
{
    static void Main() {
        int divid,divis,quoc,rest;                        //variavel local
        divid=10;
        divis=3;
        quoc=divide(divid,divis,out rest);                      //chama o metodo e passa a referencia
        Console.WriteLine ("{0}/{1}:quaciente= {2} e resto= {3}",divid,divis,quoc,rest);
        }
    static int divide( int dividendo,int divisor,out int resto){         //lé o que tiver naquela memoria
        int quociente;
        quociente=dividendo/divisor;
        resto=dividendo%divisor;
        return quociente;

    }    
}