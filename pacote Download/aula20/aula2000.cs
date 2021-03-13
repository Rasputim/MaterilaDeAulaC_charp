using System; //lassos de repetição while para loops infinitos
class aula2000
{
    static void Main() {
        int[] num=new int[10];
        int j=0;
        while(j<10){
         Console.WriteLine ("conta ate 10 {0}",j);
         j++;
        }
        for(int i=0;i<10;i++){
            num[i]=0;
        Console.WriteLine ("valor pos... {0}  é {1}",i,num[i]);
        }
        Console.WriteLine ("agora acabou");
        }
}