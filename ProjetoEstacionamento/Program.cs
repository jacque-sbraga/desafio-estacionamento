using ProjetoEstacionamento.Models;

namespace ProjetoEstacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal preco = 0;
            decimal precoHora = 0;
            bool exibirMenu = true;
            Estacionamento estacionamento;

            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");

            preco = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preço por hora:");

            precoHora = Convert.ToDecimal(Console.ReadLine());

            estacionamento = new Estacionamento(preco, precoHora);
            while(exibirMenu)
            {
                Console.WriteLine("\nDigite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        estacionamento.AdicionarVeiculo();
                        break;

                    case "2":
                        estacionamento.RemoverVeiculo();
                        break;

                    case "3":
                        estacionamento.ListarVeiculos();
                        break;
                     
                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
            }

        }
    }
}
