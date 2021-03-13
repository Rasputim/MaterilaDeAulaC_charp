                         //construtores e destrutores de classes
using System;
public class Jogador{             //
      public int energia;            //propriedade
      public bool vivo;            //propriedade
      public string nome;
      public Jogador(string n){           //metodo costrutor
          energia=100;
          vivo=true;
          nome=n;
      }
      ~Jogador(){
          Console.WriteLine("jogador {0} destruido ",nome);//metodo destrutivo
     }
}
class Aula
{
    static void Main() {
        string nome1;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome1=Console.ReadLine();
        Jogador j1=new Jogador(nome1);        //primeiro Objeto
        Jogador j2=new Jogador("machel");
        Jogador j3=new Jogador("jordan");
        j1.energia=500;
         Console.WriteLine("nome do jogador 1 {0}",j1.nome);
        Console.WriteLine("Energia do jogador 1 {0}",j1.energia);
        Console.WriteLine("Energia do jogador 2 {0}",j2.vivo);
        Console.WriteLine("Energia do jogador 3 {0}",j3.energia);
        }
}