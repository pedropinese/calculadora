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
                            try
                            {
                                valor1 = recebe_valor1();
                                valor2 = recebe_valor2();
                                result = valor1 + valor2;
                                mostra_resultado(valor1, operacao, valor2, result);
                            }
                            catch (FormatException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (OverflowException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            break;
                        }
                    case "-":
                        {
                            try
                            {
                                valor1 = recebe_valor1();
                                valor2 = recebe_valor2();
                                result = valor1 - valor2;
                                mostra_resultado(valor1, operacao, valor2, result);
                            }
                            catch (FormatException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (OverflowException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            break;
                        }
                    case "*":
                        {
                            try
                            {
                                valor1 = recebe_valor1();
                                valor2 = recebe_valor2();
                                result = valor1 * valor2;
                                mostra_resultado(valor1, operacao, valor2, result);
                            }
                            catch (FormatException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (OverflowException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            break;
                        }
                    case "/":
                        {
                            try
                            {
                                valor1 = recebe_valor1();
                                valor2 = recebe_valor2();
                                result = valor1 / valor2;
                                mostra_resultado(valor1, operacao, valor2, result);
                            }
                            catch (FormatException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (OverflowException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            break;
                        }
                    case "^":
                        {
                            try
                            {
                                valor1 = recebe_valor1();
                                valor2 = recebe_valor2();
                                result = valor1;
                                for (int i = 1; i < valor2; i++)
                                {
                                    result = result * valor1;
                                }
                                mostra_resultado(valor1, operacao, valor2, result);
                            }
                            catch (FormatException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (OverflowException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            break;
                        }
                    case "%":
                        {
                            try
                            {
                                valor1 = recebe_valor1();
                                valor2 = recebe_valor2();
                                result = valor1 % valor2;
                                mostra_resultado(valor1, operacao, valor2, result);
                            }
                            catch (FormatException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (OverflowException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            break;
                        }
                    case ".":
                        {
                            Console.WriteLine("\t\tCALCULADORA");
                            Console.WriteLine("\n\tPressione qualquer tecla para sair..");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\t\tCALCULADORA");
                            Console.WriteLine("\n\tDigite uma opcao valida!");
                            break;
                        }
                }
                Console.ReadKey();
            }
        }

        public static decimal recebe_valor1()
        {
            Console.WriteLine("\t\tCALCULADORA");
            Console.Write("\n\tEntre com o primeiro valor:");
            decimal vlr1 = decimal.Parse(Console.ReadLine());
            return vlr1;
        }

        public static decimal recebe_valor2()
        {
            Console.Write("\n\tEntre com o segundo valor:");
            decimal vlr2 = decimal.Parse(Console.ReadLine());
            return vlr2;
        }

        public static void mostra_resultado(decimal v1, string op, decimal v2, decimal result)
        {
            Console.WriteLine("\n\t\tResultado => {0}{1}{2}={3}", v1, op, v2, result);
        }

        public static void mostra_erro(string msg_erro)
        {
            Console.Clear();
            Console.WriteLine("\t\tCALCULADORA");
            Console.WriteLine("\n\tErro!\n\n\tMotivo: "+msg_erro);
        }
    }
}
