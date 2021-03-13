using System;// Operadores de bit wise deslocar bit´s para direita ou esquerda
class Aula0900
{
    static void Main() {
        //deslocamento para direita >> cai pela metade
        //deslocamento para esquerda << dobra
        int num=10,num1=8;
        num=num>>1;
        num1=num1<<2;
        Console.WriteLine (num);
        Console.WriteLine (num1);
        }
}