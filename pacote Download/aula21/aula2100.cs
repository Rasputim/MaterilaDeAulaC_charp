using System;
class Aula2100                     //lasso de repetição do while
{
    static void Main() {
        string senha="123";
        String senhauser;
        int tentativas=0;
         //---------------------------------
         do{
             Console.Clear();
             Console.WriteLine("Digite sua senha: ");
             senhauser=Console.ReadLine();
             tentativas++;
         }while(senha != senhauser);
         Console.WriteLine("Bem vindo ao Mundo ");
         Console.WriteLine("Numero de erros: {0}",tentativas);
        }
}