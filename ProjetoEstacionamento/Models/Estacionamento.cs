using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora) { 
            
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;

        }

        public void AdicionarVeiculo() {
            string placa = "";
            try
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                placa = Console.ReadLine();

                if(veiculos.Any(veiculo => placa.ToUpper() == veiculo.ToUpper())) {
                    throw new Exception("Veículo já cadastrado!");
                }
                veiculos.Add(placa);
                Console.WriteLine("Veículo adicionado com sucesso!");

            } catch (Exception e){

                Console.WriteLine($"Ocoreu um erro ao adionar o veículo: {e.Message}");
                
            }
        }

        public void RemoverVeiculo()
        {
            string placa = "";
            int horas = 0;
            decimal total = 0;

            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();
            try
            {
                if (!(veiculos.Any(veiculo => veiculo.ToUpper() == placa.ToUpper())))
                {
                    throw new Exception("Veículo não cadastrado.");
                }

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());

                total = PrecoInicial + PrecoPorHora * horas;

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {total}");

                veiculos.Remove(placa);


            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        public void ListarVeiculos()
        {
            if(!veiculos.Any())
            {
                Console.WriteLine("Sem veículos no momento.");
            }
            else
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach(var veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo}");
                }
            }
        }
    }  

}
