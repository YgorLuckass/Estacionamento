using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Compression;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Seja bem vindo ao sistema de estacionamento! ");
            Console.Write("Digite o preço inicial: ");
            int precoinicial = int.Parse(Console.ReadLine());
            Console.Write("Agora digite o preço por hora: ");
            int precohora = int.Parse(Console.ReadLine());

            Estacionamento es = new Estacionamento (precoinicial, precohora);

            bool exibirMenu = true;
            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar veículo ");
                Console.WriteLine("2 - Remover veículo ");
                Console.WriteLine("3 - Listar veículos ");
                Console.WriteLine("4 - Encerrar ");
                Console.Write("Digite a sua opção: ");

                switch (Console.ReadLine()) {
                    case "1":
                        es.AdicionarVeiculo();
                        break;

                    case "2":
                        es.RemoverVeiculo();
                        break;

                    case "3":
                        es.ListarVeiculos();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("O programa se encerrou");






        }
        }
    }










        
    


