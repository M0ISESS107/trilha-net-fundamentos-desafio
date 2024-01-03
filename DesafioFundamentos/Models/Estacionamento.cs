namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        //alteração: mudança de List para Dictionary
        private Dictionary<string,string> veiculos = new Dictionary<string, string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
              //resolução do exercicio 
              //mudança do metodo para adicionar ao Dictionary
            Console.WriteLine("Digite a placa do veículo para registrarmos:");
           string Placa=Console.ReadLine();
           Console.WriteLine("Digite o modelo do veículo para estacionar:");
           string ModeloDoVeiculo=Console.ReadLine();
            veiculos.Add(Placa,ModeloDoVeiculo);
            Placa="";
            ModeloDoVeiculo="";

        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa


            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.ContainsKey(placa))
            {
                int horas = 0;
                decimal valorTotal = 0;
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;
             

                Console.WriteLine($"O veículo {veiculos[placa]} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
             int contador = 0;
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {

               
                Console.WriteLine("Os veículos estacionados são:");
                //alteração do foreach de tipo "string automoveis" para" var altomoveis" 
                //para poder armazenar o Dictionary 
                foreach (var automoveis in veiculos)
                {
                    Console.WriteLine($"posição N* {contador + 1} - veiculo {automoveis} ");
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
