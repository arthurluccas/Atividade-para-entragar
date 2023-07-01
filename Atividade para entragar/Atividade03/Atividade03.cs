using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_para_entragar.Atividade03
{
    class Atividade03
    {
        public static void Main444()
        {
            Console.WriteLine("Digite a primeira nota");
            double N1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            double N2 = double.Parse(Console.ReadLine());

            double media = (N1 + N2) /2;

            if (N1 > 10.0 || N1 < 0)
            {
                Console.WriteLine("Primeira nota incorreta");
            } else if (N2 > 10.0 || N2 < 0)
            {
                Console.WriteLine("segunda nota incorreta");
            } else if (media >= 6)
            {
                Console.WriteLine("Aluno aprovado!! " + media);

            } else if (media <= 6)
            {
                Console.WriteLine("Aluno foi reprovado " + media);
            }
            


        }

    }
}
