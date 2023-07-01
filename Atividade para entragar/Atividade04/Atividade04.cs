using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_para_entragar.Atividade04
{
    class Atividade04
    {
        public static void Main555()
        {
            Console.WriteLine( "Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if( idade < 18)
            {
                Console.WriteLine($"Você não tem idade para dirigir {idade} anos " );
            } else if ( idade >= 18 && idade < 60)
            {
                Console.WriteLine($"Você é adulto {idade} anos");
            } else
            {
                Console.WriteLine($"Você é idoso { idade} anos");
            }



        }
    }
}
