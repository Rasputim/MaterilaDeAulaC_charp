using System;
class Pincipal
{
    static void Main() {

        LerArquivo(@*C:\arquicos\arq1.txt);
        }
        private static void LerArquivo(string nomeArquivo){
            using (StreamReader arquivo = File.OpenText(nomeArquivo))
    {
        string linha;
        while ((linha = arquivo.ReadLine()) != null)
        {  
            Console.WriteLine(linha);
            //ThreadPool.QueueUserWorkItem(ProcessaLinha, linha);
        }
    }

        }
}
