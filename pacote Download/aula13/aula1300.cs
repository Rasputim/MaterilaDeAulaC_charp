using System;    //operadores condicionais if else
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
            resultado1="Aprovado";
        }
        Console.WriteLine ("Resultado: {0}",resultado1);
        }
}