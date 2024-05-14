using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_logica
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Ex_01
            int v1, v2;
            Console.WriteLine("Exercício 01 - Entre com dois números e informe o maior deles.");
            Console.WriteLine("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            v2 = int.Parse(Console.ReadLine());
            if(v1 < v2)
            {
                Console.WriteLine("O segundo valor e maior que o primeiro");
            }
            else
            {
                Console.WriteLine("O primeiro valor e maior que o segundo");
            }
            */

            /* Ex_02
            int Ex2_v1, Ex2_v2;
            Console.WriteLine("Exercício 02 - Entre com dois números e informe o maior deles. Se os números forem idênticos informe");
            Console.WriteLine("Digite o primeiro número: ");
            Ex2_v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            Ex2_v2 = int.Parse(Console.ReadLine());
            if (Ex2_v1 < Ex2_v2)
            {
                Console.WriteLine("O segundo número e maior");
            }
            else if(Ex2_v1 > Ex2_v2)
            {
                Console.WriteLine("O primeiro número e maior");
            }
            else
            {
                Console.WriteLine("Os números são iguais");
            }
            */

            //Ex_03
            int a, b, c;
            Console.WriteLine("Exercício 02 - Entre com três números e informe o maior deles. Se existirem");
            Console.WriteLine("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            c = int.Parse(Console.ReadLine());

            if(a == b)
            {
                Console.WriteLine("{0} = {1}", a, b);
            }
            else if(a == c)
            {
                Console.WriteLine("{0} = {1}", a, c);
            }else if(a > c)
            {
                Console.WriteLine("{0} e {1}", a, b);
            }else
            {
                Console.WriteLine("{0}", c);
            }

            if(a == c)
            {
                Console.WriteLine("{0} = {1}", a, b);
            }else if(a > b)
            {
                Console.WriteLine("{0} e {1}", a, c);
            }else
            {
                Console.WriteLine("{0}", b);
            }

            if(b == c)
            {
                Console.WriteLine("{0} = {1}", b, c);
            }else if(b > a)
            {
                Console.WriteLine("{0} e {1}", b, c);
            }
            else
            {
                Console.WriteLine("{0}", a);
            }

            if (a > b)
            {

            }
            else if (a > c)
            {
                Console.WriteLine("{0}", a);
            }
            else
            {
                Console.WriteLine("{0}", c);

            }
            if(b > c)
            {
                Console.WriteLine("{0}", b);
            }
            else
            {
                Console.WriteLine("{0}", c);
            }



           



        }
}
}
