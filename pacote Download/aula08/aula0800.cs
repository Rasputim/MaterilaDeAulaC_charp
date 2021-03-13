using System; //capturando valore do teclado
class Aula0800
{
    static void Main() {
        int v1,v2,v3,soma;
        //------------------------------------------
        string nome;
         Console.Write ("Digite seu nome: ");
        nome=Console.ReadLine();
        Console.WriteLine ("Seu nome é: {0}",nome);
        //------------------------------------------
        Console.Write ("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine());               //int.Parse() converte a string de entrada em inteiro
        Console.Write ("Digite o sedundo valor: ");
        v2=int.Parse(Console.ReadLine());
        Console.Write ("Digite o terceiro valor: ");
        v3=int.Parse(Console.ReadLine());
        soma=(v1+v2)*v3;
        Console.Write ("O resultado na equação (x + y)*w é: {0} senhor {1}",soma,nome);
        }
}