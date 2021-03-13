using System;
public class Jogador{             //
      public int energia=100;            //propriedade
      public bool vivo=true;             //propriedade
}
class Aula
{
    static void Main() {
        Jogador j1=new Jogador();        //primeiro Objeto
        Jogador j2=new Jogador();
        Jogador j3=new Jogador();
        j1.energia=500;
        j2.energia=10;
        j3.energia=50;
        Console.WriteLine("Energia do jogador 1{0}",j1.energia);
        }
}
