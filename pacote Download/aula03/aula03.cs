using System;
class Aula03
{
    static void Main() {
        int num1=0,num2=0,soma=0;
        char letra='c';
        float valor=5.4f;
        byte n1=10;//0 a 255
        string nome="Bruma";

        var aux=10;//não especifica tipo definido na compilação tipo int ex
        var aux1="Silas";//não especifica tipo definido na compilação tipo string ex
        num1=19;
        num2=56;
        soma=num1+num2;
        Console.WriteLine("somatorio e "+soma+"my name is"+aux1);
        }
}