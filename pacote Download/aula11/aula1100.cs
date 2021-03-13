using System;//operação de type cast conveção de um tipo en outro
class Aula1100
{
    static void Main() {     //operação segura
        int n1=8;
        float n2=n1;
        Console.WriteLine (n2);
         //----------------------
        float n3=10.5f;           //type cast converte perdendo parte do numero insegura
        int n4=(int)n3;
        Console.WriteLine (n4);
        }
}