using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_para_entragar
{
    class Atividade01
    {
         static void Main111(string[] args)
        {
            //  •Qual o nome do usuári
            //1 - Utilizando os conceitos apresentados, pergunte via termino;
            //•Qual sua idade; 
            //•Bairro onde mora;
            //•Passe o nome do usuário para todas as letras em maiúscula.



            Console.WriteLine($"Qual seu nome ?");
            string nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Qual sua idade ?");
            string idade = Console.ReadLine();

            Console.WriteLine("Qual seu bairro ?");
            string bairro = Console.ReadLine();

            Console.WriteLine("Seu nome é " + nome );
            Console.WriteLine("Sua idade é " + idade);
            Console.WriteLine("Seu bairro é " + bairro);



        }
    }
}
