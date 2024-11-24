using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Inicio: 
            Console.Write("Digite o primeiro número: ");
            int Num1 = int.Parse(Console.ReadLine());

            if (Num1 == 0)
            {
                Console.Write("O valor informado não pode ser calculado, favor informar um valor maior ou menor que 0");
            }

            Console.Write("Informe o tipo de cálculo desejado (/, x, -, +) : ");
            string Calculo = Console.ReadLine();

            Console.Write("Digite o segundo número: ");
            int Num2 = int.Parse(Console.ReadLine());

            if (Num2 == 0)
            {
                Console.Write("O valor informado não pode ser calculado, favor informar um valor maior ou menor que 0");
            }


            int Resultado;
            switch (Calculo)
            {
                case "/":
                case ":":
                    Resultado = Num1 / Num2;
                    Console.Write(Resultado + "\n");
                    break;

                case "x":
                case "X":
                    Resultado = Num1 * Num2;
                    Console.Write(Resultado + "\n");
                    break;

                case "-":
                    Resultado = Num1 - Num2;
                    Console.Write(Resultado + "\n");
                    break;

                case "+":
                    Resultado = Num1 + Num2;
                    Console.Write(Resultado + "\n");
                    break;

                default:
                    Console.Write("A informação de cálculo digitada não é compátivel! Reiniciando cálculo...\n");
                    goto Inicio;
            }

            Console.Write("Deseja realizar outro cálculo? (S/N) ");
            string Resposta = Console.ReadLine();

            if (Resposta == "S")
            {
                Console.Clear();
                goto Inicio;
            }
        }
    }
}
