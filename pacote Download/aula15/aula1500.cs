using System;     //switch case
class Aula15
{
    static void Main() {
        int tempo=0;
        char escolha;

        Console.WriteLine ("Belo Horisonte a Vitoria/ES");
        Console.WriteLine ("escolha o transpote (c)carro (o)onibus ou (a)avião");

        escolha=char.Parse(Console.ReadLine());
     switch(escolha){
         case 'a':
         case 'A':
              tempo=50;
              break;
         case 'c':
         case 'C':
              tempo=480;
              break;
        case 'o':
        case 'O':
              tempo=660;
              break;
        default:
               tempo=-1;
               break;
 }
     if(tempo<0){
         Console.WriteLine ("transporte indisponivel");
     }
        Console.WriteLine ("para o transporte escolhido o tempo é: {0} minutos",tempo);
        }
}