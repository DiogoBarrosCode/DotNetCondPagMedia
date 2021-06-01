using System;
using System.IO;

namespace DotNetCondPagMedia
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] condicaoPagamento = System.IO.File.ReadAllLines(@"C:\Users\Diogo\Desktop\Dev\c# - iniciante\net\DotNetCondPagMedia\entrada-de-dados.txt");

            /*
            foreach (string lines in condicaoPagamento)
                {
                     Console.WriteLine(lines);
                }
            */
            
            //Console.WriteLine(condicaoPagamento.Length);

            StreamWriter x;
            string Caminho = @"C:\Users\Diogo\Desktop\Dev\c# - iniciante\net\DotNetCondPagMedia\saida-de-dados.txt";
            
            for(int i = 0; i < condicaoPagamento.Length; i++)
            {   

               // Console.WriteLine(condicaoPagamento[i]);

                x = File.AppendText(Caminho);
                
                string[] prazo_org = condicaoPagamento[i].Split(',');

                int soma = 0;
                int r = 0;

                for(r = 0; r < prazo_org.Length; r++)
                {
                    int prazo_org2 = Convert.ToInt32(prazo_org[r]);
                    
                    soma += prazo_org2;

                }

                x.WriteLine(soma / r);

                x.Close();
                

            }
            
        
        }

    }
}