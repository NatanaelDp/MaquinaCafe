using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sabor1 = "1 - Café Expresso (R$ 3,00)";
            string sabor2 = "2 - Cappuccino (R$ 4,50)";
            string sabor3 = "3 - Mocaccino (R$ 6,00)";
            string sabor4 = "4 - Água Quente (R$ 1,00)";

            Console.WriteLine("Bem-vindo à máquina de café!");
            Console.WriteLine("Insira o valor que deseja depositar:");
            double valorInserido = double.Parse(Console.ReadLine());

            Console.WriteLine("Opções de Café:");
            Console.WriteLine(sabor1);
            Console.WriteLine(sabor2);
            Console.WriteLine(sabor3);
            Console.WriteLine(sabor4);

            Console.WriteLine("Escolha a opção desejada (1-4):");
            int opcaoEscolhida = int.Parse(Console.ReadLine());

            double valorSelecionado = ObterValorCafe(opcaoEscolhida);

            if (valorSelecionado > 0 && valorInserido >= valorSelecionado)
            {
                Console.WriteLine("Preparando café. Aguarde...");

                

                Console.WriteLine("Café pronto! Aproveite.");
            }
            else
            {
                Console.WriteLine("Opção inválida ou valor inserido insuficiente. Seu dinheiro será devolvido.");
            }

            Console.WriteLine("Pressione qualquer tecla para reiniciar o atendimento.");
            Console.ReadKey();
            Console.Clear();
        }

        static double ObterValorCafe(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    return 3.00;
                case 2:
                    return 4.50;
                case 3:
                    return 6.00;
                case 4:
                    return 1.00;
                default:
                    return 0.00;






            }
        }
    }
}
