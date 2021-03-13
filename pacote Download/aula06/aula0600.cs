using System;
class Aula0600
{
    static void Main() {
        int n1,n2,n3;
        n1=10;n2=20;n3=30;
        Console.WriteLine ("n1=\t{0}\n, n2={1}\n, n3={2}\n",n1,n2,n3);// Indexação O \n é a quebra de linha e o \t é tabulação 
       double valorCompra=5.50;
       double valorVenda;
       double lucro=0.1;
       string produto="Pastel";

       valorVenda=valorCompra+(valorCompra*lucro);

       Console.WriteLine ("Produto........:{0,15}",produto);
       Console.WriteLine ("Val.Compra.....:{0,15:c}",valorCompra);
       Console.WriteLine ("Lucro..........:{0,15:p}",lucro);
       Console.WriteLine ("Val.Venda......:{0,15:c}",valorVenda);
        }
}