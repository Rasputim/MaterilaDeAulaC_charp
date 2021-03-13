using System;   //enumeradores criar tipo e definie o tipo que pode ser recebido
class Aula1000{
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};
    
    static void Main(){
       DiasSemana ds = DiasSemana.Domingo;
        Console.WriteLine (ds);
    }
}
