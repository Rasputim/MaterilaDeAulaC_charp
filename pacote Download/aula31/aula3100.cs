                             //classe estatica 
                             /*A clase static não permite a instanciação direta de seus objetos
                             não posuinda assim construtores o objeto static usa posição fixa na memoria 
                             inposibilitando o opetador "new"
                             */
using System;
public class Jogador{             //criando classe
      public int energia;            //propriedade
      public bool vivo;            //propriedade
      public string nome;
       public Jogador(){                 //metodo costrutor
          energia=100;
          vivo=true;
          nome="Jogador";
      }
      public Jogador(string n){           //metodo costrutor
          energia=100;
          vivo=true;
          nome=n;
      }
      public Jogador(string n,int e){           //metodo costrutor
          energia=e;
          vivo=true;
          nome=n;
      }
      public Jogador(string n,int e,bool v){           //metodo costrutor
          energia=100;
          vivo=v;
          nome=n;
      }
      public void info(){
          Console.WriteLine("Nome jogador:    {0}",nome);
          Console.WriteLine("Energia jogador: {0}",energia);
          Console.WriteLine("Estado jogador:  {0}",vivo);
      }
     /* ~Jogador(){
          Console.WriteLine("jogador {0} destruido ",nome);//metodo destrutivo
     }*/
}
class Aula
{
    static void Main() {
        string nome1;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome1=Console.ReadLine();
        Jogador j1=new Jogador();        //primeiro Objeto
        Jogador j2=new Jogador("machel");
        Jogador j3=new Jogador("jordan",100);
        Jogador j4=new Jogador("neneco",10,false);
        
         j1.info();
         j2.info();
         j3.info();
         j4.info();

         /*Console.WriteLine("nome do jogador é {0} tem energia {1} e esta {2}",j1.nome,j1.energia,j1.vivo);
         Console.WriteLine("nome do jogador é {0} tem energia {1} e esta {2}",j2.nome,j2.energia,j2.vivo);
         Console.WriteLine("nome do jogador é {0} tem energia {1} e esta {2}",j3.nome,j3.energia,j3.vivo);
         Console.WriteLine("nome do jogador é {0} tem energia {1} e esta {2}",j4.nome,j4.energia,j4.vivo);
        */
        }
}