using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacao = "";
            while (operacao != ".")
            {
                Console.Clear();
                Console.WriteLine("\t\tCALCULADORA");
                Console.WriteLine("\n\t+ = Soma\n\t- = Subtracao\n\t* = Multiplicacao\n\t/ = Divisao\n\t^ = Potencia\n\t% = Resto da divisao\n\t. = Sair");
                Console.Write("\n\tSelecione a operação: ");
                operacao = Console.ReadLine();
                Console.Clear();
                decimal result = 0, valor1, valor2;
                switch (operacao)
                {
                    case "+":
                        {
                            valor1 = recebe_valor1();
                            valor2 = recebe_valor2();
                            result = valor1 + valor2;
                            mostra_resultado(valor1, operacao, valor2, result);
                            break;
                        }
                    case "-":
                        {
                            valor1 = recebe_valor1();
                            valor2 = recebe_valor2();
                            result = valor1 - valor2;
                            mostra_resultado(valor1, operacao, valor2, result);
                            break;
                        }
                    case "*":
                        {
                            valor1 = recebe_valor1();
                            valor2 = recebe_valor2();
                            result = valor1 * valor2;
                            mostra_resultado(valor1, operacao, valor2, result);
                            break;
                        }
                    case "/":
                        {
                            valor1 = recebe_valor1();
                            valor2 = recebe_valor2();
                            result = valor1 / valor2;
                            mostra_resultado(valor1, operacao, valor2, result);
                            break;
                        }
                    case "^":
                        {
                            valor1 = recebe_valor1();
                            valor2 = recebe_valor2();
                            result = valor1;
                            for (int i = 1; i < valor2; i++)
                            {
                                result = result * valor1;
                            }
                            mostra_resultado(valor1, operacao, valor2, result);
                            break;
                        }
                    case "%":
                        {
                            valor1 = recebe_valor1();
                            valor2 = recebe_valor2();
                            result = valor1 % valor2;
                            mostra_resultado(valor1, operacao, valor2, result);
                            break;
                        }
                    case ".":
                        {
                            Console.WriteLine("\t\tCALCULADORA");
                            Console.WriteLine("Pressione qualquer tecla para sair..!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\t\tCALCULADORA");
                            Console.WriteLine("Digite uma opcao valida!");
                            break;
                        }
                }
                Console.ReadKey();
            }
        }

        public static decimal recebe_valor1()
        {
            Console.WriteLine("Entre com o primeiro valor:");
            decimal vlr1 = decimal.Parse(Console.ReadLine());
            return vlr1;
        }

        public static decimal recebe_valor2()
        {
            Console.WriteLine("Entre com o segundo valor:");
            decimal vlr2 = decimal.Parse(Console.ReadLine());
            return vlr2;
        }

        public static void mostra_resultado(decimal v1, string op, decimal v2, decimal result)
        {
            Console.WriteLine("Resultado => {0}{1}{2}={3}", v1, op, v2, result);
        }
    }
}
