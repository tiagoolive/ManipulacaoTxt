using System;
using System.Collections.Generic;
using System.IO;

namespace ManipulaçãoTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = "C:../../../Prova Estagio DEV - Anexo 1.txt";
            List<Pessoas> lista = new List<Pessoas>();
            if (File.Exists(caminho))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(caminho))
                    {
                        string linha;
                        while ((linha = reader.ReadLine()) != null){
                            Pessoas pessoa = new Pessoas();
                            if (linha.Contains("1"))
                            {
                                pessoa.Nome = linha;
                                lista.Add(pessoa);
                            }
                            Console.WriteLine(linha);
                        }
                    }
                foreach(Pessoas i in lista)
                    {
                        Console.WriteLine(i.Nome);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            else
            {
                Console.WriteLine($" O arquivo {caminho} não foi localizado");
            }
            
        }

    }
}
