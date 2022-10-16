using System;

namespace Desafio_Estacionamento.Models
{
   public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //Implementado!!!!!
            Console.WriteLine("Digite a placa e o modelo do veículo para estacionar:");
            String placa = Console.ReadLine();
            string modelo = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa e o modelo do veículo para remover:");

            // Implementado!!!!!
            // Pede para o usuário digitar a placa e armazena na variável placa
            
            string placa = "";
            string modelo = "";
            placa = Console.ReadLine();
            modelo = Console.ReadLine();
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu no estacionado:");

                
                               
                // Implementado!!!!!
                int horas = 0;
                decimal valorTotal = 0; 
                // Pede para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                horas = Convert.ToInt32(Console.ReadLine());
                // Realiza o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal 
                valorTotal = precoInicial + precoPorHora * horas;
                // Remove a placa digitada da lista de veículos
                veiculos.Remove(placa);
                
                

                Console.WriteLine($"O veículo modelo {modelo} com  a placa {placa} foi removido após permanecer por {horas} horas e o preço total foi de: R$ {valorTotal}.");
                Console.WriteLine("Volte sempre!");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                for(int i = 0; i < veiculos.Count(); i++){
                    Console.WriteLine("Veiculos " + veiculos[i]);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
                Console.WriteLine("Volte sempre ao Estacionamento");
            }
        }
    }
}
