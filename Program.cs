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
            

            //Ex_4
            int base_ex4, altura_ex4, area_ex4;
            Console.WriteLine("Exercício 4 - Calcule a área de um retângulo. Se a área for maior que 100, exibir mensagem --Terreno Grande.");
            Console.WriteLine("Insira a base em metros...");
            base_ex4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira altura em metros...");
            altura_ex4 = int.Parse(Console.ReadLine());

            area_ex4 = base_ex4 * altura_ex4;

            if(area_ex4 > 100)
            {
                Console.WriteLine("Área de {0}m - Terreno Grande", area_ex4);
            }
            else
            {
                Console.WriteLine("Área de {0}m", area_ex4);
            }
            

            //Ex_5
            int base_ex5, altura_ex5, area_ex5;
            Console.WriteLine("Exercício 5 - Calcule a área de um retângulo. Se a área for maior que 100, exibir mensagem --Terreno Grande. Caso contrário, exibir --Terreno Pequeno");
            Console.WriteLine("Insira a base em metros...");
            base_ex5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira altura em metros...");
            altura_ex5 = int.Parse(Console.ReadLine());

            area_ex5 = base_ex5 * altura_ex5;

            if (area_ex5 > 100)
            {
                Console.WriteLine("Área de {0}m - Terreno Grande", area_ex5);
            }
            else
            {
                Console.WriteLine("Área de {0}m - Terreno Pequeno", area_ex5);
            }

            //Ex_6
            Double peso_ex6, altura_ex6, peso_idealEx6;
            Console.WriteLine("Exercício 6 - Inserir peso e altura de uma pessoa. E exibir se esta pessoa está com o peso ideal.");
            Console.WriteLine("Insira o peso da pessoa em quilos...");
            peso_ex6 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura da pessoa em metros...");
            altura_ex6 = Double.Parse(Console.ReadLine());

            peso_idealEx6 = peso_ex6 / (altura_ex6* altura_ex6);

            if(peso_idealEx6 < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if(peso_idealEx6 <= 20 && peso_idealEx6 < 25){
                Console.WriteLine("Peso ideal");
            }
            else
            {
                //R>25 = Acima do peso
                Console.WriteLine("Acima do peso");
            }
            

            //Ex_7
            Console.WriteLine("Exercício 7 - Insira três valores e confirme se eles formam um triangulo. Se positivo, exiba sua classificação: isósceles, escaleno e equilátero.");
            Console.WriteLine("Digite o lado 1 do triângulo...");
            double lado1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2 do triângulo...");
            double lado2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 3 do triângulo...");
            double lado3 = Double.Parse(Console.ReadLine());

            if (triangulo(lado1, lado2, lado3))
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os valores inseridos não formam um triângulo");
            }


            //Ex_8
            Double lado1_ex8, lado2_ex8, lado3_ex8;
            Console.WriteLine("Exercício 8 - Inserir três valores e verificar se formam um triângulo retângulo.");
            Console.WriteLine("Digite o lado A");
            lado1_ex8 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado B");
            lado2_ex8 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado C");
            lado3_ex8 = Double.Parse(Console.ReadLine());

            if(trianguloRetângulo(lado1_ex8, lado2_ex8, lado3_ex8))
            {
                Console.WriteLine("Os valores formam um triângulo retângulo.");
            }
            else
            {
                Console.WriteLine("Os valores NÃO formam um triângulo retângulo.");
            }

            
            //Ex_9
            Console.WriteLine("Exercício 9 - Verificar o peso ideal levando em consideração o sexo do indivíduo.");
            Console.WriteLine("Insira o peso da pessoa em Kg...");
            double peso_ex9 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura da pessoa em M...");
            double altura_ex9 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sexo da pessoa M(masculino) - F(feminino).");
            char sexo = char.Parse(Console.ReadLine());

            double imc = CalcularIMC(peso_ex9, altura_ex9);
            if(sexo == 'M')
            {
                if (imc < 20)
                {
                    Console.WriteLine("Abaixo do peso");
                }else if(imc <= 20 && imc < 25)
                {
                    Console.WriteLine("Peso ideal");
                }else if(imc >= 25)
                {
                    Console.WriteLine("Acima do peso");
                }
            }else if(sexo == 'F')
            {
                if (imc < 19)
                {
                    Console.WriteLine("Abaixo do peso");
                }else if(imc <= 19 && imc < 24)
                {
                    Console.WriteLine("Peso ideal");
                }else if(imc >= 24)
                {
                    Console.WriteLine("Acima do peso");
                }
            }else
            {
                Console.WriteLine("Sexo inválido! Insira 'M' ou 'F'!!!");
            }
            

            //Ex_10
            Double p1, p2, MediaP;
            String aluno;
            Console.WriteLine("Exercício 10 - Calcular a média entre provas P1 e P2. Informar a situação do aluno 'aprovado' e 'reprovado', sabendo que nota de aprovação e 5.");
            Console.WriteLine("Digite nome do aluno");
            aluno = Console.ReadLine();
            Console.WriteLine("Informe nota da Prova 1...");
            p1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe nota da Prova 2...");
            p2 = double.Parse(Console.ReadLine());

            MediaP = (p1 + 2*p2) / 3;

            if (MediaP < 5)
            {
                Console.WriteLine($"{aluno} foi Reprovado.");
            }else if(MediaP == 5)
            {
                Console.WriteLine($"{aluno} foi Aprovado.");
            }
            else
            {
                Console.WriteLine($"{aluno} foi Aprovado.");
            }

            */
            //Ex_11
            Double p1_ex11, p2_ex11, MediaP_ex11, f;
            String aluno;
            Console.WriteLine("Exercício 11 - Calcular a média entre provas P1 e P2. Informar a situação do aluno 'aprovado' e 'reprovado', sabendo que nota de aprovação e 5. E exibir quanto o aluno precisa tirar para ser aprovado.");
            Console.WriteLine("Digite nome do aluno");
            aluno = Console.ReadLine();
            Console.WriteLine("Informe nota da Prova 1...");
            p1_ex11 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe nota da Prova 2...");
            p2_ex11 = double.Parse(Console.ReadLine());

            MediaP_ex11 = (p1_ex11 + 2 * p2_ex11) / 3;

            f = 5 - MediaP_ex11;

            if (MediaP_ex11 < 5)
            {
                Console.WriteLine($"{aluno} foi Reprovado. Faltaram {f} pontos para aprovação.");
            }
            else if (MediaP_ex11 == 5)
            {
                Console.WriteLine($"{aluno} foi Aprovado.");
            }
            else
            {
                Console.WriteLine($"{aluno} foi Aprovado.");
            } 


        }
        //Método Ex_7 (função)
        static bool triangulo(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
        }

        //Função Ex_8 
        static bool trianguloRetângulo(double A, double B, double C)
        {
            double hipotenusa = Math.Max(A, Math.Max(B, C));
            if (hipotenusa == A)
            {
                return Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2);
            }else if (hipotenusa == B)
            {
                return Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2);
            }
            else
            {
                return Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);
            }
        }

        //Função Ex_9
        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura* altura);
        }
    }
}
