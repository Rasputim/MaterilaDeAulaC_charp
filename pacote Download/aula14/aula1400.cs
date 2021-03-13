using System;    //operadores condicionais if else alinhados ou dentro do outro
class Aula1200
{
    static void Main() {        //uso do else coretamante
        int nota1;
        string resultado1;
        Console.WriteLine ("Digite a nota: ");
        nota1=int.Parse(Console.ReadLine());
        if(nota1 < 4 ){
            resultado1="Reprovado";
        }else if(nota1 < 6){
            resultado1="Recuperação";
        }else{
            if(nota1>9){
                resultado1="Supar Aprovado";
            }else {
            resultado1="Aprovado";
            }
        }
        Console.WriteLine ("Resultado: {0}",resultado1);
        }
}