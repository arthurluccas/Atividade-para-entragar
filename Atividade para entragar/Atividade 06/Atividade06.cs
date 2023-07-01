using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_para_entragar.Atividade_06
{
    class Atividade06
    {
        public static void Main333()
        {

            string[]  nomes = new string[5] ;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o nome de uma aluno ");
                nomes[i] = Console.ReadLine();
            } 
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            
            
        }
    }
}
