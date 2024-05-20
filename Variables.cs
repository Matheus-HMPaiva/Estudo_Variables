using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TiposEVariaveis
{

    class Program
    {




        static void  Main(string[] args)
        {

            
            for(int  i=0; i<5; i++)
                {
                    Console.WriteLine("Valor de i é: " + i);
                }
            int numero1 = 10;
            int numero2 = 20;
            var soma = numero1 + numero2;
            Console.WriteLine("Valor da Soma = "+ soma);

            int copiaDeNumero1 = numero1;
            copiaDeNumero1 = 11;
            Console.WriteLine(numero1);
            Console.WriteLine(copiaDeNumero1);

            var quadrado1 = new Quadrado();
            quadrado1.lado = 10;

            var quadrado2 = quadrado1;
            quadrado2.lado = 11;
            Console.WriteLine(quadrado1.lado);
            Console.WriteLine(quadrado2.lado);
        }
        class Quadrado
        {
          public  int lado;
        }

    }

}


