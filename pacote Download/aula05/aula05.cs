using System;
//operadores existem os logocos  comparação negação bitwrise
class Aula05{
    static void Main() {
        int res=(10+5)*3;//operadores matematicos +,-,/,%,*e atribuição 
        Console.WriteLine ("resultado da operação "+res);
        bool res1=10<5;//variaves bolianas e relacionais >,<,>=,<=,==,=!
        Console.WriteLine ("resultado boliano "+res1);
        int num3=10;
        num3++;//operador de incremento e decremento
        Console.WriteLine ("icremental "+num3);
        //& = AND/E
        //| = OR/OU
        bool res2=(5>3)|(10<5);
        Console.WriteLine ("oprerador logico "+res2);

        }
}