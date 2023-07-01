using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_para_entragar.Atividae08
{
    class Atividade08
    {
        public static void Main()
        {
            int N1;
            int par = 0;
            

            Console.WriteLine("Digite um numero inteiro");
            N1 = int.Parse(Console.ReadLine());

            do
            {
                
                
                if(N1< 0)
                {
                    Console.WriteLine("numero incorreto");
                }
                else 
                {
                    if (par % 2 == 0) 
                    {
                        
                        int par1 = par;
                        Console.WriteLine("Numero par: " + par1);

                    }
                    par = par + 1;
                }
            } while (par <= N1);




        }

    }
}
