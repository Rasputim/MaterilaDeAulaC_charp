using System; //Metodos ou funçoes
/* pasagem de quantidade indeterminadoa de parametros
ultilisando o "params"
*/
class Aula27
{
    static void Main() {
        soma();
        Console.WriteLine("-------------------------------");
        soma(11);
        Console.WriteLine("-------------------------------");
        soma(5,17);
        Console.WriteLine("-------------------------------");
        soma(4,2,7,18);
        Console.WriteLine("-------------------------------");
        }
        static void soma(params int[]n){
            int res=0;
            if(n.Length < 1){
                Console.WriteLine("Nâo existem valores para serem somados");
            }else if(n.Length<2){
               Console.WriteLine("o valor é insulficiente {0}",n[0]);
            }else{
                for(int i=0;i<n.Length;i++){
                    res=res+n[i];
                }
                 Console.WriteLine("O somatorio  dos valores é: {0}",res);
            }
        }
}