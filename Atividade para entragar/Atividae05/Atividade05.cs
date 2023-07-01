using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_para_entragar.Atividae05
{
    class Atividade05

    {
        public static void Main777()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu peso em kg:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / altura * altura;

            Console.WriteLine($"Olá {nome}Seu IMC {imc} é: ");

            if (imc >= 18.5)
            {
                Console.WriteLine("IMC está dentro do intervalo saudável");


            }
            else if (imc <= 25)
             {
                Console.WriteLine("IMC não está saudável");


            }
        
                
        }

    }
}
