using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Estacionamento {

       public int PrecoInicial { get; set; }
       public int PrecoHora { get; set; }


       private List<string> veiculos = new List<string>();


       public Calculator(int precoinicial, int precohora)
       {
            PrecoInicial = precoinicial;
            PrecoHora = precohora;
       }

       public void AdicionarVeiculo()
       {
           Console.Write("Digite a placa do veículo que deseja estacionar: ");
           string placa = Console.ReadLine();
           veiculos.Add(placa);
           Console.WriteLine("O veículo com a placa {0}, foi adicionado. ", placa);
       }

       public void RemoverVeiculo()
       {
           Console.Write("Digite a placa do veículo que deseja remover: ");
            string placa = Console.ReadLine();

           if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
           {
               Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
               int horas = 0;
               int valorTotal = 0;
               horas = int.Parse(Console.ReadLine());
               decimal ValorTotal = PrecoInicial + PrecoHora * horas;
               veiculos.Remove(placa);

               Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {ValorTotal}");


           }
       }

       public void ListarVeiculos()
       {
           if (veiculos.Any())
           {
               Console.Write("Os veiculos estacionados são: ");

               foreach (var veiculo in veiculos) {
                   Console.WriteLine(veiculo);
               }
           }
           else {
               Console.WriteLine("Não há veículos estacionados.");
           }
       }
       }
    
    }

