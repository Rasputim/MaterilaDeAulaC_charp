using System;    //operadores condicionais if else
class Aula1200
{
    static void Main() {
        int nota=80;
        string resultado="Reprovado";
        if(nota >= 60){
            resultado="Aprovado";
        }
        Console.WriteLine ("Resultado: {0}",resultado);
        //-----------------------------------
        int nota1;
        string resultado1="Reprovado";
        Console.WriteLine ("Digite a nota: ");
        nota1=int.Parse(Console.ReadLine());
        if(nota1 >= 60){
            resultado1="Aprovado";
        }
        Console.WriteLine ("Resultado: {0}",resultado1);
        }
}