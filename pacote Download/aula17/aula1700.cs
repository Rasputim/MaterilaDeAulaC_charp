using System;       //array ou vetor
class aula1700
{
    static void Main() {
        int[] n=new int[5]; //primeira posição no indice 0 e o ultimo 4
        int[] num=new int[3]{55,77,99};
        int[] num1={55,77,99}; // tamanhao da memoria determinada pelo numero de elementos no caso 3
        string [] veiculo=new string[3];
        veiculo [0]="carro";
        veiculo [1]="moto";
        veiculo [2]="avião";
        n[0]=111;
        n[1]=222;
        n[2]=333;
        n[3]=444;
        n[4]=555;

        Console.WriteLine(num1[1]+num[2]+n[0]);
        Console.WriteLine("veiculo escolhido {0}",veiculo[2]);
        }
}